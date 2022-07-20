using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult AcceptFood()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AcceptFood(IFormCollection form, ICollection<string> south, ICollection<string> north)
        {
            ViewBag.Name = form["name"];
            ViewBag.Mobile = form["mobile"];

            ViewBag.South = south;
            ViewBag.North = north;
           
            return View("FoodDetails");
        }
    }
}
