using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Gorev
    {
        [Key]
        public int gorevId { get; set; }
        public string gorevAd { get; set; }
        public string gorevDetay { get; set; }
        public bool gorevDurum { get; set; }
        public DateTime gorevSonTeslimTarihi { get; set; }
        public Personel per { get; set; }
    }
}
