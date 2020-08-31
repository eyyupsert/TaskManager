using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TaskManager.Filter;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    [UserFilter] 
    public class GorevController : Controller
    {
        Context c = new Context();
        

        public IActionResult GorevGoruntule()
        {
            var gorevDeger = c.gorevs.Include(g => g.per).ToList();
            ViewData["gorevListesi"] = gorevDeger;
            return View();
        }
        public IActionResult GorevPlus(Gorev grv)
        {
            var gorevler= c.gorevs.Find(grv.gorevId);
            gorevler.gorevDurum = true;
            c.SaveChanges();
            return RedirectToAction("GorevGoruntule");
        }
     
        public IActionResult GorevNegative(Gorev grv)
        {
            var gorevler = c.gorevs.Find(grv.gorevId);
            gorevler.gorevDurum = false;
            c.SaveChanges();
            return RedirectToAction("GorevGoruntule");
        }

        [HttpGet]
         public IActionResult GorevAta()
        {
            List<Personel> departmanList = new List<Personel>();
            departmanList = (from x in c.personellers select x).ToList();
            departmanList.Insert(0, new Personel { personelId = 0, personelAd = "-- Personel Seç --" });
            ViewBag.personelDeger = departmanList;
            return View();
        }
        [HttpPost]
        public IActionResult GorevAta(Gorev eklenecekGorev)
        {
            var per = c.personellers.Where(x => x.personelId == eklenecekGorev.per.personelId).FirstOrDefault();
            eklenecekGorev.per = per;
            eklenecekGorev.gorevDurum = false;
            c.gorevs.Add(eklenecekGorev);
            c.SaveChanges();

            return RedirectToAction("GorevGoruntule");
        }
    }
}
