using Kutuphane.BL.AccountRepository;
using Kutuphane.ENT.IdentityModel;
using Kutuphane.ENT.ViewModel;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Kutuphane.MVC.Controllers
{
    public class HesapController : Controller
    {
        // GET: Hesap
        public ActionResult Register()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
 
            var kullaniciManager = MemberShipTools.YeniKullaniciManager();
            var checkKullanici = kullaniciManager.FindByName(model.TCNo);

            if (checkKullanici!=null)
            {
                ModelState.AddModelError(string.Empty, "Bu TC No sistemde kayıtlı");
                return View(model);
            }

            checkKullanici = kullaniciManager.FindByEmail(model.Email);
            if (checkKullanici!=null)
            {
                ModelState.AddModelError(string.Empty, "Bu mail adresi sistemde kayıtlı");
                return View(model);
            }

            Kullanici kullanici = new Kullanici()
            {
                Ad=model.Ad,
                Soyad=model.Soyad,
                Email=model.Email,
                UserName=model.TCNo,

               
            };

            var response = kullaniciManager.Create(kullanici, model.Sifre);

            if (response.Succeeded)
            {
                string siteUrl = Request.Url.Scheme + Uri.SchemeDelimiter + Request.Url.Host +
                                 (Request.Url.IsDefaultPort ? "" : ":" + Request.Url.Port);
                if (kullaniciManager.Users.Count() == 1)
                {
                   
                    kullanici.EmailConfirmed = true;

                   

                    kullaniciManager.AddToRole(kullanici.Id, "Admin");
                }
                else
                {
                    kullaniciManager.AddToRole(kullanici.Id, "Passive");
                }
                return RedirectToAction("Login", "Hesap");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Kayıt işleminde bir hata oluiştu");
                return View(model);
            }
        }


        public ActionResult Login()
        {
            return View();
        }

    }
}