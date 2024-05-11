using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu
{
    public class Sevk
    {
        public int SevkNo { get; set; }
        public DateTime SevkTarihi { get; set; }
        public int DosyaNo { get; set; }
        public int Poliklinik { get; set; }
        public string DrKodu { get; set; }
        public int Miktar { get; set; }
        public double BirimFiyat { get; set;}
        public string IslemID {  get; set; }
        public int Sıra { get;set;}
        public bool Taburcu { get; set;}

        public Sevk(int sevkNo, DateTime sevkTarihi, int dosyaNo, int poliklinik, string drKodu, int miktar, double birimFiyat, int sira, string ıslemID)
        {
            SevkNo = sevkNo;
            SevkTarihi = sevkTarihi;
            DosyaNo = dosyaNo;
            Poliklinik = poliklinik;
            DrKodu = drKodu;
            Miktar = miktar;
            BirimFiyat = birimFiyat;
            Sıra = sira;
            Taburcu = false;
            IslemID = ıslemID;
        }

    }
}
