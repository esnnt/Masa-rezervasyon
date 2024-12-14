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
using MySql.Data;



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
                odeme odemeFormu = new odeme(masanumarasi, rezervasyonTarihi.Date, mail, baslangicSaati, bitisSaati);
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

        private void button1_Click(object sender, EventArgs e)
        {
        
            // TextBox'tan mail adresini ve RichTextBox'tan yorumu al
            string mail = txt_mail.Text; // Kullanıcının yazdığı mail adresi
            string yorum = richTextBox1.Text;

            // Mail ve yorum boş mu kontrol et
            if (string.IsNullOrWhiteSpace(mail))
            {
                MessageBox.Show("Lütfen bir mail adresi girin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(yorum))
            {
                MessageBox.Show("Lütfen bir yorum yazın.");
                return;
            }

            // Veritabanı bağlantısı
            string connectionString = "Server=localhost;Database=masarezervasyon;Uid=root;Pwd='esin1021.Tkn';";

            using (MySqlConnection baglan = new MySqlConnection(connectionString))
            {
                try
                {
                    baglan.Open();

                    // Mailin kullanicilar tablosunda kayıtlı olup olmadığını kontrol et
                    string kontrolQuery = @"SELECT COUNT(*) FROM kullanici WHERE mail = @mail";

                    MySqlCommand kontrolCmd = new MySqlCommand(kontrolQuery, baglan);
                    kontrolCmd.Parameters.AddWithValue("@mail", mail);

                    int kayitliMi = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                    if (kayitliMi == 0)
                    {
                        MessageBox.Show("Bu mail adresi sistemde kayıtlı değil. Lütfen geçerli bir mail adresi girin.");
                        return;
                    }

                    // Mail kayıtlıysa yorumu kaydet
                    string query = @"INSERT INTO degerlendirme (mail, yorum) 
                             VALUES (@mail, @yorum)";

                    MySqlCommand cmd = new MySqlCommand(query, baglan);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@yorum", yorum);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Yorum başarıyla kaydedildi.");
                        richTextBox1.Clear(); // Yorum alanını temizle
                        txt_mail.Clear(); // Mail alanını temizle
                        baglan.Close();
                    }
                    else
                    {
                        MessageBox.Show("Yorum kaydedilirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

    }

}


