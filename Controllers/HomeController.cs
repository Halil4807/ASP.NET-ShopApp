using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{

    // localhost:5000
    public class HomeController : Controller
    {
        // localhost:5000/home/index
        public IActionResult Index()
        {
                        var products = new List<Product>()
            {
                new Product{Name="Iphone 8",Price=6000,Description="İyi telefon",IsApproved=false},
                new Product{Name="Iphone 9",Price=7000,Description="Nice telefon",IsApproved=true},
                new Product{Name="Iphone X",Price=9000,Description="Çok iyi telefon",IsApproved=true},
                new Product{Name="Iphone 11",Price=10000,Description="Güzel telefon"}
            };

            var productViewModel = new ProductViewModel()
            {
                Products = products
            };

            return View(productViewModel);
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