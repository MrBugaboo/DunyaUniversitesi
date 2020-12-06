using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kitapSitesi.Controllers
{
    public class BolumlerController : Controller
    {
        // GET: Bolumler
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bolumler()
        {
            ViewBag.Message = "Bölümler";
            return View();
        }
    }
}