using AvicennaDispensing.Data;
using AvicennaDispensing.Helpers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Localization;
using System.Text.Json;

namespace AvicennaDispensing.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ApplicationDbContext _context;
        protected string _UserID = null!;
        protected string? _ControllerName = null!;

        public BaseController(ApplicationDbContext context)
        {
            _context = context;
        }
        public void onView()
        {
            ViewBag.Mode = AppEnum.DataMode.View;
        }
        protected virtual void onEdit()
        {
            ViewBag.Mode = AppEnum.DataMode.Edit;
        }
        protected virtual void onSaveCancel()
        {
            ViewBag.Mode = AppEnum.DataMode.View;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            _UserID = User.FindFirst(ClaimTypesCustom.UserID)?.Value ?? "";
            _ControllerName = ControllerContext.RouteData.Values["controller"]?.ToString();
            
            if (string.IsNullOrEmpty(_UserID))
            {
                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new { controller = "Login", action = "Index" }));
                return;
            }
            
            // Validate if user still exists in database (important for Remember Me scenarios)
            // This prevents deleted users from accessing the system with old persistent cookies
            var userExists = _context.AppUsers.Any(u => u.UserID == _UserID);
            
            if (!userExists)
            {
                Serilog.Log.Warning($"Login failed with RememberMe feature because UserID is no longer exist on database");
                
                // Sign out the user and clear cookies
                HttpContext.SignOutAsync("CookieAuth").Wait();
                HttpContext.Response.Cookies.Delete("UserLanguage");
                HttpContext.Response.Cookies.Delete("UserTheme");
                HttpContext.Response.Cookies.Delete("AvicennaDispensingRememberMe");
                
                // Redirect to login with error message
                TempData["ErrorMessage"] = "Your account is no longer active. Please contact administrator.";
                
                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new { controller = "Login", action = "Index" }));
                return;
            }
        }
        public List<T> LoadSavedData<T>(string[]? TempDataKeys = null, string originalDataKey = "OriginalData") where T : class
        {
            TempDataKeys ??= ["OriginalData"];
            var loadData = new List<T>();
            if (TempData[originalDataKey] is string json && !string.IsNullOrWhiteSpace(json))
            {
                try
                {
                    loadData = JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
                }
                catch (JsonException ex)
                {
                    // Logging jika ada masalah parsing JSON
                    Console.WriteLine($"Deserialization failed: {ex.Message}");
                }
            }
            if(TempDataKeys != null)
            {
                foreach (var key in TempDataKeys)
                {
                    TempData.Keep(key);
                }
            }
            return loadData;
        }
    }
}
