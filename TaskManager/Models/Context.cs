using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-G65DVAG; database=TaskManagerDatabase; integrated security=true;"); 
        }
        public DbSet<Personel> personellers { get; set; }
        public DbSet<Gorev> gorevs { get; set; }
        public DbSet<Departman> departmanlars { get; set; }
    }
}
