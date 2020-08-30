using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class AccountController : Controller
    {
        Context c = new Context();
        [HttpPost]
        public IActionResult HesapGiris(string email, string personelAdi)
        {

            var user = c.personellers.FirstOrDefault(w => w.mailAdres.Equals(email) && w.personelAd.Equals(personelAdi));
            if (user != null )
            {
                HttpContext.Session.SetString("id",user.mailAdres);
                HttpContext.Session.SetString("fullname", user.personelAd + " " + user.personelSoyad);
                return Redirect("/Home/Index");
            }
            return Redirect("/Account/HesapGiris");
        } 
        [HttpGet]
        public IActionResult HesapGiris()
        {
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/Account/HesapGiris");
        }
    }
}
