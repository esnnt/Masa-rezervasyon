using System;
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
    public partial class MusteriRez : Form
    {
        public MusteriRez()
        {
            InitializeComponent();
        }
        // Tüm masa butonları için kullanılacak click eventi
        private void btnMasa_Click(object sender, EventArgs e)
        {
            // Tıklanan butonu yakala
            Button masaButonu = sender as Button;

            if (masaButonu != null)
            {
                // Butonun üzerindeki masa numarasını al (örneğin: 5)
                string masaNumarasi = masaButonu.Text;

                // Ödeme formunu masa numarasıyla aç
                odeme odemeFormu = new odeme(masaNumarasi);
                odemeFormu.ShowDialog();  // Yeni sayfayı göster
            }
        }


        private void MusteriRez_Load(object sender, EventArgs e)
        {
            foreach (Control kontrol in this.Controls)
            {
                if (kontrol is Button masaButonu)
                {
                    masaButonu.Click += btnMasa_Click;  // Evente bağla
                }
            }

        }

        private void button45_Click(object sender, EventArgs e)
        {

        }
    }
}
