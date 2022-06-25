using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorationAutomationSystem.Models
{
    public class Siparis:BaseEntity
    {
        public AraSicak AraSicak { get; set; }
        public AnaYemek AnaYemek { get; set; }
        public Icecek Icecek { get; set; }
        public Tatli Tatli { get; set; }
        public string MasaNo { get; set; } 







    }
}
