using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EMarketNovi.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OrderDetails()
        {
            return View();
        }

        public IActionResult NedovoljnoBodova()
        {
            return View();
        }

        public IActionResult Shopping()
        {
            return View();
        }

        public IActionResult CreditCard()
        {
            return View();
        }
    }
}