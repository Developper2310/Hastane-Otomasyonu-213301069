using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu
{
    public class IşlemTürleri
    {
        public int IslemId { get; set; }
        public string IslemAdi { get; set; }
        public double BirimFiyat { get; set; }

        public IşlemTürleri(int turId, string turAdi, double birimFiyat)
        {
            IslemId = turId;
            IslemAdi = turAdi;
            BirimFiyat = birimFiyat;
        }
    }
}
