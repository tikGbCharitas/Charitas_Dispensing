using System.Security.Claims;
using AvicennaDispensing.Data;
using AvicennaDispensing.Helpers;
using AvicennaDispensing.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Serilog;

namespace AvicennaDispensing.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ProgramSettings _settings;

        public LoginController(ApplicationDbContext context, IOptions<ProgramSettings> options)
        {
            _context = context;
            _settings = options.Value;
        }

        public IActionResult Index()
        {
            if(TempData["user_id"] != null)
            {
                ViewBag.UserID = TempData["user_id"];
            }
            if (TempData["ErrorMessage"] != null)
            {
                ViewBag.ErrorMessage = TempData["ErrorMessage"];
            }
            return View();
        }       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string userid, string password, bool rememberMe = false)
        {
            // Here you would typically validate the user credentials against a database
            // For simplicity, we are just checking if they are not empty
            if (!string.IsNullOrEmpty(userid) && !string.IsNullOrEmpty(password))
            {
                userid = userid.Trim();
                string passwordHash = Encryptor.Encrypt(password.Trim());
                var Registered = _context.AppUsers.FirstOrDefault(u => u.UserID == userid && u.Password == passwordHash);

                if (Registered == null)
                {
                    // If user is not found, return the same view with an error message
                    TempData["ErrorMessage"] = "Invalid username or password.";
                    TempData["user_id"] = userid;
                    TempData["rememberMe"] = rememberMe;
                    Log.Error($"Login failed for user: {userid}");
                    return RedirectToAction("Index");
                }

                var user = _context.AppUsers
                    .Join(_context.AppUserServiceUnits, au => au.UserID, ausu => ausu.UserID,
                            (au, ausu) => new { au, ausu })
                    .Where(u => u.au.UserID == userid && u.au.Password == passwordHash);

                var userAuthority = (
                                    from auug in _context.AppUserUserGroups
                                    where auug.UserID == userid

                                    join augp in _context.AppUserGroupPrograms
                                    on auug.UserGroupID equals augp.UserGroupID
                                    where augp.ProgramID == _settings.TargetProgramId

                                    select new
                                    {
                                        auug.UserID,
                                        GroupID = auug.UserGroupID,
                                        CRUD = augp.IsUserGroupAddAble.GetValueOrDefault()
                                                && augp.IsUserGroupEditAble.GetValueOrDefault()
                                                && augp.IsUserGroupDeleteAble.GetValueOrDefault()
                                                && augp.IsUserGroupApprovalAble.GetValueOrDefault(),
                                        Export = augp.IsUserGroupExportAble
                                    }
                                    ).ToList();

                Log.Information("UserAuthority for {User}: {Authority}",
                    userid,
                    string.Join("; ", userAuthority.Select(a => $"Group:{a.GroupID} CRUD:{a.CRUD} Export:{a.Export}")));

                var DispensingSetting = _context.AVCDispensingSettings.FirstOrDefault(a => a.UserID == Registered.UserID);

                if (DispensingSetting == null)
                {
                    var newuserSetting = new AVCDispensingSetting
                    {
                        UserID = Registered.UserID,
                        Language = AppEnum.Language.en.ToString(),
                        Theme = AppEnum.Theme.light.ToString(),
                        LastUpdatebyTime = DateTime.Now
                    };
                    _context.AVCDispensingSettings.Add(newuserSetting);
                    await _context.SaveChangesAsync();
                    DispensingSetting = _context.AVCDispensingSettings.FirstOrDefault(a => a.UserID == Registered.UserID);
                }

                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, Registered.UserID),
                    new Claim(ClaimTypesCustom.UserID, Registered.UserID),
                    new Claim(ClaimTypesCustom.UserName, Registered.UserName),
                    new Claim(ClaimTypesCustom.Role, Registered.SRUserType ?? string.Empty),
                    new Claim(ClaimTypesCustom.Service_Unit, string.Join("|", user.Select(x => x.ausu.ServiceUnitID).ToList()) ?? string.Empty),
                    new Claim(ClaimTypesCustom.CRUD, userAuthority.Any(a => a.CRUD == true).ToString().ToLower()),
                    new Claim(ClaimTypesCustom.Export, userAuthority.Any(a => a.Export == true).ToString().ToLower())
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                // Configure authentication properties based on Remember Me checkbox
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = rememberMe, // If true, cookie persists across browser sessions
                    ExpiresUtc = rememberMe ? DateTimeOffset.UtcNow.AddDays(30) : null
                };

                await HttpContext.SignOutAsync("CookieAuth");
                await HttpContext.SignInAsync("CookieAuth", principal, authProperties);
                
                // Set user preference cookies on login for immediate availability
                // Cookie persistence based on Remember Me checkbox
                var cookieOptions = new CookieOptions
                {
                    HttpOnly = false,
                    Secure = true,
                    SameSite = SameSiteMode.Lax
                };
                
                // If Remember Me is checked, make cookies persistent (30 days)
                if (rememberMe)
                {
                    cookieOptions.Expires = DateTimeOffset.Now.AddDays(30);
                    Response.Cookies.Append("AvicennaDispensingRememberMe", "true", cookieOptions);
                    Response.Cookies.Append("UserLanguage", DispensingSetting!.Language!, cookieOptions);
                    Response.Cookies.Append("UserTheme", DispensingSetting.Theme!, cookieOptions);
                }
                else
                {
                    // Ensure RememberMe cookie is deleted if not checked
                    Response.Cookies.Delete("AvicennaDispensingRememberMe");

                    // Otherwise, cookies are session-based (deleted when browser closes)
                    Response.Cookies.Append("UserLanguage", DispensingSetting!.Language!, cookieOptions);
                    Response.Cookies.Append("UserTheme", DispensingSetting.Theme!, cookieOptions);
                }
                
                // Redirect to the home page or another action upon successful login
                Log.Information($"Login successful for user: {userid} (Remember Me: {rememberMe})");
                return RedirectToAction("Index", "Home");
            }
            // If validation fails, return the same view with an error message
            TempData["ErrorMessage"] = "Username or password cannot be empty.";
            TempData["user_id"] ??= userid;
            TempData["rememberMe"] = rememberMe;
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            var UserID = User.FindFirst(ClaimTypesCustom.UserID)?.Value;
            
            await HttpContext.SignOutAsync("CookieAuth");
            
            // Clear user preference cookies to prevent leakage to next user
            Response.Cookies.Delete("UserLanguage");
            Response.Cookies.Delete("UserTheme");
            Response.Cookies.Delete("AvicennaDispensingRememberMe");
            
            Log.Information($"{UserID} logged out.");
            
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DevLogin(bool rememberMe = false)
        {
            var user = _context.AppUsers
                                .Join(_context.AppUserServiceUnits, au => au.UserID, ausu => ausu.UserID,
                                        (au, ausu) => new { au, ausu })
                                .Where(u => u.au.UserID == "sci");

            var userAuthority = (
                                    from auug in _context.AppUserUserGroups
                                    where auug.UserID == user.FirstOrDefault()!.au.UserID

                                    join augp in _context.AppUserGroupPrograms
                                    on auug.UserGroupID equals augp.UserGroupID
                                    where augp.ProgramID == _settings.TargetProgramId

                                    select new
                                    {
                                        auug.UserID,
                                        GroupID = auug.UserGroupID,
                                        CRUD = augp.IsUserGroupAddAble.GetValueOrDefault()
                                                && augp.IsUserGroupEditAble.GetValueOrDefault()
                                                && augp.IsUserGroupDeleteAble.GetValueOrDefault()
                                                && augp.IsUserGroupApprovalAble.GetValueOrDefault(),
                                        Export = augp.IsUserGroupExportAble
                                    }
                                    ).ToList();

            var devUserId = user.FirstOrDefault()!.au.UserID;
            var DispensingSetting = _context.AVCDispensingSettings.FirstOrDefault(a => a.UserID == devUserId);

            if (DispensingSetting == null)
            {
                var newuserSetting = new AVCDispensingSetting
                {
                    UserID = devUserId,
                    Language = AppEnum.Language.en.ToString(),
                    Theme = AppEnum.Theme.light.ToString(),
                    LastUpdatebyTime = DateTime.Now
                };
                _context.AVCDispensingSettings.Add(newuserSetting);
                await _context.SaveChangesAsync();
                DispensingSetting = _context.AVCDispensingSettings.FirstOrDefault(a => a.UserID == devUserId);
            }

            var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, devUserId),
                    new Claim(ClaimTypesCustom.UserID, devUserId),
                    new Claim(ClaimTypesCustom.Role, (user.FirstOrDefault())!.au.SRUserType ?? ""),
                    new Claim(ClaimTypesCustom.Service_Unit, string.Join("|", user.Select(x => x.ausu.ServiceUnitID).ToList()) ?? string.Empty),
                    new Claim(ClaimTypesCustom.CRUD, "true"),
                    new Claim(ClaimTypesCustom.Export, "true")
                };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            // Configure authentication properties based on Remember Me checkbox
            var authProperties = new AuthenticationProperties
            {
                IsPersistent = rememberMe, // If true, cookie persists across browser sessions
                ExpiresUtc = rememberMe ? DateTimeOffset.UtcNow.AddDays(30) : null
            };

            await HttpContext.SignOutAsync("CookieAuth");
            await HttpContext.SignInAsync("CookieAuth", principal, authProperties);

            var cookieOptions = new CookieOptions
            {
                HttpOnly = false,
                Secure = true,
                SameSite = SameSiteMode.Lax
            };

            if (rememberMe)
            {
                cookieOptions.Expires = DateTimeOffset.Now.AddDays(30);
                Response.Cookies.Append("AvicennaDispensingRememberMe", "true", cookieOptions);
            }
            else
            {
                // Ensure RememberMe cookie is deleted if not checked
                Response.Cookies.Delete("AvicennaDispensingRememberMe");
            }

            // Set user preference cookies on login for immediate availability
            // Session cookies (deleted when browser closes) for better security on shared computers
            Response.Cookies.Append("UserLanguage", DispensingSetting!.Language!, cookieOptions);
            Response.Cookies.Append("UserTheme", DispensingSetting.Theme!, cookieOptions);

            Log.Information($"DevLogin successful for user: {devUserId} (Remember Me: {rememberMe})");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Settings()
        {
            Log.Information($"{User.FindFirst(ClaimTypes.Name)?.Value} Accessing Login on method {nameof(Settings)}");
            return RedirectToAction("Index", "Settings");
        }
    }
}
