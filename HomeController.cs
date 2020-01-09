using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PredIspit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Pocetna()
        {
            return View();
        }

        public ActionResult Planine()
        {
            ViewBag.Message = "Pogledajte najlepse od onoga cime Srbija raspolaze";

            return View();
        }

        public ActionResult Kontakt()
        {
            ViewBag.Message = "Уколико имате питање или замерку можете нас контактирати";

            return View();
        }
    }
}