using System.Diagnostics;
using DvhLesson09EF.Models;
using Microsoft.AspNetCore.Mvc;

namespace DvhLesson09EF.Controllers
{
    public class DvhHomeController : Controller
    {
        private readonly ILogger<DvhHomeController> _logger;

        public DvhHomeController(ILogger<DvhHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult DvhIndex()
        {
            return View();
        }

        public IActionResult DvhAbout()
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
