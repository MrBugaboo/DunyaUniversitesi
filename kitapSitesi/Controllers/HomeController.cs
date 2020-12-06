using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kitapSitesi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hakkinda()
        {
            ViewBag.Message = "Dünya Üniversitesi Hakkında";

            return View();
        }

        public ActionResult Iletisim()
        {
            ViewBag.Message = "Dünya Üniversitesi İletişim Bilgileri";

            return View();
        }
    }
}