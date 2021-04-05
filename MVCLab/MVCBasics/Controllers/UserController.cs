using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public IActionResult PostForm(EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FullName = "Thank you for submitting the form " + employee.FirstName + " " + employee.LastName;
            }
            else
            {
                StringBuilder sb = new StringBuilder("");
                foreach (var value in ModelState.Values)
                {
                    if (value.Errors.Count > 0)
                    {
                        for (int i = 0; i < value.Errors.Count; i++)
                        {
                            sb.Append(value.Errors[i].ErrorMessage + "\n");
                        }
                    }
                }

                ViewBag.Error = sb.ToString();
            }
            return View("Form");
        }
    }
}
