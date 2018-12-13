using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Classes
{
    public class Hasta : Kisi
    {
        public DateTime DogumTarihi {get;set;}
        public string Cinsiyet { get; set; }
    }
    public enum cinsiyet
    {
        Kadin,
        Erkek

    };
}
