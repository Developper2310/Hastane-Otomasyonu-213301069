using System.Data.SqlClient;
using static Hastane_Otomasyonu.Kullanýcýlar;

namespace Hastane_Otomasyonu
{
    public partial class Form1 : Form
    {
        bool yetki = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool KullaniciDogrula(string kullaniciAdi, string sifre)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L6FRADG;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True;"))
                {
                    connection.Open();

                    string sorgu = "SELECT COUNT(*)as VarMý ,Rol FROM Kullanici WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre Group by Rol";

                    using (SqlCommand command = new SqlCommand(sorgu, connection))
                    {
                        command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        command.Parameters.AddWithValue("@Sifre", sifre);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            
                            if (reader.Read())
                            {
                                
                                int kullaniciSayisi = Convert.ToInt32(reader["VarMý"]);
                                if(reader["Rol"].ToString()=="Admin")yetki= true;

                                return kullaniciSayisi > 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message);
                return false;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string girilenKullaniciAdi = textBox1.Text;
            string girilenSifre = textBox2.Text;

            
            if (KullaniciDogrula(girilenKullaniciAdi, girilenSifre))
            {

                Menü menü = new Menü(true);
                menü.FormClosed += (s, args) => Application.Exit();
                menü.Show();
                this.Hide();

            }
            else
            {
              
                MessageBox.Show("Kullanýcý adý veya þifre hatalý. Lütfen tekrar deneyin.");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
