using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewProjectImc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Esto es una prueba nueva2.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page 4.";

            return View();
        }
    }
}