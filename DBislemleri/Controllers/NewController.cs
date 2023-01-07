using Dbislemleri.AppData;
using Dbislemleri.Helpers;
using Dbislemleri.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Dbislemleri.Controllers
{
    public class NewController : Controller
    {
        private readonly EmailSenders _emailconf;

        public NewController(EmailSenders emailconf)
        {
            _emailconf = emailconf;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Kayit(ContactForm BilgiEkle)
        {
            try
            {
                using (develops_commerceContext db= new develops_commerceContext())
                {
                    db.ContactForms.Add(BilgiEkle);
                    db.SaveChanges();
                    mail();
                    return Json(new { success=true , restext="Eklendi"});    
                }

            }
            catch (System.Exception)
            {

                return Json(new { success=false, restext="Eklenemedi" });
            }

        }
        [HttpPost]
        public JsonResult ModalVeriUpdate(ContactForm ModalUpdate)
        {
            try
            {
                using (develops_commerceContext db = new develops_commerceContext())
                {
                    db.ContactForms.Update(ModalUpdate);
                    db.SaveChanges();
                    return Json(new { success = true, restext = "Güncellendi" });

                }
            }
            catch (System.Exception)
            {
                return Json(new { success = false });
            }

        }
        [HttpPost]
        public JsonResult VeriSil(int Id)
        {
            try
            {
                using (develops_commerceContext db = new develops_commerceContext())
                {
                    ContactForm Silme = db.ContactForms.Where(x => x.Id == Id).FirstOrDefault();
                    db.ContactForms.Remove(Silme);
                    db.SaveChanges();

                    return Json(new { success = true, restext = "Silindi" });
                }
            }
            catch (System.Exception)
            {

                return Json(new { success = false, restext = "Silinemedi" });
            }
        }
        [HttpGet]
        public JsonResult KayitGetir()
        {
            try
            {
                using (develops_commerceContext db = new develops_commerceContext())
                {
                   List<ContactForm> Getir = db.ContactForms.ToList();
                    return Json(new { success = true, kayitList=Getir});
                }

            }
            catch (System.Exception)
            {

                return Json(new { success = false });
            }

        }
        [HttpGet]
        public JsonResult ModalKayitGetir(int Id)
        {
            try
            {
                using (develops_commerceContext db = new develops_commerceContext())
                {
                    ContactForm ModalGetir = db.ContactForms.Where(x=>x.Id==Id).FirstOrDefault();
                    return Json(new { success = true, modalkayitList=ModalGetir });
                }

            }
            catch (System.Exception)
            {

                return Json(new { success = false });
            }

        }
        public bool mail()
        {
            string[] mailler = {
               "emramzn@gmail.com","ahmetakpinar1@outlook.com.tr","emre.aydin@opalfa.com"
            };
            foreach (var item in mailler)
            {
                _emailconf.SendEmailAsync(item , "Kullanıcı Eklendi", "Sistem Çalışıyor");
            }
            
            return true;
        }
    }
}
