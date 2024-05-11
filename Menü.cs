using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class Menü : Form
    {
        bool yetki;
        public Menü(bool yet)
        {
            InitializeComponent();
            yet = yetki;
        }

        private void Menü_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Poliklinikler poliklinikler = new Poliklinikler();
            poliklinikler.FormClosed += (s, args) => this.Show(); // Poliklinikler formu kapatıldığında Menü formunu göster
            this.Hide();
            poliklinikler.Show();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!yetki)
            {
                Kullanıcılar ku = new Kullanıcılar();
                ku.FormClosed += (s, args) => this.Show();
                this.Hide();
                ku.Show();
            }
            else
            {
                MessageBox.Show("Bu işlem için yetkiniz bulunmamaktadır!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Hasta hasta = new Hasta(0);
            hasta.FormClosed += (s, args) => this.Show();

            hasta.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Sevkler sevkler = new Sevkler();
            sevkler.FormClosed += (s, args) => this.Show();

            sevkler.Show();
            this.Hide();
        }
    }
    }

