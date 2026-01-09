using AvicennaDispensing.Data;
using AvicennaDispensing.Helpers;
using AvicennaDispensing.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace AvicennaDispensing.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger) : base(context)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Index)}");
            return View();
        }

        public IActionResult Privacy()
        {
            Log.Information($"{_UserID} Accessing {_ControllerName} on method {nameof(Privacy)}");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult HandleAJAXStatusCode(int code)
        {
            var message = code switch
            {
                400 => "Bad Request - The request cannot be processed.",
                401 => "Unauthorized - Access is denied.",
                403 => "Forbidden - You don't have permission.",
                404 => "Not Found - The resource could not be found.",
                500 => "Internal Server Error - Something went wrong.",
                _ => "An unexpected error has occurred."
            };

            ViewData["StatusCode"] = code;
            ViewData["ErrorMessage"] = message;

            return View("Error");
        }
    }
}
