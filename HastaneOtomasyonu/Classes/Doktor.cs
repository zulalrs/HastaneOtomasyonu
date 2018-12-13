using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Classes
{
    public class Doktor:Kisi,IMaasAlabilen
    {
        public decimal Maas { get; set; }
       
        public string Branslar { get; set; }

        public string Unvan { get; set; }

    }
    public enum Unvanlar
    {

    }
}
