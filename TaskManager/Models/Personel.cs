using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Personel
    {
        [Key]
        public int personelId { get; set; }
        public string personelAd { get; set; }
        public string personelSoyad { get; set; }
        public DateTime iseBaslamaTarihi { get; set; }
        public string telNo { get; set; }
        public string mailAdres { get; set; }
        public Departman depart { get; set; }
        public List<Gorev> gorevs { get; set; }
    }
}
