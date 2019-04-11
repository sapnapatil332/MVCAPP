using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAPP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string s = "Ranjeet Singh";
            string s1 = "Sapna Patil";
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