﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masa_rezervasyon
{
    public partial class odeme : Form
    {
        public odeme(string masaNumarasi)
        {
            InitializeComponent();
        }

        private void odeme_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
           yonetici yonetici = new yonetici();
            yonetici.MenuItemleriniGetir(yiyecek_list,icecek_list);
        }
    }
}
