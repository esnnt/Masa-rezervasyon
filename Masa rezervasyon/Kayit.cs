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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
 
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            //bulunduğu sayfayı kapatarak bir önceki sayfaya dönmesini sağlıyor.
            this.Close();
        }
    }
}
