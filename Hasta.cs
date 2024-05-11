using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane_Otomasyonu
{

    public partial class Hasta : Form
    {
        public int dosyaNo = 0;
        public Hasta(int DosyaNo)   // BU SAYFA HEM HASTA KAYDI AÇMAK HEM DE VAR OLAN HASTA BİLGİLERİNİ DÜZENLEMEK İÇİNDİR
        {
            InitializeComponent();
            dosyaNo = DosyaNo;
            comboBox1.DataSource = Enum.GetValues(typeof(Cinsiyet));

            var kanGrubuValues = Enum.GetValues(typeof(KanGrubu)).Cast<KanGrubu>().ToList();
            comboBox2.DataSource = kanGrubuValues.Select(value => GetEnumDescription(value)).ToList();

        
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Hasta_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Cinsiyet));

            comboBox2.DataSource = Enum.GetValues(typeof(KanGrubu))
                                        .Cast<KanGrubu>()
                                        .Select(value => GetEnumDescription(value))
                                        .ToList();
            if (dosyaNo != 0) DosyaNoIleHastaBilgisiGetir(dosyaNo);
        }

        // Enum Description değerini almak için yardımcı metot
        private string GetEnumDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute == null ? value.ToString() : attribute.Description;
        }

        public enum Cinsiyet
        {
            Erkek,
            Kadın
        }

        public enum KanGrubu
        {
            APositive,
            ANegative,
            BPositive,
            BNegative,
            ABPositive,
            ABNegative,
            OPositive,
            ONegative
        }

        private void DosyaNoIleHastaBilgisiGetir(int dosyaNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L6FRADG;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True;"))
                {
                    connection.Open();

                    string sorgu = "SELECT * FROM Hasta WHERE DosyaNo = @DosyaNo";

                    using (SqlCommand command = new SqlCommand(sorgu, connection))
                    {
                        command.Parameters.AddWithValue("@DosyaNo", dosyaNo);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Veritabanından okunan değerleri ilgili alanlara ata
                                textBox1.Text = reader["Ad"].ToString();
                                textBox2.Text = reader["SoyAd"].ToString();
                                textBox3.Text = reader["BabaAdi"].ToString();
                                textBox4.Text = reader["AnneAdi"].ToString();

                                // Cinsiyeti enuma çevir
                                if (Enum.TryParse(reader["Cinsiyet"].ToString(), out Cinsiyet cinsiyet))
                                {
                                    comboBox1.SelectedItem = cinsiyet;
                                }

                                textBox5.Text = reader["TcKimlikNo"].ToString();
                                textBox6.Text = reader["DogumYeri"].ToString();
                                dateTimePicker1.Value = Convert.ToDateTime(reader["DogumTarihi"]);
                                textBox7.Text = reader["Telefon"].ToString();

                                // Kan grubunu enuma çevir
                                if (Enum.TryParse(reader["KanGrubu"].ToString(), out KanGrubu kanGrubu))
                                {
                                    comboBox2.SelectedItem = kanGrubu;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Hasta bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void HastaEkle()
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string babaAdi = textBox3.Text;
            string anaAdi = textBox4.Text;
            Cinsiyet cinsiyet = (Cinsiyet)comboBox1.SelectedItem;
            string tcNo = textBox5.Text;
            string dogumYeri = textBox6.Text;
            DateTime dogumTarihi = dateTimePicker1.Value;
            string telefon = textBox7.Text;

            // Güncellenen kısımlar buradan başlıyor
            string kanGrubuStr = comboBox2.SelectedItem.ToString();
            if (Enum.TryParse(typeof(KanGrubu), kanGrubuStr, out object kanGrubuObj))
            {
                KanGrubu kanGrubu = (KanGrubu)kanGrubuObj;

                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L6FRADG;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True;"))
                    {
                        connection.Open();

                        string sorgu = "INSERT INTO Hasta ( Ad, Soyad, BabaAdi, AnneAdi, Cinsiyet, TcKimlikNo, DogumYeri, DogumTarihi, Telefon, KanGrubu) " +
                                       "VALUES ( @Ad, @Soyad, @BabaAdi, @AnaAdi, @Cinsiyet, @TcNo, @DogumYeri, @DogumTarihi, @Telefon, @KanGrubu)";

                        using (SqlCommand command = new SqlCommand(sorgu, connection))
                        {
                            command.Parameters.AddWithValue("@DosyaNo", dosyaNo);
                            command.Parameters.AddWithValue("@Ad", ad);
                            command.Parameters.AddWithValue("@Soyad", soyad);
                            command.Parameters.AddWithValue("@BabaAdi", babaAdi);
                            command.Parameters.AddWithValue("@AnaAdi", anaAdi);
                            command.Parameters.AddWithValue("@Cinsiyet", cinsiyet.ToString());
                            command.Parameters.AddWithValue("@TcNo", tcNo);
                            command.Parameters.AddWithValue("@DogumYeri", dogumYeri);
                            command.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
                            command.Parameters.AddWithValue("@Telefon", telefon);
                            command.Parameters.AddWithValue("@KanGrubu", kanGrubu.ToString());

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Yeni hasta kaydı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hasta kaydı eklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kan grubu enum'a dönüştürülürken hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void HastaGuncelle()
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string babaAdi = textBox3.Text;
            string anaAdi = textBox4.Text;
            Cinsiyet cinsiyet = (Cinsiyet)comboBox1.SelectedItem;
            string tcNo = textBox5.Text;
            string dogumYeri = textBox6.Text;
            DateTime dogumTarihi = dateTimePicker1.Value;
            string telefon = textBox7.Text;

            // Güncellenen kısımlar buradan başlıyor
            string kanGrubuStr = comboBox2.SelectedItem.ToString();
            if (Enum.TryParse(typeof(KanGrubu), kanGrubuStr, out object kanGrubuObj))
            {
                KanGrubu kanGrubu = (KanGrubu)kanGrubuObj;

                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L6FRADG;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True;"))
                    {
                        connection.Open();

                        string sorgu = "UPDATE Hasta SET Ad = @Ad, Soyad = @Soyad, BabaAdi = @BabaAdi, AnneAdi=@AnaAdi, Cinsiyet = @Cinsiyet, " +
                                       "TcKimlikNo = @TcNo, DogumYeri = @DogumYeri, DogumTarihi = @DogumTarihi, Telefon = @Telefon, KanGrubu = @KanGrubu " +
                                       "WHERE DosyaNo = @DosyaNo";

                        using (SqlCommand command = new SqlCommand(sorgu, connection))
                        {
                            command.Parameters.AddWithValue("@DosyaNo", dosyaNo);
                            command.Parameters.AddWithValue("@Ad", ad);
                            command.Parameters.AddWithValue("@Soyad", soyad);
                            command.Parameters.AddWithValue("@BabaAdi", babaAdi);
                            command.Parameters.AddWithValue("@AnaAdi", anaAdi);
                            command.Parameters.AddWithValue("@Cinsiyet", cinsiyet.ToString());
                            command.Parameters.AddWithValue("@TcNo", tcNo);
                            command.Parameters.AddWithValue("@DogumYeri", dogumYeri);
                            command.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
                            command.Parameters.AddWithValue("@Telefon", telefon);
                            command.Parameters.AddWithValue("@KanGrubu", kanGrubu.ToString());

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Hasta kaydı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hasta kaydı güncellenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kan grubu enum'a dönüştürülürken hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
       string.IsNullOrWhiteSpace(textBox2.Text) ||
       string.IsNullOrWhiteSpace(textBox3.Text) ||
       string.IsNullOrWhiteSpace(textBox4.Text) ||
       comboBox1.SelectedItem == null ||
       string.IsNullOrWhiteSpace(textBox5.Text) ||
       string.IsNullOrWhiteSpace(textBox6.Text) ||
       dateTimePicker1.Value == null ||
       string.IsNullOrWhiteSpace(textBox7.Text) ||
       comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Eğer bir eksik alan varsa işlemi durdur
            }
            if (dosyaNo == 0)
            {
                HastaEkle();
            }
            else
            {
                HastaGuncelle();
            }
            this.Close();
        }
    }
}
