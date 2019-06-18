using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EMarketNovi.Models;

namespace EMarketNovi.Controllers
{
    public class HomeController : Controller
    {
        private static OOADContext database = OOADContext.getInstance();
        public static Osoba trenutnoUlogovan = null;
        public IActionResult Index()
        {
            return View("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Login()
        {
            return View();
        }
    }
}
