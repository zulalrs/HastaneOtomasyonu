using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Classes
{
    public class Randevu
    {
        public Doktor Doktor { get; set; }
        public Hasta Hasta { get; set; }
        public Poliklinikler poliklinikler { get; set; }

        public string  Saat { get; set; }


    }
}
