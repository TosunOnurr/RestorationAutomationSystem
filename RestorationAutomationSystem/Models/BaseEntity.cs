using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorationAutomationSystem.Models
{
    public abstract class BaseEntity
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public string Aciklama { get; set; }
        public short Adet { get; set; }


        public override string ToString()
        {
            return $"Siparis İcerigi => {Ad},{Fiyat:C2},Aciklama =>{Aciklama}";
        }


    }
}
