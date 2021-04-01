using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace MVCBasics.Controllers
{
    public class AboutController : Controller
    {
        // GET: AboutController
        public string Index()
        {
            return "This is about controller";
        }

        public JsonResult Content()
        {
            string data = System.IO.File.ReadAllText(@"./wwwroot/content.json");
            JObject json = JObject.Parse(data);
            return Json(json);
        }

    }
}
