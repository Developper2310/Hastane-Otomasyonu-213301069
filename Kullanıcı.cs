using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Hastane_Otomasyonu
{
    public class Kullanici//Kullanmayabilirim
    {
        public enum KullaniciRol
        {
            Doktor,
            Hemsire,
            Yonetici
        }

        public enum Cinsiyet
        {
            Erkek,
            Kadin
        }

        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public KullaniciRol Rol { get; set; }
        public string Unvan { get; set; }
        public double Maas { get; set; }
        public string KullaniciKodu { get; set; }
        public Cinsiyet Cinsiyeti { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
        public string Telefon { get; set; }

        public Kullanici(string kullaniciAdi, string sifre, string ad, string soyad, KullaniciRol rol,
                         string unvan, double maas, string kullaniciKodu, Cinsiyet cinsiyet,
                         DateTime iseBaslamaTarihi, string telefon)
        {
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
            Ad = ad;
            Soyad = soyad;
            Rol = rol;
            Unvan = unvan;
            Maas = maas;
            KullaniciKodu = kullaniciKodu;
            Cinsiyeti = cinsiyet;
            IseBaslamaTarihi = iseBaslamaTarihi;
            Telefon = telefon;
        }
    }
}
