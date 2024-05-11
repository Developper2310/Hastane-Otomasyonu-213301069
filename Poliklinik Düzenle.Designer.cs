namespace Hastane_Otomasyonu
{
    partial class Poliklinik_Düzenle
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
            Adı = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Konumu = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            Pasif = new RadioButton();
            Aktif = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(577, 283);
            button1.Name = "button1";
            button1.Size = new Size(192, 69);
            button1.TabIndex = 0;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Adı
            // 
            Adı.Location = new Point(292, 58);
            Adı.Multiline = true;
            Adı.Name = "Adı";
            Adı.Size = new Size(210, 63);
            Adı.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(45, 58);
            label1.Name = "label1";
            label1.Size = new Size(145, 31);
            label1.TabIndex = 2;
            label1.Text = "Poliklinik Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(45, 153);
            label2.Name = "label2";
            label2.Size = new Size(194, 31);
            label2.TabIndex = 3;
            label2.Text = "Poliklinik Konumu";
            // 
            // Konumu
            // 
            Konumu.Location = new Point(292, 153);
            Konumu.Multiline = true;
            Konumu.Name = "Konumu";
            Konumu.Size = new Size(210, 89);
            Konumu.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(45, 298);
            label3.Name = "label3";
            label3.Size = new Size(193, 31);
            label3.TabIndex = 5;
            label3.Text = "Poliklinik Durumu";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Pasif);
            groupBox1.Controls.Add(Aktif);
            groupBox1.Location = new Point(292, 266);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 92);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Durum";
            // 
            // Pasif
            // 
            Pasif.AutoSize = true;
            Pasif.Checked = true;
            Pasif.Location = new Point(40, 26);
            Pasif.Name = "Pasif";
            Pasif.Size = new Size(60, 24);
            Pasif.TabIndex = 1;
            Pasif.TabStop = true;
            Pasif.Text = "Pasif";
            Pasif.UseVisualStyleBackColor = true;
            // 
            // Aktif
            // 
            Aktif.AutoSize = true;
            Aktif.Location = new Point(40, 56);
            Aktif.Name = "Aktif";
            Aktif.Size = new Size(61, 24);
            Aktif.TabIndex = 0;
            Aktif.TabStop = true;
            Aktif.Text = "Aktif";
            Aktif.UseVisualStyleBackColor = true;
            Aktif.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Poliklinik_Düzenle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 370);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(Konumu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Adı);
            Controls.Add(button1);
            Name = "Poliklinik_Düzenle";
            Text = "Poliklinik_Düzenle";
            Load += Poliklinik_Düzenle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Adı;
        private Label label1;
        private Label label2;
        private TextBox Konumu;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton Pasif;
        private RadioButton Aktif;
    }
}