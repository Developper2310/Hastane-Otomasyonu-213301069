namespace Hastane_Otomasyonu
{
    partial class Menü
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
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            button6 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(81, 131);
            button1.Name = "button1";
            button1.Size = new Size(177, 75);
            button1.TabIndex = 0;
            button1.Text = "Poliklinikler";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(487, 301);
            button4.Name = "button4";
            button4.Size = new Size(177, 75);
            button4.TabIndex = 3;
            button4.Text = "Yeni Hasta";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(186, 9);
            label1.Name = "label1";
            label1.Size = new Size(406, 43);
            label1.TabIndex = 4;
            label1.Text = "Umutlu Hastane Otomasyonu\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(316, 62);
            label2.Name = "label2";
            label2.Size = new Size(152, 17);
            label2.TabIndex = 5;
            label2.Text = "İyileştirmek Bizim İşimiz";
            // 
            // button6
            // 
            button6.Location = new Point(81, 301);
            button6.Name = "button6";
            button6.Size = new Size(177, 75);
            button6.TabIndex = 7;
            button6.Text = "Personel Ekle";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(487, 131);
            button2.Name = "button2";
            button2.Size = new Size(177, 75);
            button2.TabIndex = 8;
            button2.Text = "Sevkler";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Menü
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button1);
            Name = "Menü";
            Text = "Menü";
            Load += Menü_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button4;
        private Label label1;
        private Label label2;
        private Button button6;
        private Button button2;
    }
}