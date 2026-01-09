using AvicennaDispensing.Data;
using AvicennaDispensing.Helpers;
using AvicennaDispensing.Models;
using AvicennaDispensing.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Serilog;
using System.Reflection;
using System.Security.Claims;
using System.Text.Json;
using SettingsResources = AvicennaDispensing.Resources.Views.Settings;

namespace AvicennaDispensing.Controllers
{
    public class SettingsController : BaseController
    {
        private readonly IStringLocalizer _sharedlocalizer;
        private readonly IStringLocalizer<SettingsResources.Index> _localizer;
        public SettingsController(ApplicationDbContext context, IStringLocalizerFactory localizerFactory, IStringLocalizer<SettingsResources.Index> localizer) : base(context)
        {
            _sharedlocalizer = localizerFactory.Create("Views.Shared.Common", Assembly.GetExecutingAssembly().GetName().Name!);
            _localizer = localizer;
        }

        public async Task<IActionResult> Index()
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Index)}");

            var user = await _context.AppUsers.FirstOrDefaultAsync(u => u.UserID == _UserID);

            var viewmodel = new SettingsViewModel
            {
                UserID = _UserID,
                UserName = user!.UserName,
                Email = user.Email
            };
            ViewData["SaveEnable"] = true;
            return View(viewmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest request)
        {
            try
            {
                Log.Information($"{_UserID} Attempting to change password");

                var user = await _context.AppUsers.FirstOrDefaultAsync(u => u.UserID == _UserID);
                if (user == null)
                {
                    return Json(new { success = false, message = _localizer["UserNotFound"] });
                }

                // Verify current password
                var encryptedCurrentPassword = Encryptor.Encrypt(request.CurrentPassword);
                if (user.Password != encryptedCurrentPassword)
                {
                    return Json(new { success = false, message = _localizer["CurrentPasswordIsIncorrect"] });
                }

                // Validate new password
                if (request.NewPassword != request.ConfirmPassword)
                {
                    return Json(new { success = false, message = _localizer["PasswordMismatchMessage"] });
                }

                if (request.NewPassword.Length < 6)
                {
                    return Json(new { success = false, message = _localizer["PasswordMustBeAtLeast"] });
                }

                // Update password
                user.Password = Encryptor.Encrypt(request.NewPassword);
                user.LastUpdateDateTime = DateTime.Now;
                user.LastUpdateByUserID = _UserID;

                await _context.SaveChangesAsync();

                Log.Information($"{_UserID} Password changed successfully");
                return Json(new { success = true, message = _localizer["PasswordChangedSuccessfully"] });
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Error in {nameof(ChangePassword)} for user {_UserID}");
                return Json(new { success = false, message = _sharedlocalizer["AnErrorOccurred"] });
            }
        }

        public async Task<IActionResult> UpdateLanguage(string language)
        {
            try
            {
                Log.Information($"{_UserID} Updating language to {language}");

                // Update database
                var dispensingSetting = await _context.AVCDispensingSettings
                    .FirstOrDefaultAsync(s => s.UserID == _UserID);

                dispensingSetting!.Language = language;
                dispensingSetting.LastUpdatebyTime = DateTime.Now;

                await _context.SaveChangesAsync();

                // Set cookie with same persistence as auth cookie
                // Check if auth cookie is persistent (Remember Me was used)
                var cookieOptions = new CookieOptions
                {
                    HttpOnly = false,
                    Secure = true,
                    SameSite = SameSiteMode.Lax
                };
                
                // If user has persistent auth cookie (Remember Me), make preference cookies persistent too
                if (HttpContext.Request.Cookies.TryGetValue("Avicenna.Cookie", out _))
                {
                    // Check if it's a persistent cookie by trying to read UserLanguage expiry
                    if (HttpContext.Request.Cookies.TryGetValue("UserLanguage", out var existingLangCookie) && 
                        !string.IsNullOrEmpty(existingLangCookie))
                    {
                        // Preserve persistence setting
                        cookieOptions.Expires = DateTimeOffset.Now.AddDays(30);
                    }
                }
                
                Response.Cookies.Append("UserLanguage", language, cookieOptions);

                Log.Information($"{_UserID} Language updated successfully");
                return Json(new { 
                    success = true, 
                    message = _localizer["LanguageUpdatedSuccessfully"], 
                    language = language,
                    requiresReload = true
                });
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Error in {nameof(UpdateLanguage)} for user {_UserID}");
                return Json(new { success = false, message = _sharedlocalizer["AnErrorOccurred"] });
            }
        }

        public async Task<IActionResult> UpdateTheme(string theme)
        {
            try
            {
                Log.Information($"{_UserID} Updating theme to {theme}");

                // Update database
                var dispensingSetting = await _context.AVCDispensingSettings
                    .FirstOrDefaultAsync(s => s.UserID == _UserID);
       
                dispensingSetting!.Theme = theme;
                dispensingSetting.LastUpdatebyTime = DateTime.Now;

                await _context.SaveChangesAsync();

                // Set cookie with same persistence as auth cookie
                var cookieOptions = new CookieOptions
                {
                    HttpOnly = false,
                    Secure = true,
                    SameSite = SameSiteMode.Lax
                };
                
                // If user has persistent auth cookie (Remember Me), make preference cookies persistent too
                if (HttpContext.Request.Cookies.TryGetValue("Avicenna.Cookie", out _))
                {
                    // Check if it's a persistent cookie by trying to read UserTheme expiry
                    if (HttpContext.Request.Cookies.TryGetValue("UserTheme", out var existingThemeCookie) && 
                        !string.IsNullOrEmpty(existingThemeCookie))
                    {
                        // Preserve persistence setting
                        cookieOptions.Expires = DateTimeOffset.Now.AddDays(30);
                    }
                }
                
                Response.Cookies.Append("UserTheme", theme, cookieOptions);

                Log.Information($"{_UserID} Theme updated successfully");
                
                // Return flag to reload page (to refresh AntiForgery token)
                return Json(new { 
                    success = true, 
                    message = _localizer["ThemeUpdatedSuccessfully"],
                    //requiresReload = true // Signal frontend to reload page
                });
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Error in {nameof(UpdateTheme)} for user {_UserID}");
                return Json(new { success = false, message = _sharedlocalizer["AnErrorOccurred"] });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateProfile([FromBody] JsonElement request)
        {
            try
            {
                string Email = request.GetProperty("Email").GetString()!.Trim();
                Log.Information($"{_UserID} Updating profile");

                var user = await _context.AppUsers.FirstOrDefaultAsync(u => u.UserID == _UserID);
                if (user == null)
                {
                    return Json(new { success = false, message = _localizer["UserNotFound"] });
                }

                user.Email = Email;
                user.LastUpdateDateTime = DateTime.Now;
                user.LastUpdateByUserID = _UserID;

                await _context.SaveChangesAsync();

                Log.Information($"{_UserID} Profile updated successfully");
                return Json(new { success = true, message = _localizer["ProfileUpdatedSuccessfully"] });
            }
            catch (Exception ex)
            {
                Log.Error(ex, $"Error in {nameof(UpdateProfile)} for user {_UserID}");
                return Json(new { success = false, message = _sharedlocalizer["AnErrorOccurred"] });
            }
        }
    }
}
