using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // [HttpPost]
        // [Route("Submit")]
        public IActionResult Submit(string firstname, string lastname, int age, string email, string password)
        {
            System.Console.WriteLine("Hitting route");
            User user = new User{
                FirstName = firstname,
                LastName = lastname,
                Age = age,
                Email = email,
                Password = password
            };
            return View("result",user);
        }
    }
}
