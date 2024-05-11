using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu
{
    public class Poliklinik
    {


        public string PoliklinikAdi { get; set; }
        public string Konumu { get; set; }
        public bool Durumu { get; set; }


        public Poliklinik(string poliklinikAdi, bool durumu, string konumu)
        {
            PoliklinikAdi = poliklinikAdi;
            Durumu = durumu;
            Konumu = konumu;
        }
    }
    }
