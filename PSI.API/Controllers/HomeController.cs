﻿using System.Web.Mvc;

namespace PSI.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult API()
        {
            return Redirect("../swagger/ui/index");
        }
    }
}
