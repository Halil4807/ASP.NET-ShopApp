using System;
using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.Controllers
{

    // localhost:5000
    public class HomeController : Controller
    {
        // localhost:5000/home/index
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            string mesaj = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.Greeting = mesaj;

            ViewBag.UserName = "Halil";
            return View();
        }

        // localhost:5000/home/about
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}