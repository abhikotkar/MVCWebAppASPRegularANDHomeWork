using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersnalDetails()
        {
            List<string> option = new List<string>();
            option.Add("Select an Option");
            option.Add("Yes");
            option.Add("No");
            ViewData["option"] = new SelectList(option);
            return View();
        }
        [HttpPost]

        public IActionResult PersnalDetails(IFormCollection form ,ICollection<string> hobbies)
        {
            ViewBag.Name = form["username"];
            ViewBag.Gender = form["gender"];

            ViewBag.Hobbies =hobbies;
            ViewBag.Option = form["option"];
            return View("Details");
        }
    }
}
