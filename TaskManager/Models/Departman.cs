using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Departman
    {
        [Key]
        public int Id { get; set; }
        public string departmanAd { get; set; }
        public List<Personel> personels{ get; set; }
    }
}
