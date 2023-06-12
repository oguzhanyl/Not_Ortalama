using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Pratik_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int numara, vize, final, proje;
            double ortalama;
            numara = Convert.ToInt32(textBox1.Text);
            ad = textBox2.Text;
            soyad= textBox3.Text;
            vize = Convert.ToInt32(textBox4.Text);
            final = Convert.ToInt32(textBox5.Text);
            proje = Convert.ToInt32(textBox6.Text);
            ortalama = ((vize * 40 / 100) + (final * 60 / 100) + proje) /3;
            listBox1.Items.Add(numara + " " + ad + "" + soyad + "Ortalama:" + ortalama);
        }

    }
}
