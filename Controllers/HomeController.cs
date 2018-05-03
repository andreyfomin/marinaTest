using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using marinaTest.Models;
using System.Dynamic;

namespace marinaTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            // return View();
            dynamic car = new ExpandoObject();
            car.Make = "G35";
            car.Year = 2015;

            return Json(car);
    }


    public IActionResult Marina()
    {
      ViewData["Message"] = "Your contact page.";

      dynamic car = new ExpandoObject();
      car.Make = "Marina";
      car.Year = 2015;

      return Json(car);
    }

    public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
