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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "gulsiuum" && textBox2.Text == "1905")
            {
                RobotDegilim robotDegilim = new RobotDegilim();
                robotDegilim.Show();
                this.Hide();

            }
            else if (textBox1.Text == "gulsiuum" && textBox2.Text != "1905")
            {
                MessageBox.Show("ŞİFRE YANLIŞ!!!! TEKRAR KONTROL EDİNİZ");
                textBox2.Text = null;
            }
            else if(textBox1.Text != "gulsiuum" && textBox2.Text == "1905")
            {
                MessageBox.Show("KULLANICI ADI YANLIŞ!!!!! TEKRAR KONTROL EDİNİZ");
                textBox1.Text = null;
            }
            else
            {
                MessageBox.Show("KULLANICI ADI VE ŞİFRENİZ YANLIŞ!!!LÜTFEN TEKRAR GİRİNİZ");
                textBox2.Text= null;
                textBox1 = null;
            }
            
            }
    }
}
