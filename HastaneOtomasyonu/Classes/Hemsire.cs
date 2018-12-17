using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Classes
{
    public class Hemsire:Kisi,IMaasAlabilen
    {
        public decimal Maas { get; set; }

        public string Branslar { get; set; }
        public bool atandiMi { get; set; }
    }
}
