using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamingFest_fatema.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult about()
        {
            return View();
        }

        public ActionResult contact()
        {
            return View();
        }
        public ActionResult index()
        {
            return View();
        }
        public ActionResult services()
        {
            return View();
        }

        public ActionResult login()
        {
            return View();
        }

        public ActionResult signup()
        {
            return View();
        }

        public ActionResult forgotpassword()
        {
            return View();
        }
    }
}