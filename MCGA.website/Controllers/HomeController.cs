﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Constants.HomeController;

namespace MCGA.website.Controllers
{

    //[Authorize]
    public class HomeController : Controller
    {
        [Route("", Name = HomeControllerRoute.GetIndex)]
        public ActionResult Index()
        {
          
            var x = User.Identity.IsAuthenticated;
            var r = User.IsInRole("admin");
            // return View();
            return this.View(HomeControllerAction.Index);
        }
        [Route("About", Name = HomeControllerRoute.GetAbout)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Route("Contact", Name = HomeControllerRoute.GetContact)]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}