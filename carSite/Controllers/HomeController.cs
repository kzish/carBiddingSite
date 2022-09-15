using carSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace carSite.Controllers
{
    [Route("")]
    [Route("Home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            ViewBag.cars = Cars.cars;
            return View();
        }

        [Route("Advert")]
        public IActionResult Advert(int id)
        {
            ViewBag.car = Cars.cars[id];
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}