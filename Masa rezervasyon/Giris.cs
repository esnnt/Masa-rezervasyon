using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Masa_rezervasyon
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //kayıt ol linkinkine tıkladığında, kayıt olma ekranı açılacak
            Kayit kyt = new Kayit();
            kyt.Show();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
