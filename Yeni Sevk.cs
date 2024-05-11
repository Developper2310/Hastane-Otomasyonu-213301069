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
using static Hastane_Otomasyonu.Yeni_Sevk;

namespace Hastane_Otomasyonu
{
    public partial class Yeni_Sevk : Form
    {
        public class Doktors
        {
            public string Adı { get; set; }
            public int Kodu { get; set; }

            public Doktors(string adı, int kodu)
            {
                Adı = adı;
                Kodu = kodu;
            }
        }

        public class Islemler
        {
            public string IslemAdı { get; set; }
            public int Kodu { get; set; }

            public Islemler(string islemad, int kodu)
            {
                IslemAdı = islemad;
                Kodu = kodu;
            }
        }

        public class Hastas
        {
            public string HastalarAd { get; set; }
            public int Kodu { get; set; }

            public Hastas(string hastalarad, int kodu)
            {
                HastalarAd = hastalarad;
                Kodu = kodu;
            }
        }

        public class Poliklinik
        {
            public string PoliklinikAd { get; set; }
            public int Kodu { get; set; }

            public Poliklinik(string poliklinikAd, int kodu)
            {
                PoliklinikAd = poliklinikAd;
                Kodu = kodu;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Yeni_Sevk_Load(object sender, EventArgs e)
        {

        }

        //-------------------------------Listeler
        List<Doktors> doktorListesi = new List<Doktors>();
        List<Islemler> islemListesi = new List<Islemler>();
        List<Hastas> hastaListesi = new List<Hastas>();
        List<Poliklinik> poliklinikListesi = new List<Poliklinik>();

        public Yeni_Sevk()
        {
            InitializeComponent();

            DoktorListesiniGetir();
            IslemListesiniGetir();
            HastaListesiniGetir();
            PoliklinikListesiniGetir();
            ComboBoxlaraListeleriEkle();
        }

        private void ComboBoxlaraListeleriEkle()
        {
            // ComboBox'lara listeleri ekleyerek görüntüleme işlemi yap
            comboBox1.DataSource = doktorListesi;
            comboBox1.DisplayMember = "Adi";  // Burada "Adi" özelliğini göster
            comboBox1.ValueMember = "Kodu";

            comboBox2.DataSource = islemListesi;
            comboBox2.DisplayMember = "IslemAdi";
            comboBox2.ValueMember = "Kodu";

            comboBox3.DataSource = hastaListesi;
            comboBox3.DisplayMember = "Adi";  // Burada "Adi" özelliğini göster
            comboBox3.ValueMember = "Kodu";

            comboBox4.DataSource = poliklinikListesi;
            comboBox4.DisplayMember = "PoliklinikAdi";  // Burada "PoliklinikAdi" özelliğini göster
            comboBox4.ValueMember = "Kodu";
        }


        private void DoktorListesiniGetir()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L6FRADG;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Kullanici", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Doktors doktor = new Doktors(reader["Ad"].ToString(), Convert.ToInt32(reader["KullaniciKodu"]));
                                doktorListesi.Add(doktor);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktor listesi getirilirken hata oluştu: " + ex.Message);
            }
        }

        private void IslemListesiniGetir()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L6FRADG;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM IslemTurleri", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Islemler islem = new Islemler(reader["IslemAdi"].ToString(), Convert.ToInt32(reader["IslemId"]));
                                islemListesi.Add(islem);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem listesi getirilirken hata oluştu: " + ex.Message);
            }
        }

        private void HastaListesiniGetir()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L6FRADG;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Hasta", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Hastas hastan = new Hastas(reader["Ad"].ToString(), Convert.ToInt32(reader["DosyaNo"]));
                                hastaListesi.Add(hastan);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta listesi getirilirken hata oluştu: " + ex.Message);
            }
        }

        private void PoliklinikListesiniGetir()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L6FRADG;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Poliklinik", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Poliklinik poliklinik = new Poliklinik(reader["PoliklinikAdi"].ToString(), Convert.ToInt32(reader["poliklinikID"]));
                                poliklinikListesi.Add(poliklinik);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Poliklinik listesi getirilirken hata oluştu: " + ex.Message);
            }
        }
        private void YeniSevkKaydiOlustur()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L6FRADG;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True;"))
                {
                    connection.Open();

                    // ComboBox'lardan seçilen değerleri al
                    int doktorKodu = (int)comboBox1.SelectedValue;
                    int islemKodu = (int)comboBox2.SelectedValue;
                    int hastaKodu = (int)comboBox3.SelectedValue;
                    int poliklinikKodu = (int)comboBox4.SelectedValue;
                    bool taburcu = false;

                    // Diğer kontrol değerlerini al
                    int islemMiktari = (int)numericUpDown1.Value;
                    DateTime sevkTarihi = dateTimePicker1.Value;

                    // Islemturleri tablosundan birim fiyatı al
                    double birimFiyat = GetBirimFiyat(islemKodu);

                    // Sevk kaydını oluşturmak için SQL sorgusunu hazırla
                    string sorgu = "INSERT INTO Sevk (DrKodu, IslemId, DosyaNo, PoliklinikID, Miktar, SevkTarihi, BirimFiyat, Taburcu) VALUES (@DoktorKodu, @IslemKodu, @HastaKodu, @PoliklinikKodu, @IslemMiktari, @SevkTarihi, @BirimFiyat, @taburcu)";

                    // SqlCommand ve SqlParameter kullanarak sorguyu çalıştır
                    using (SqlCommand command = new SqlCommand(sorgu, connection))
                    {
                        command.Parameters.AddWithValue("@DoktorKodu", doktorKodu);
                        command.Parameters.AddWithValue("@IslemKodu", islemKodu);
                        command.Parameters.AddWithValue("@HastaKodu", hastaKodu);
                        command.Parameters.AddWithValue("@PoliklinikKodu", poliklinikKodu);
                        command.Parameters.AddWithValue("@IslemMiktari", islemMiktari);
                        command.Parameters.AddWithValue("@SevkTarihi", sevkTarihi);
                        command.Parameters.AddWithValue("@BirimFiyat", birimFiyat);
                        command.Parameters.AddWithValue("@taburcu", taburcu);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Yeni sevk kaydı başarıyla oluşturuldu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sevk kaydı oluşturulurken hata oluştu: " + ex.Message);
            }
        }


        private double GetBirimFiyat(int islemId)
        {
            double birimFiyat = 0;

            string sorgu = "SELECT BirimFiyat FROM IslemTurleri WHERE IslemId = @IslemId";

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L6FRADG;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True;"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sorgu, connection))
                {
                    command.Parameters.AddWithValue("@IslemId", islemId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            birimFiyat = reader.GetDouble(0);
                        }
                    }
                }
            }

            return birimFiyat;
        }




        private void button1_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları seçiniz.");
                return;
            }

            
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("İşlem miktarı sıfırdan büyük olmalıdır.");
                return;
            }

           
            if (dateTimePicker1.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Geçerli bir sevk tarihi seçiniz.");
                return;
            }

           
            YeniSevkKaydiOlustur();
        }

    }

}
