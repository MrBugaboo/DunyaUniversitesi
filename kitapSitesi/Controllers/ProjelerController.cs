using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kitapSitesi.Controllers
{
    public class ProjelerController : Controller
    {
        // GET: Projeler
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Projeler()
        {
            ViewBag.Message = "Projeler";

            ViewBag.uyduProjesi = "Uydu \"XT-G56\"";
            ViewBag.uyduMesaj = "XT-G56 ismi verilen uydumuz mühendislik fakültelerimizin işbirliğince uzaya fırlatılmıştır.";

            ViewBag.oyunProjesi = "\"Hukaryu\" Oyunumuz";
            ViewBag.oyunMesaj = "Bilgisayar mühendisliğinde yazılım projesi olarak birinci gelen Hikaryu oyununun geliştirme ekibini kutlarız!";

            ViewBag.roketProjesi = "Roket \"Rakıt\"";
            ViewBag.roketMesaj = "Askeri roket projemiz \"Rakıt\"ın fırlatma ekipmanının yazılım güvenliği test edilme aşamasında...";

            ViewBag.lab1 = "Kimya Laboratuvarı";
            ViewBag.lab2 = "Biyoloji Laboratuvarı";
            ViewBag.lab3 = "Makine Laboratuvatı";
            return View();
        }
    }
}