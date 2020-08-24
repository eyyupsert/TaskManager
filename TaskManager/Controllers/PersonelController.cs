using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();
        public IActionResult PersonelListele()
        {
            var degerler = c.personellers.Include(x => x.depart).ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<Departman> departmanList = new List<Departman>();
            departmanList = (from x in c.departmanlars select x).ToList();
            departmanList.Insert(0, new Departman { Id = 0, departmanAd = "-- Departman Seç --" });
            ViewBag.departmanDeger = departmanList;
            return View();
        }
        [HttpPost]
        public IActionResult YeniPersonelEkle(Personel person)
        {
            var per = c.departmanlars.Where(x => x.Id == person.depart.Id).FirstOrDefault();
            person.depart = per;
            c.personellers.Add(person);
            c.SaveChanges();
            return RedirectToAction("PersonelListele");
        }
    }
}
