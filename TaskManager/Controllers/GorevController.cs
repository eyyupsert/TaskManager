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
        
        [HttpGet]
        public IActionResult GorevGoruntule()
        {
            var gorevDeger = c.gorevs.Include(g => g.per).ToList();
            ViewData["gorevListesi"] = gorevDeger;
            return View();
        }
       
        public IActionResult GorevGuncelle(int id, bool gunceldeger)
        {
            var gorevler = c.gorevs.Find(id);
            if(gunceldeger == false)
            {
                gorevler.gorevDurum = false;
                c.SaveChanges();
                return Redirect("/Gorev/GorevGoruntule");
            }
            if(gunceldeger == true)
            {
                gorevler.gorevDurum = true;
                c.SaveChanges();
                return Redirect("/Gorev/GorevGoruntule");
            }
            return Redirect("/Gorev/GorevGoruntule");
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
