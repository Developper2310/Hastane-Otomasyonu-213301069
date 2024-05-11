using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class Poliklinik_Düzenle : Form
    {

        private bool YeniMi = true;
        Poliklinik poliklinik;
        public Poliklinik_Düzenle(Poliklinik poli)
        {
            InitializeComponent();
            if (poli != null)
            {
                poliklinik = poli;
                YeniMi = false;
                DegerleriAta();
            }
        }

        private void Poliklinik_Düzenle_Load(object sender, EventArgs e)
        {

        }

        public void DegerleriAta()
        {
            Adı.Text = poliklinik.PoliklinikAdi;
            Konumu.Text = poliklinik.Konumu;
            if (poliklinik.Durumu) { Aktif.Checked = true; Pasif.Checked = false; }
            else Pasif.Checked = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Formdaki bilgileri al
            string adi = Adı.Text;
            string konumu = Konumu.Text;
            bool durumu = Aktif.Checked;

            // Boşluk kontrolü yap
            if (string.IsNullOrEmpty(Konumu.Text) || string.IsNullOrEmpty(Adı.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.");
                return;
            }

            // Yeni mi güncelleme mi kontrolü yap
            if (YeniMi)
            {
                
                // Yeni kayıt oluştur
                Poliklinik yeniPoliklinik=new Poliklinik( adi,durumu,konumu);

                // Veritabanına ekle
                VeritabanınaEkle(yeniPoliklinik);
            }
            else
            {
          
                VeritabanınıGuncelle(poliklinik);
            }

            // Değişiklikleri kaydettikten sonra formu kapat
            this.Close();
        }

        private void VeritabanınaEkle(Poliklinik yeniPoliklinik)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L6FRADG;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("INSERT INTO Poliklinik (PoliklinikAdi, Konum, Durum) VALUES (@Adi, @Konumu, @Durumu)", connection))
                    {
                        command.Parameters.AddWithValue("@Adi", yeniPoliklinik.PoliklinikAdi);
                        command.Parameters.AddWithValue("@Konumu", yeniPoliklinik.Konumu);
                        command.Parameters.AddWithValue("@Durumu", yeniPoliklinik.Durumu);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Yeni poliklinik başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void VeritabanınıGuncelle(Poliklinik guncellenecekPoliklinik)
        {
            bool durumu = Aktif.Checked ?false: true;

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L6FRADG;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE Poliklinik SET PoliklinikAdi = @Adi, Konum = @Konumu, Durum = @Durumu WHERE PoliklinikAdi = @EskiAdi", connection))

                    {
                        command.Parameters.AddWithValue("@Adi", Adı.Text);
                        command.Parameters.AddWithValue("@Konumu", Konumu.Text);
                        command.Parameters.AddWithValue("@Durumu", durumu);
                        command.Parameters.AddWithValue("@EskiAdi", guncellenecekPoliklinik.PoliklinikAdi);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Poliklinik bilgileri başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }


    }
}
