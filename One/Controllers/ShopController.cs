using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using One.Models;

namespace One.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Coffee()
        {
            var CoffeeModel = new Coffee();
            return View(CoffeeModel);
        }
    }
}
