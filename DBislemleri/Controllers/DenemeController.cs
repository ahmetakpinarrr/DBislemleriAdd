using Dbislemleri.AppData;
using Dbislemleri.Helpers;
using Dbislemleri.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Dbislemleri.Controllers
{
    public class DenemeController : Controller
    {
        


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ana()
        {
            return View();
        }
        [HttpPost]
        public JsonResult VeriEkle(ContactForm Kontak)
        {
            try
            {
                using(develops_commerceContext db = new develops_commerceContext())
                {

                    db.ContactForms.Add(Kontak);
                    db.SaveChanges();

                    

                    return Json(new {success=true , restext="Gönderildi"});

                }
            }
            catch (System.Exception)
            {
                return Json(new { success = false });
            }
             
        }
        [HttpPost]
        public JsonResult VeriUpdate(ContactForm KontakUpdate)
        {
            try
            {
                using (develops_commerceContext db = new develops_commerceContext())
                {
                    db.ContactForms.Update(KontakUpdate);
                    db.SaveChanges();
                    return Json(new { success = true, restext = "Güncellendi" });

                }
            }
            catch (System.Exception)
            {
                return Json(new { success = false });
            }

        }
        [HttpGet]
        public JsonResult VeriGetir()
        {
            try
            {
                using(develops_commerceContext db=new develops_commerceContext())
                {
                    List<ContactForm> veriler= db.ContactForms.ToList();
                    return Json(new { success = true , dataList=veriler});
                }
            }
            catch (System.Exception)
            {

                return Json(new { success = false });
            }
        }
        [HttpGet]
        public JsonResult VeriGetirModal(int Id)
        {
            try
            {
                using (develops_commerceContext db = new develops_commerceContext())
                {
                    ContactForm ModalVeri = db.ContactForms.Where(x => x.Id == Id).FirstOrDefault();
                    return Json(new { success = true, modalList = ModalVeri });
                }
            }
            catch (System.Exception)
            {

                return Json(new { success = false });
            }
        }
        [HttpPost]
        public JsonResult VeriSil(int ID)
        {
            try
            {
                using (develops_commerceContext db = new develops_commerceContext())
                {
                   ContactForm Silme  =db.ContactForms.Where(x=>x.Id==ID).FirstOrDefault();
                    db.ContactForms.Remove(Silme);
                    db.SaveChanges();

                    return Json(new { success = true, restext="Silindi"});
                }
            }
            catch (System.Exception)
            {

                return Json(new { success = false , restext = "Silinemedi" });
            }
        }
       
        
    }
}
