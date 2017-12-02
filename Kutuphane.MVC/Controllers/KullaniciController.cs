using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kutuphane.MVC.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        public ActionResult Liste()
        {
            return View();
        }

        public ActionResult Detay()
        {
            return View();
        }

        public ActionResult Ekle()
        {
            //adminse ekleyebilir.
            return View();
        }

        public ActionResult Sil()
        {
            //adminse silebilir.
            return RedirectToAction("Listele");
        }

        public ActionResult Guncelle()
        {
            //adminse güncelleyebilir
            return View();
        }
    }
}