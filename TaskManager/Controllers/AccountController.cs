using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
                HttpContext.Session.SetInt32("id",user.personelId);
                HttpContext.Session.SetString("fullname", user.personelAd + " " + user.personelSoyad);
                HttpContext.Session.SetString("email", user.mailAdres);
                HttpContext.Session.SetString("tel", user.telNo);
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
