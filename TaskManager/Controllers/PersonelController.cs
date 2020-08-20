using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult YeniPersonelEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniPersonelEkle(Personel person)
        {
            c.personellers.Add(person);
            c.SaveChanges();
            return RedirectToAction("YeniPersonelEkle");
        }
    }
}
