using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Classes
{
    class Personel : Kisi, IMaasAlabilen
    {
        public decimal Maas { get; set; }
    }
}
