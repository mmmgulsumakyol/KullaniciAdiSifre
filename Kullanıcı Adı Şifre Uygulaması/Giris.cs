using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kullanıcı_Adı_Şifre_Uygulaması
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            OrtalamaHesapla ortalamaHesapla=new OrtalamaHesapla();
            ortalamaHesapla.Sinav1 = int.Parse(textBox1.Text);
            ortalamaHesapla.Sinav2 = int.Parse(textBox2.Text);
            listBox3.Items.Add(ortalamaHesapla.OrtHesapla());

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            OrtalamaHesapla ortalamaHesapla = new OrtalamaHesapla();

            if (ortalamaHesapla.OrtHesapla()>= 50)
            {
                listBox4.Items.Add("GEÇTİ");
            }
            else
            {
                listBox4.Items.Add("KALDI");
            }
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);  



        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
