﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Net.Mail;

namespace Masa_rezervasyon
{
    public partial class odeme : Form
    {



        // Constructor: Masa numarasını burada alıyoruz
        public odeme(string masanumarasi, DateTime rezervasyonTarihi, string mail, string baslangicSaati, string bitisSaati)
        {
            InitializeComponent();
            this.masanumarasi = masanumarasi;
            // Masa numarasını bir Label veya TextBox'a gösterebilirsiniz
            lbl_Masa.Text = "Masa No: " + masanumarasi;
            this.rezervasyonTarihi = rezervasyonTarihi;
            this.mail = mail;
            this.baslangicSaati = baslangicSaati;
            this.bitisSaati = bitisSaati;
        }


        private void odeme_Load(object sender, EventArgs e)
        {

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            yonetici yonetici = new yonetici();
            yonetici.MenuItemleriniGetir(yiyecek_list, icecek_list);
        }


        private string masanumarasi;          //masa numarası
        private DateTime rezervasyonTarihi; // Rezervasyon tarihi
        private string mail;
        private string baslangicSaati; // Rezervasyon başlangıç saati
        private string bitisSaati; // Rezervasyon bitiş saati



        private void rezerve_Click(object sender, EventArgs e)

        {


            rezervasyonTarihi = dateTimePicker1.Value.Date;
            baslangicSaati = baslangicsaat.Text;
            bitisSaati = saatbitis.Text;
            if(baslangicSaati== "Başlangıç Saati" || bitisSaati== "Bitiş Saati")
            {
                MessageBox.Show("başlangıç ve bitiş saati seçin");
                return;
            }
            string connectionString = "Server=localhost;Database=masarezervasyon;Uid=root;Pwd='esin1021.Tkn';";

            // ListBox veya ListView'den seçilen yiyecek ve içecekler
            // Yiyecek ve içecekleri seçili (işaretlenmiş) elemanlardan alıyoruz
            string secilenYemekler = string.Join(", ", yiyecek_list.CheckedItems.Cast<ListViewItem>().Select(item => item.Text));
            string secilenIcecekler = string.Join(", ", icecek_list.CheckedItems.Cast<ListViewItem>().Select(item => item.Text));

            // Eğer hiçbir şey seçilmemişse uyarı gösteriyoruz
            if (string.IsNullOrEmpty(secilenYemekler) && string.IsNullOrEmpty(secilenIcecekler))
            {
                MessageBox.Show("Lütfen en az bir yiyecek veya içecek seçin.");
                return;
            }

            // Örnek: Seçilen yiyecek ve içecekleri göstermek
            MessageBox.Show("Seçilen Yiyecekler: " + secilenYemekler + "\nSeçilen İçecekler: " + secilenIcecekler);


            if (string.IsNullOrEmpty(secilenYemekler) && string.IsNullOrEmpty(secilenIcecekler))
            {
                MessageBox.Show("Lütfen en az bir yemek veya içecek seçin.");
                return;
            }

            // Veritabanı bağlantısı
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    
                    // Rezervasyonu kaydet
                    string insertQuery = @"INSERT INTO odeme (masaNo, tarih,mail, baslangicsaat, saatbitis, secilenyemekler) 
                                       VALUES (@masaNo, @tarih,@mail, @baslangicsaat, @saatbitis, @secilenyemekler)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@masaNo", masanumarasi);
                    insertCmd.Parameters.AddWithValue("@tarih", rezervasyonTarihi);
                    insertCmd.Parameters.AddWithValue("@mail", mail);
                    insertCmd.Parameters.AddWithValue("@baslangicsaat", baslangicSaati);
                    insertCmd.Parameters.AddWithValue("@saatbitis", bitisSaati);
                    insertCmd.Parameters.AddWithValue("@secilenyemekler", secilenYemekler + ", " + secilenIcecekler); // Yiyecekler ve içecekler

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Rezervasyon ve ödeme başarılı.");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }


            }
        }

        private void saatbitis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
