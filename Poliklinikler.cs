using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hastane_Otomasyonu
{
    public partial class Poliklinikler : Form
    {
        public Poliklinikler()
        {
            InitializeComponent();
            LoadPoliklinikData();
        }

        private void Poliklinikler_Load(object sender, EventArgs e)
        {
            listView2.FullRowSelect = true;
        }
        private void LoadPoliklinikData()
        {


            // Veritabanı bağlantı dizesi


            string connectionString = "Data Source=DESKTOP-L6FRADG;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True;";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            ;

            // SQL sorgusu
            string query = "SELECT PoliklinikAdi, Konum,Durum FROM Poliklinik";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        // Her bir satırı ListView'e ekleyin
                        ListViewItem item = new ListViewItem(reader["PoliklinikAdi"].ToString());
                        string durum = (reader["Durum"].ToString() == "true") ? "Aktif" : "Pasif";


                        item.SubItems.Add(reader["Konum"].ToString());
                        item.SubItems.Add(durum);
                        listView2.Items.Add(item);
                    }
                }
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Seçili öğe üzerinde işlemleri burada gerçekleştir
                ListViewItem selected = listView1.SelectedItems[0];// Seçili öğe üzerinde işlemleri burada gerçekleştir

                string dosyaNo = selected.SubItems[0].Text;
                string ad = selected.SubItems[1].Text;

            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Poliklinik_Düzenle yk = new Poliklinik_Düzenle(null);
            yk.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {


                bool a = listView2.SelectedItems[0].SubItems[2].Text == "True" ? true : false;

                Poliklinik poliklinik = new Poliklinik(listView2.SelectedItems[0].SubItems[0].Text, a, listView2.SelectedItems[0].SubItems[1].Text);



                Poliklinik_Düzenle dk = new Poliklinik_Düzenle(poliklinik);
                dk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz polikliniği seçin.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Lütfen silinecek kayıt seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                sil();
            }

        }

        public void sil()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-L6FRADG;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True;"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("DELETE FROM Poliklinik WHERE PoliklinikAdi = @EskiAdi", connection))
                    {
                        command.Parameters.AddWithValue("@EskiAdi", listView2.SelectedItems[0].SubItems[0].Text);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Poliklinik bilgileri başarıyla silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

    }
}
