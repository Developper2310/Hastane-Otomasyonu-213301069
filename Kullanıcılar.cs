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
using static Hastane_Otomasyonu.Kullanici;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane_Otomasyonu
{
    public partial class Kullanıcılar : Form
    {
        public Kullanıcılar()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(KullaniciRol));
            comboBox2.DataSource = Enum.GetValues(typeof(Cinsiyet));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Kullanıcılar_Load(object sender, EventArgs e)
        {

        }

        public enum Rol
        {
            Admin,
            Doktor,
            Hemsire,
            Sekreter,
            Teknik_Persönel
        }

        public enum Cinsiyet
        {
            Erkek,
            Kadin
        }

        private void KullaniciEkle()
        {

            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string rol = comboBox1.Text;
            string unvan = textBox3.Text;
            decimal maas = Convert.ToDecimal(textBox5.Text);
            string cinsiyet = comboBox2.Text;
            DateTime iseBaslama = dateTimePicker1.Value;
            string telefon = textBox4.Text;
            string sifre = textBox7.Text;
            string kullanıcıAdı = textBox6.Text;

            
            string sorgu = "INSERT INTO Kullanici (KullaniciAdi, Sifre, Ad, Soyad, Rol, Unvan, Maas, Cinsiyet, IseBaslamaTarihi, Telefon) " +
                           "VALUES (@KullaniciAdi, @Sifre, @Ad, @Soyad, @Rol, @Unvan, @Maas, @Cinsiyet, @IseBaslamaTarihi, @Telefon)";

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L6FRADG;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True;"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sorgu, connection))
                    {
                        
                        command.Parameters.AddWithValue("@Ad", ad);
                        command.Parameters.AddWithValue("@Soyad", soyad);
                        command.Parameters.AddWithValue("@Rol", rol);
                        command.Parameters.AddWithValue("@Unvan", unvan);
                        command.Parameters.AddWithValue("@Maas", maas);
                        command.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                        command.Parameters.AddWithValue("@IseBaslamaTarihi", iseBaslama);
                        command.Parameters.AddWithValue("@Telefon", telefon);
                        command.Parameters.AddWithValue("@KullaniciAdi", kullanıcıAdı);
                        command.Parameters.AddWithValue("@Sifre", sifre);

                        
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Yeni kullanıcı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string rol = comboBox1.Text;
            string unvan = textBox3.Text;
            decimal maas = Convert.ToDecimal(textBox5.Text); 
            string cinsiyet = comboBox2.Text;
            DateTime iseBaslama = dateTimePicker1.Value;
            string telefon = textBox4.Text;
            string kullanıcıAdı = textBox6.Text;
            string sifre = textBox7.Text;

            //  kontroller
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(rol) ||
                string.IsNullOrWhiteSpace(unvan) || string.IsNullOrWhiteSpace(cinsiyet) || string.IsNullOrWhiteSpace(telefon) ||
                string.IsNullOrWhiteSpace(sifre)|| string.IsNullOrWhiteSpace(kullanıcıAdı))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal maasi;
            if (!decimal.TryParse(textBox5.Text, out maasi))
            {
                MessageBox.Show("Lütfen geçerli bir maaş miktarı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            KullaniciEkle();

        }
    }
}
