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
        public string Gorev { get; set; }
    }
    public enum personelGorev
    {
        Servissef,
        Laboratuvarsef,
        Ambarvedepomemuru,
        Hastakabulmemuru,
        Arsivmemuru,
        Tıbbifotografci


    };
}
