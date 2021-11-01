using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Controllers
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
            List<User> result = null;
            using (CoffeeContext context = new CoffeeContext())
            {
                result = context.Users.ToList();
            }
            return View(result);            
        }
      
        public IActionResult AddUser(User u, string coffeeCheck)
        {
            if (coffeeCheck == "1")
            {
                u.HadCoffee = true;
            }
            else
            {
                u.HadCoffee = false;
            }
            using (CoffeeContext context = new CoffeeContext())
            {
                context.Users.Add(u);
                context.SaveChanges();
            }
            return Redirect("/");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Result(User One)//replace(string firstName etc, with the class User)
        {
            if(One.passWord.ToLower() == "password")//add user instance to if statement, in this case User One
            {
                return RedirectToAction("Form");
            }
            //ViewData["First Name"] = firstName; remove viewdata when using a class
            //ViewData["Last Name"] = lastName;
            return View(One);//return view of instance of user, One
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
