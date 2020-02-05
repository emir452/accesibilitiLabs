using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using accesibilitiLabs.Models.domainEntities;

namespace accesibilitiLabs.Controllers
{
    public class ConsultController : Controller
    {
        private accesibilitiLabsEntities1 db = new accesibilitiLabsEntities1();

        public ActionResult Index()
        {
            return View();
}
[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "idQueri,name,email,queri")] queries queries)
        {
           
            if (ModelState.IsValid)
            {
                db.queries.Add(queries);
                db.SaveChanges();
                return RedirectToAction("ConsultCreated","Consult");

}
            return RedirectToAction("ConsultError", "Consult");
}
        public ActionResult ConsultCreated()
        {
            return View();
        }
        public ActionResult ConsultError()
        {
            return View();
        }
}
}
