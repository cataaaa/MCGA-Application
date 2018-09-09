﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCGA.website.Controllers
{

    //[Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var l = 0;
            var x = User.Identity.IsAuthenticated;
            var r = User.IsInRole("admin");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}