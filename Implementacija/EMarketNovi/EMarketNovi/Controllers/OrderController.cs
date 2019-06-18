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
            return View("Index");
        }

        public IActionResult OrderDetails()
        {
            return View("OrderDetails");
        }

        public IActionResult NedovoljnoBodova()
        {
            return View("NedovoljnoBodova");
        }

        public IActionResult Shopping()
        {
            return View("Shopping");
        }

        public IActionResult CreditCard()
        {
            return View("CreditCard");
        }
    }
}