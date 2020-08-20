using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class DepartmanController : Controller
    {
        
       Context c = new Context();
        public IActionResult DepartmanListele()
        {
            var derpartmanListe = c.departmanlars.ToList();
            return View(derpartmanListe);
        }
        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniDepartman(Departman depart)
        {
            c.departmanlars.Add(depart);
            c.SaveChanges();
            return RedirectToAction("departmanListele");
         
        }
        public IActionResult DepartmanSil(int Id)
        {
            var silinecekDepart = c.departmanlars.Find(Id);
            c.departmanlars.Remove(silinecekDepart);
            c.SaveChanges();
            return RedirectToAction("departmanListele");
        }
    }
}
