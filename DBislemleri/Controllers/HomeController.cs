using Dbislemleri.AppData;
using Dbislemleri.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Dbislemleri.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult DBislemler()
        {
            return View();
        }

        [HttpPost]
        public JsonResult DBislemler(DbIslemleriAhmet newTask)
        {
            try
            {
                using (develops_commerceContext db = new develops_commerceContext())
                {
                    db.DbIslemleriAhmets.Add(newTask);
                    db.SaveChanges();
                    return Json(new { success = true, restext = "Yeni Görev Oluştruldu" });
                }
            }
            catch (Exception error)
            {
                return Json(new { success = false, restext = error.Message });
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
