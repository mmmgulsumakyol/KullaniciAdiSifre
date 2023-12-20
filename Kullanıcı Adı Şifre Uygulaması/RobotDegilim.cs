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
    public partial class RobotDegilim : Form
    {
        public RobotDegilim()
        {
            InitializeComponent();
        }

        private void RobotDegilim_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox2.Checked==true&&checkBox1.Checked==true&&checkBox5.Checked==true) 
            { 
                Giris girisyap = new Giris();
                girisyap.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("HATALI FOTOĞRAF SEÇTİNİZ!!!!!");
            }
        }
    }
}
