using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyRazor.Models;

namespace MyRazor.Controllers
{
    public class HomeController: Controller
    {
        public ViewResult Index()
        {
            Product product = new Product
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "Boat for one person",
                Price = 275M,
                Category = " Water sports"

            };
            ViewBag.StockLevel = 2;
            return View(product);
        }
        public IActionResult Products()
        {
            Product[] products = {
                new Product{ Name = "Kayak", Price = 275M},
                new Product{ Name = "Life Jacket", Price = 48.95M },
                new Product{ Name = "Soccer Ball",  Price = 19.50M},
                new Product{ Name = "Corner Flag", Price = 39.85M}
            };
            return View(products);
        }
    }
}
