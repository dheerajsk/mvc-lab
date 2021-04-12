using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel { ID = 1, Name = "Philip", Age = 20 });
            users.Add(new UserModel { ID = 2, Name = "Jon", Age = 21 });
            users.Add(new UserModel { ID = 3, Name = "Kabir", Age = 30 });
            users.Add(new UserModel { ID = 4, Name = "Doe", Age = 50 });
            users.Add(new UserModel { ID = 5, Name = "Ram", Age = 26 });
            users.Add(new UserModel { ID = 6, Name = "Shyam", Age = 29 });

            ViewData["users"] = users;
            return View();
        }

        [Route("")]
        [Route("Form")]
        public ViewResult GetForm()
        {
            return View("Form");
        }

        [ServiceFilter(typeof(ValidationFilter))]
        [HttpPost]
        public IActionResult PostForm(EmployeeModel employee)
        {
            ViewBag.FullName = "Thank you for submitting the form " + employee.FirstName + " " + employee.LastName;
            return View("Form");
        }
    }
}
