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
        private string masanumarasi;          //masa numarası
        private DateTime rezervasyonTarihi; // Rezervasyon tarih
        private string mail;
        private string baslangicSaati; // Rezervasyon başlangıç saati
        private string bitisSaati; // Rezervasyon bitiş saati
        public MusteriRez(string mail)
        {
            this.mail = mail;
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
                string masanumarasi = masaButonu.Text;
                odeme odemeFormu = new odeme(masanumarasi,rezervasyonTarihi.Date,mail,baslangicSaati,bitisSaati);
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
