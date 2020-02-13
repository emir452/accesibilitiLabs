using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContinumLabs.Controllers
{
    public class HomeController : Controller
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
            ViewBag.Message = " ponete en contacto con nosotros.";

            return View();
        }
        public ActionResult Consult()
        {
            return View();
}
public ActionResult Services()
{
            return View();
}
}
}