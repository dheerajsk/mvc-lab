using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCBasics.Controllers
{
    public class AboutController : Controller
    {
        // GET: AboutController
        public string Index()
        {
            return "This is about controller";
        }

    }
}
