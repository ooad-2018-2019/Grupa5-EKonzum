using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EMarketNovi.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View("ChangePassword");
        }

        public IActionResult ChangePassword()
        {
            return View("CorrectAnswer");
        }

        public IActionResult CorrectAnswer()
        {
            return View("Index");
        }
    }
}