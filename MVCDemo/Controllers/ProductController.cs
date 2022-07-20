using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> plist = new List<Product>() {

                new Product { Id = 101, Name = "Hp laptop", Price = 25000 },
                 new Product { Id = 102, Name = "Dell laptop", Price = 29000 },
                  new Product { Id = 103, Name = "Lenovo laptop", Price = 20000 }

                };
            ViewBag.ProductList = plist;
            return View();
        }
        [HttpGet]   //bydefault
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection form)
        {
            ViewBag.Id = form["pid"];
            ViewBag.Name = form["pname"];
            ViewBag.Price = form["price"];
            return View("ProductDetails");
        }
    }  
}
