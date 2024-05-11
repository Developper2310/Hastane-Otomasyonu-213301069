namespace Hastane_Otomasyonu
{
    partial class Hasta_İşlemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            HastaAdı = new ColumnHeader();
            Soyadı = new ColumnHeader();
            Cinsiyeti = new ColumnHeader();
            KanGurubu = new ColumnHeader();
            Tc = new ColumnHeader();
            DosyaNo = new ColumnHeader();
            Telefonu = new ColumnHeader();
            DogumYeri = new ColumnHeader();
            DogumTarihi = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { HastaAdı, Soyadı, Cinsiyeti, KanGurubu, Tc, DosyaNo, Telefonu, DogumYeri, DogumTarihi });
            listView1.Location = new Point(12, 115);
            listView1.Name = "listView1";
            listView1.Size = new Size(1089, 443);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // HastaAdı
            // 
            HastaAdı.Text = "HastaAdı";
            HastaAdı.Width = 200;
            // 
            // Soyadı
            // 
            Soyadı.Text = "Soyadı";
            Soyadı.Width = 100;
            // 
            // Cinsiyeti
            // 
            Cinsiyeti.Text = "Cinsiyeti";
            Cinsiyeti.Width = 80;
            // 
            // KanGurubu
            // 
            KanGurubu.Text = "Kan Gurubu";
            KanGurubu.Width = 100;
            // 
            // Tc
            // 
            Tc.Text = "Tc No";
            Tc.Width = 150;
            // 
            // DosyaNo
            // 
            DosyaNo.Text = "Dosya No";
            DosyaNo.Width = 100;
            // 
            // Telefonu
            // 
            Telefonu.Text = "Telefonu";
            Telefonu.Width = 120;
            // 
            // DogumYeri
            // 
            DogumYeri.Text = "DogumYeri";
            DogumYeri.Width = 100;
            // 
            // DogumTarihi
            // 
            DogumTarihi.Text = "Dogum Tarihi";
            DogumTarihi.Width = 100;
            // 
            // Hasta_İşlemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 570);
            Controls.Add(listView1);
            Name = "Hasta_İşlemleri";
            Text = "Hasta_İşlemleri";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader HastaAdı;
        private ColumnHeader Soyadı;
        private ColumnHeader Cinsiyeti;
        private ColumnHeader KanGurubu;
        private ColumnHeader Tc;
        private ColumnHeader DosyaNo;
        private ColumnHeader Telefonu;
        private ColumnHeader DogumYeri;
        private ColumnHeader DogumTarihi;
    }
}