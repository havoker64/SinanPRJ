using Microsoft.AspNetCore.Mvc;
using Sinan.Models;
using System.Diagnostics;

namespace Sinan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Notify()
        {
            return View();
        }

        public IActionResult Consult()
        {
            return View();
        }


    }
}