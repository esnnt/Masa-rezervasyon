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

            MySqlConnection baglan = new MySqlConnection(
            "Server='localhost';" +
            "Database='masarezervasyon';" +
            "Uid='root';" +
            "Pwd='esin;");

            string kullaniciadi = txt_kullaniciadi.Text;
                string sifre = txt_sifre.Text;
                string mail = txt_mail.Text;
                string rol = "user";  // Varsayılan olarak 'user' rolü atıyoruz.

                // Eğer kullanıcının adı 'adminUser' ise rolü 'admin' yapma
                // Ancak veritabanında bu kullanıcı zaten var. Bu durumda sadece normal kullanıcı kaydedilecek.
                if (kullaniciadi != "esin")  // 'esin' dışında her kullanıcı 'user' olacak
                {
                    rol = "user";  // Varsayılan olarak 'user' rolü
                }

                // Boş alan kontrolü
                if (string.IsNullOrEmpty(kullaniciadi) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(mail))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                // Veritabanı bağlantısı
              
                    baglan.Open();

                    // Kullanıcı bilgilerini ve rolünü veritabanına ekle
                    string query = "INSERT INTO kullanici (kullaniciadi, sifre, mail, rol) VALUES (@kullaniciadi, @sifre, @mail, @rol)";
                    MySqlCommand cmd = new MySqlCommand(query, baglan);
                    cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@rol", rol); // Rolü ekle

                    // Sorguyu çalıştır ve kaydı veritabanına ekle
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla tamamlandı.");
                       txt_kullaniciadi.Clear();
                       txt_sifre.Clear();
                       txt_mail.Clear();
                    }

                    else
                    {
                        MessageBox.Show("Kayıt işlemi başarısız.");
                    }

        }


        private void btn_geri_Click(object sender, EventArgs e)
        {
            //bulunduğu sayfayı kapatarak bir önceki sayfaya dönmesini sağlıyor.
            this.Close();
        }

        private void Kayit_Load(object sender, EventArgs e)
        {

        }
    }
}
