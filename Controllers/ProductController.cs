using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    // localhost:5000
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var product = new Product { Name = "Iphone X", Price = 6000, Description = "Güzel Telefon" };
            // ViewData["Category"] = "Telefonlar";
            // ViewData["Product"] = product;

            ViewBag.Category = "Telefonlar";
            // ViewBag.Product = product;

            return View(product);
        }
        // localhost:5000/product/list
        public IActionResult List()
        {
            var products = new List<Product>()
            {
                new Product{Name="Iphone 8",Price=6000,Description="İyi telefon",IsApproved=false},
                new Product{Name="Iphone 9",Price=7000,Description="Nice telefon",IsApproved=true},
                new Product{Name="Iphone X",Price=9000,Description="Çok iyi telefon",IsApproved=true},
                new Product{Name="Iphone 11",Price=10000,Description="Güzel telefon"}
            };
            var category = new Category { Name = "Telefonlar", Description = "Telefon Kategorisi" };

            var productViewModel = new ProductViewModel()
            {
                Category = category,
                Products = products
            };

            return View(productViewModel);
        }

        // localhost:5000/product/details
        public IActionResult Details(int id)
        {
            // name: "oppo"
            // price: 3000
            // description: "güzel"

            // ViewBag.Name = "Oppo A5";
            // ViewBag.Price = 3000;
            // ViewBag.Description = "güzel";

            var p = new Product();
            p.Name = "Oppo A5S";
            p.Price = 3000;
            p.Description = "iyi telefon";

            return View(p);
        }
    }
}