using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Diagnostics;
using ToastNotification.Models;

namespace ToastNotification.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INotyfService _toastNotification;


        /*private readonly IToastNotification _toastNotification;*/

        public HomeController(ILogger<HomeController> logger, INotyfService toastNotification)
        {
            _logger = logger;
            _toastNotification = toastNotification;
        }

        public IActionResult Index()
        {

            /*
             * // Success Toast
            _toastNotification.AddSuccessToastMessage("Woo hoo - it works!");

            // Info Toast
            _toastNotification.AddInfoToastMessage("Here is some information.");

            // Error Toast
            _toastNotification.AddErrorToastMessage("Woops an error occured.");

            // Warning Toast
            _toastNotification.AddWarningToastMessage("Here is a simple warning!");
            */
            _toastNotification.Success("A success for christian-schou.dk");
            _toastNotification.Information("Here is an info toast - closes in 6 seconds.", 6);
            _toastNotification.Warning("Be aware, here is a warning toast.");
            _toastNotification.Error("Ouch - An error occured. This message closes in 4 seconds.", 4);

            _toastNotification.Custom("Here is a message for you - closes in 8 seconds.", 8, "#602AC3", "fa fa-envelope-o");
            _toastNotification.Custom("Please check the settings for your profile - closes in 6 seconds.", 6, "#0c343d", "fa fa-user");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}