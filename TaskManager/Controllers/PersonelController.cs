using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskManager.Filter;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    [UserFilter]
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
        public IActionResult YeniPersonel(Personel person)
        {
            var per = c.departmanlars.Where(x => x.Id == person.depart.Id).FirstOrDefault();
            person.depart = per;
            c.personellers.Add(person);
            c.SaveChanges();
            return RedirectToAction("PersonelListele");
        }
        public IActionResult PersonelSil(int Id)
        {
            var silinecekPersonel = c.personellers.Find(Id);
            c.personellers.Remove(silinecekPersonel);
            c.SaveChanges();
            return RedirectToAction("PersonelListele");
        }
        [HttpGet]
        public IActionResult PersonelGuncelle(int id)
        {
            List<Departman> departmanList = new List<Departman>();
            departmanList = (from x in c.departmanlars select x).ToList();
            departmanList.Insert(0, new Departman { Id = 0, departmanAd = "-- Departman Seç --" });
            ViewBag.departmanDeger = departmanList;
            var GPersonel = c.personellers.Find(id);
            return View("PersonelGuncelle", GPersonel);
        }
        [HttpPost]
        public IActionResult PersonelGuncelle(Personel Vperson)
        {
            var Gpersonel = c.personellers.Find(Vperson.personelId);
            var per = c.departmanlars.Where(x => x.Id == Vperson.depart.Id).FirstOrDefault();
            Gpersonel.depart = per;
            Gpersonel.personelAd = Vperson.personelAd;
            Gpersonel.personelSoyad = Vperson.personelSoyad;
            Gpersonel.iseBaslamaTarihi = Vperson.iseBaslamaTarihi;
            Gpersonel.telNo = Vperson.telNo;
            Gpersonel.mailAdres = Vperson.mailAdres;
           
            c.SaveChanges();
            return RedirectToAction("PersonelListele");
        }
    }
}
