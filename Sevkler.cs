using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Hastane_Otomasyonu
{

    public partial class Sevkler : Form
    {
        public string connectionString = "Data Source=DESKTOP-L6FRADG;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True;";

        string query1 = "SELECT a.*,b.Ad,b.SoyAd, c.Ad as Doktor," +
            " d.PoliklinikAdi as Poliklinik FROM Sevk a join Hasta b on a.DosyaNo= b.DosyaNo join Kullanici c on a.DrKodu=c.KullaniciKodu join Poliklinik d on a.PoliklinikID=d.poliklinikID";
        public Sevkler()
        {
            InitializeComponent();
            Yukleme();
        }
        public void Yukleme()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT a.*,b.Ad,b.SoyAd, c.Ad as Doktor, d.PoliklinikAdi as Poliklinik FROM Sevk a join Hasta b on a.DosyaNo= b.DosyaNo join Kullanici c on a.DrKodu=c.KullaniciKodu join Poliklinik d on a.PoliklinikID=d.poliklinikID";
                    string taburcuDurumu = "";
                    string l = "";
                    string like = " WHERE b.Ad LIKE '%' AND b.Soyad LIKE '%'";
                    string date = " AND a.SevkTarihi BETWEEN '1000-01-01' AND '3000-01-01'";

                    if (Ara.Checked) l = AraT.Text;
                    like = $" AND (b.Ad LIKE '%{l}%' OR b.Soyad LIKE '%{l}%')";

                    if (Tarih.Checked)
                    {
                        date = " AND a.SevkTarihi BETWEEN @Baslangic AND @Bitis";
                    }
                    if (Taburcu.Checked)
                    {
                        taburcuDurumu = " And a.Taburcu = 1";
                    }
                    else if (Aktif.Checked)
                    {
                        taburcuDurumu = " And a.Taburcu = 0";
                    }

                    ListeyiTemizle();

                    using (SqlCommand command = new SqlCommand(query + like + date + taburcuDurumu, connection))
                    {
                        if (Tarih.Checked)
                        {
                            DateTime baslangic = Baslangic.Value;
                            DateTime bitis = Bitis.Value;
                            command.Parameters.AddWithValue("@Baslangic", baslangic);
                            command.Parameters.AddWithValue("@Bitis", bitis);
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                double a, b, c;




                                if (double.TryParse(reader["Miktar"].ToString(), out a) && (double.TryParse(reader["BirimFiyat"].ToString(), out b))) c = a * b;
                                else c = b = a = 0;
                                ListViewItem item = new ListViewItem(reader["DosyaNo"].ToString());
                                item.SubItems.Add(reader["Ad"].ToString());
                                item.SubItems.Add(reader["Soyad"].ToString());
                                item.SubItems.Add(reader["SevkTarihi"].ToString());
                                item.SubItems.Add(reader["PoliklinikID"].ToString());
                                item.SubItems.Add(reader["Doktor"].ToString());
                                item.SubItems.Add(reader["Taburcu"].ToString());
                                item.SubItems.Add(reader["Poliklinik"].ToString());
                                item.SubItems.Add(b.ToString());
                                item.SubItems.Add(a.ToString());
                                item.SubItems.Add(c.ToString());
                                item.SubItems.Add(reader["SevkNo"].ToString());
                                listView1.Items.Add(item);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Hatası Oluştu: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Geçersiz İşlem Hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen Hata Oluştu: " + ex.Message);
            }
        }



        public void ListeyiTemizle()
        {
            listView1.Items.Clear();
        }





        private void Sevkler_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        //------------------Arama
        private void button2_Click(object sender, EventArgs e)
        {
            Yukleme();
        }

        //_--------------temizle
        private void button3_Click(object sender, EventArgs e)
        {
            Hepsi.Checked = true;
            Ara.Checked = false;
            Tarih.Checked = false;
            Bitis.Value = DateTime.Now;
            Baslangic.Value = DateTime.Now;
            AraT.Text = "";
        }
        //-----------------taburcu
        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var result = MessageBox.Show("Hastayı Taburcu etmek  istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    TaburcuEt(int.Parse(listView1.SelectedItems[0].SubItems[11].Text));
                else return;
            }
            else
            {
                MessageBox.Show("Önce Bir Kayıt Seçin");
                return;
            }
        }

        public void TaburcuEt(int SevkNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE Sevk SET Taburcu = 1 WHERE SevkNo = @SevkID", connection))
                    {
                        command.Parameters.AddWithValue("@SevkID", SevkNo);
                        command.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Hasta taburcu edildi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
            listView1.Items.Clear();
            Yukleme();
        }

        public void KaydıSil(int SevkNo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("Delete from Sevk WHERE SevkNo = @SevkID", connection))
                    {
                        command.Parameters.AddWithValue("@SevkID", SevkNo);
                        command.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Sevk Kaydı Silindi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }
            listView1.Items.Clear();
            Yukleme();
        }
        //----------------------sil
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var result = MessageBox.Show("Sevk kaydını silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    KaydıSil(int.Parse(listView1.SelectedItems[0].SubItems[11].Text));
                else return;
            }
            else
            {
                MessageBox.Show("Önce Bir Kayıt Seçin");
                return;
            }
        }
        //--------------yeni sevk kayıt
        private void button6_Click(object sender, EventArgs e)
        {
            Yeni_Sevk yeni_Sevk = new Yeni_Sevk();
            yeni_Sevk.ShowDialog();
        }
        //---------------yazdırma işlemi burda
        private void button5_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF Dosyaları (*.pdf)|*.pdf";
            saveFileDialog1.Title = "Kaydet";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = "Sevk Raporu";

                    PdfPage pdfPage = pdf.AddPage();
                    XGraphics graph = XGraphics.FromPdfPage(pdfPage);

                    XFont font = new XFont("Arial", 11);

                    int yPosition = 50;
                    foreach (ListViewItem item in listView1.Items)
                    {
                        string line = "";
                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                        {
                            line += subItem.Text + "\t";
                        }
                        graph.DrawString(line, font, XBrushes.Black, new XRect(40, yPosition, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                        yPosition += 20;
                    }

                    pdf.Save(saveFileDialog1.FileName);
                    MessageBox.Show("Veriler başarıyla PDF'ye kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        //Hastayı Düzenle
        private void button7_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Hasta hasta = new Hasta(int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                hasta.FormClosed += (s, args) => this.Show();
                this.Hide();
                hasta.Show();
            }
            else
            {
                MessageBox.Show("Önce kayıt seçin !!");
            }
        }
    }
}

