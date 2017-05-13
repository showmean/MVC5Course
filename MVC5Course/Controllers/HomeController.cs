﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
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
        public ActionResult Test()
        {
            return View();
        }
        public ActionResult Change()
        {
            return View();
        }

        public ActionResult PartialAbout()
        {
            ViewBag.Message = "TEST";
            if (Request.IsAjaxRequest()) return PartialView("About");
            else          return View("About");
           // return View();
        }
        public ActionResult SomeAction()
        {
            return PartialView("SuccessRedirect", "/");
        }
        public ActionResult Unknown()
        {
            return View();
        }
    }
}