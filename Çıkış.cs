using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Hastane_Otomasyonu
{
    public class Cikis
    {
        public int CikisNo { get; set; }
        public DateTime CikisTarihi { get; set; }
        public DateTime SevkTarihi { get; set; }
        public int DosyaNo { get; set; }
        public double ToplamTutar { get; set; }
        public double OdemeMiktari { get; set; }


        public Cikis(int cikisNo, DateTime cikisTarihi, int dosyaNo, double toplamTutar, DateTime sevkTarihi, double odemeMiktari)
        {
            CikisNo = cikisNo;
            CikisTarihi = cikisTarihi;
            DosyaNo = dosyaNo;
            ToplamTutar = toplamTutar;
            SevkTarihi = sevkTarihi;
            OdemeMiktari = odemeMiktari;
        }
    }
}

