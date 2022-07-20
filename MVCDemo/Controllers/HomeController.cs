using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
           
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["msg"] = "This is my mvc application";

            string[] names = { "Tushar", "Ravi", "Ram", "Sham" };
            ViewData["nameslist"] = names;

            List<Employee> emplist = new List<Employee>() {

                new Employee { Id = 101, Name = "Ajay", Department = "HR", Salary = 25000 },
                new Employee { Id = 102, Name = "Amit", Department = "Mentanance", Salary = 55000 },
                new Employee { Id = 103, Name = "Rahul", Department = "Developer", Salary = 85000 },
                new Employee { Id = 104, Name = "Samir", Department = "HR", Salary = 26000 }

                };
            ViewData["emplist"]=emplist;

            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Privacy()
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
