namespace Hastane_Otomasyonu
{
    partial class Sevkler
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
            button1 = new Button();
            Bitis = new DateTimePicker();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            Tarih = new RadioButton();
            Baslangic = new DateTimePicker();
            AraT = new TextBox();
            AraBut = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            Ara = new RadioButton();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            groupBox3 = new GroupBox();
            Hepsi = new RadioButton();
            Taburcu = new RadioButton();
            Aktif = new RadioButton();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1219, 361);
            button1.Name = "button1";
            button1.Size = new Size(171, 73);
            button1.TabIndex = 1;
            button1.Text = "Kaydı Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Bitis
            // 
            Bitis.Location = new Point(19, 128);
            Bitis.Name = "Bitis";
            Bitis.Size = new Size(214, 27);
            Bitis.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Tarih);
            groupBox1.Controls.Add(Baslangic);
            groupBox1.Controls.Add(Bitis);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 188);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tarih Arama Yardımı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 105);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 6;
            label3.Text = "Bitiş";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 52);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "Başlangıç";
            // 
            // Tarih
            // 
            Tarih.AutoSize = true;
            Tarih.Location = new Point(19, 26);
            Tarih.Name = "Tarih";
            Tarih.Size = new Size(132, 24);
            Tarih.TabIndex = 4;
            Tarih.Text = "Tarihe Göre Ara";
            Tarih.UseVisualStyleBackColor = true;
            // 
            // Baslangic
            // 
            Baslangic.Location = new Point(19, 75);
            Baslangic.Name = "Baslangic";
            Baslangic.Size = new Size(214, 27);
            Baslangic.TabIndex = 3;
            // 
            // AraT
            // 
            AraT.Location = new Point(24, 114);
            AraT.Name = "AraT";
            AraT.Size = new Size(220, 27);
            AraT.TabIndex = 5;
            // 
            // AraBut
            // 
            AraBut.Location = new Point(1006, 80);
            AraBut.Name = "AraBut";
            AraBut.Size = new Size(171, 73);
            AraBut.TabIndex = 6;
            AraBut.Text = "Ara";
            AraBut.UseVisualStyleBackColor = true;
            AraBut.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 80);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 7;
            label1.Text = "Ad ve Soyad arayın";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Ara);
            groupBox2.Controls.Add(AraT);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(365, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 188);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Arama Yardımı";
            // 
            // Ara
            // 
            Ara.AutoSize = true;
            Ara.Location = new Point(24, 31);
            Ara.Name = "Ara";
            Ara.Size = new Size(145, 24);
            Ara.TabIndex = 8;
            Ara.TabStop = true;
            Ara.Text = "Aramaya Dahil Et";
            Ara.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            listView1.Location = new Point(12, 206);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(1165, 468);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Dosya No";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adı";
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyadı";
            columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Sevk Tarihi";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Poliklinik";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Doktor";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Taburcu";
            columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Poliklinik";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Birim Üret";
            columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "İşlem Adedi";
            columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Toplam Tutar";
            columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "SevkNo";
            columnHeader12.Width = 80;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Hepsi);
            groupBox3.Controls.Add(Taburcu);
            groupBox3.Controls.Add(Aktif);
            groupBox3.Location = new Point(707, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(272, 188);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hasta Durumu";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // Hepsi
            // 
            Hepsi.AutoSize = true;
            Hepsi.Checked = true;
            Hepsi.Location = new Point(31, 117);
            Hepsi.Name = "Hepsi";
            Hepsi.Size = new Size(68, 24);
            Hepsi.TabIndex = 2;
            Hepsi.TabStop = true;
            Hepsi.Text = "Hepsi";
            Hepsi.UseVisualStyleBackColor = true;
            Hepsi.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // Taburcu
            // 
            Taburcu.AutoSize = true;
            Taburcu.Location = new Point(31, 78);
            Taburcu.Name = "Taburcu";
            Taburcu.Size = new Size(127, 24);
            Taburcu.TabIndex = 1;
            Taburcu.Text = "Taburcu Olmuş";
            Taburcu.UseVisualStyleBackColor = true;
            // 
            // Aktif
            // 
            Aktif.AutoSize = true;
            Aktif.Location = new Point(31, 39);
            Aktif.Name = "Aktif";
            Aktif.Size = new Size(61, 24);
            Aktif.TabIndex = 0;
            Aktif.Text = "Aktif";
            Aktif.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1219, 19);
            button3.Name = "button3";
            button3.Size = new Size(171, 73);
            button3.TabIndex = 11;
            button3.Text = "Sıfırla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1219, 244);
            button4.Name = "button4";
            button4.Size = new Size(171, 73);
            button4.TabIndex = 12;
            button4.Text = "Taburcu Et";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1219, 601);
            button5.Name = "button5";
            button5.Size = new Size(171, 73);
            button5.TabIndex = 13;
            button5.Text = "Yazdır";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1219, 481);
            button6.Name = "button6";
            button6.Size = new Size(171, 73);
            button6.TabIndex = 14;
            button6.Text = "Yeni Sevk";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1219, 126);
            button7.Name = "button7";
            button7.Size = new Size(171, 73);
            button7.TabIndex = 15;
            button7.Text = "Hastayı Düzenle";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Sevkler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 690);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox3);
            Controls.Add(AraBut);
            Controls.Add(listView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Sevkler";
            Text = "Sevkler ";
            Load += Sevkler_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ColumnHeader DosyaNo;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox2;
        private Button button2;
        private Label label1;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private GroupBox groupBox3;
        private RadioButton radioButton2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Button button3;
        private Label label3;
        private Label label2;
        private RadioButton radioButton5;
        private RadioButton Tarih;
        private RadioButton Ara;
        private RadioButton Hepsi;
        private RadioButton Taburcu;
        private RadioButton Aktif;
        private TextBox AraT;
        private DateTimePicker Bitis;
        private DateTimePicker Baslangic;
        private Button AraBut;
        private Button button4;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button button5;
        private ColumnHeader columnHeader12;
        private Button button6;
        private Button button7;
    }
}