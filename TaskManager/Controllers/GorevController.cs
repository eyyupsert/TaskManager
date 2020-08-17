using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class GorevController : Controller
    {
        Context a = new Context();
        public IActionResult GorevGoruntule()
        {
            var gorevDeger = a.gorevs.Include(g => g.per).ToList();
            return View(gorevDeger);
        }
    }
}
