using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace işlem
{
    public partial class Form1 : Form
       
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi1, sayi2;
        int dogruSayisi = 0, yanlisSayisi = 0;

        private void Form1_Load(object sender, EventArgs e)
        {     
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayi1 = rnd.Next(0, 101);
            sayi2 = rnd.Next(0, 101);
            textBox1.Text = sayi1.ToString();
            txtSayi2.Text = sayi2.ToString();
            btnCevap.Enabled = true;
            btnYeni.Enabled = false;
        }

        private void btnCevap_Click(object sender, EventArgs e)
        {
            int verilenCevap = Convert.ToInt32(txtCevap.Text);
            int cevap = sayi1 * sayi2;
            if (verilenCevap == cevap)
            {
                lblBaşla.Text = "Tebrikler...";
                dogruSayisi++;
                SoundPlayer player = new SoundPlayer();
                string path = "C:\\Users\\90544\\Downloads\\alkış.wav";
                player.SoundLocation = path;
                player.Play();  
            }
            else
            {
                lblBaşla.Text = "Cevabınız Hatalı!!!";
                yanlisSayisi++;
                listBox1.Items.Add(sayi1 + "*" + sayi2 + "=" + verilenCevap);
                MessageBox.Show("Doğru Cevap: " + cevap + " olmalı.");
            }
            textBox1.Text = "";
            txtSayi2.Text = "";
            txtCevap.Text = "";
            btnCevap.Enabled = false;
            btnYeni.Enabled = true;
            label5.Text = "Doğru: " + dogruSayisi;
            label4.Text = "Yanlış: " + yanlisSayisi;
        }
    }
}