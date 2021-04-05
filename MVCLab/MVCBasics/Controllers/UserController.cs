using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel { ID = 1, Name = "Philip" });
            users.Add(new UserModel { ID = 2, Name = "Jon" });
            users.Add(new UserModel { ID = 3, Name = "Kabir" });

            ViewData["users"] = users;
            return View();
        }

        public ViewResult GetForm()
        {
            return View("Form");
        }

        [HttpPost]
        public IActionResult PostForm(string FirstName, string LastName)
        {
            ViewBag.FullName = "Thank you for submitting the form " + FirstName + " " + LastName;
            return View("Form");
        }
    }
}
