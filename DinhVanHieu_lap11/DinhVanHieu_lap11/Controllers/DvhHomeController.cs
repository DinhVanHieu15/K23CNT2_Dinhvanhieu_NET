using System.Diagnostics;
using DinhVanHieu_lap11.Models;
using Microsoft.AspNetCore.Mvc;

namespace DinhVanHieu_lap11.Controllers
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
