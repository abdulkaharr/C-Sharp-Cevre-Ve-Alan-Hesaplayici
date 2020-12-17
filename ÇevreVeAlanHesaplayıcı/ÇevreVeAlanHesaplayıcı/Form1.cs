using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÇevreVeAlanHesaplayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Kare";
            label2.Visible = true;
            label2.Text = "Kenar :";
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            groupBox1.Visible = true;
            textBox3.Visible = true;  
            button2.Enabled = false;
            btnkarealn.Visible = true;
            btnkarecevre.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Dikdörtgen";
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            groupBox1.Visible = true;
            textBox4.Visible = true;
            textBox3.Visible = true;
            btndikcevre.Visible = true;
            btndikaln.Visible = true;
            button3.Enabled = false;
        }

        private void btnkarealn_Click(object sender, EventArgs e)
        {
            int kenar = 0, sonuc = 0 ;
            kenar = Convert.ToInt32(textBox3.Text);
            sonuc = kenar * kenar;
            label6.Text = sonuc.ToString();
           
            

        }

        private void btnkarecevre_Click(object sender, EventArgs e)
        {
            int kenar = 0, sonuc = 0;
            kenar = Convert.ToInt32(textBox3.Text);
            sonuc = kenar * 4;
            label7.Text = sonuc.ToString();

        }

        private void btndikaln_Click(object sender, EventArgs e)
        {

            int ukenar=0 , sonuc=0 ,kkenar=0;
            ukenar = Convert.ToInt32(textBox3.Text);
            kkenar = Convert.ToInt32(textBox4.Text);
            sonuc = (ukenar) * (kkenar);
            label6.Text = sonuc.ToString();
            
        }

        private void btndikcevre_Click(object sender, EventArgs e)
        {
     
            int ukenar = Convert.ToInt32(textBox3.Text);
            int kkenar = Convert.ToInt32(textBox4.Text);
            int sonuc = (ukenar + kkenar) * 2;
            label7.Text = sonuc.ToString();
        }
    }
}
