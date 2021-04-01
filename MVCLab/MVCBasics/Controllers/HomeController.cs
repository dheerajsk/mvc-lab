using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ContentResult GetContent()
        {
            return Content("This is a sample content from ContentResult");
        }

        public RedirectToRouteResult RedirectRoute()
        {
            return new RedirectToRouteResult(new { Controller = "About", action = "Index" });
        }

        public RedirectToActionResult Index()
        {
            return RedirectToAction("Privacy");
        }

        public ViewResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = null });
        }
    }
}
