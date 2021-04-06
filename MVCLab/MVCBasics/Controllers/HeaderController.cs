using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCBasics.Controllers
{
    public class HeaderController : Controller
    {
        public PartialViewResult Index()
        {
            ViewBag.Text = "This is a partial header view data coming from server";
            return PartialView("_Header");
        }
    }
}
