using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.Filter;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    [UserFilter]
    public class ProfilController : Controller
    {
        Context c = new Context();
        public IActionResult ProfilGoruntule()
        {
            return View();
        }
    }
}
