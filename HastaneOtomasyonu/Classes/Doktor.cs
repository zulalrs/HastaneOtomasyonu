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

        public override string ToString()
        {
            return $"{this.Unvan} {this.Ad} {this.Soyad}";
        }
    }
    public enum Unvanlar
    {
        PratisyenDoktor,
        UzmanDoktor,
        OperatorDoktor,
        YardımcıDocent,
        Docent,
        Profesor,
        Ordinaryus,
        Pedagog,
        Diyetisyen,
        DisHekimi
    }
}
