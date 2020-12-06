using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kitapSitesi.Controllers
{
    public class tabanController : Controller
    {
        // GET: taban
        public ActionResult puanlariGetir()
        {
            return View(Models.tabanPuanlari.puanlar);
        }
    }
}