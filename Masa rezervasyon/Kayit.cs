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

        private void btn_kayit_Click(object sender, EventArgs e)
        {

            string connectionString = "Server=localhost;Database=masarezervasyon;Uid=root;Pwd='esin1021.Tkn';";
            using (MySqlConnection baglan = new MySqlConnection(connectionString))
            {
                try
                {
                    //  baglan.Open();
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
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Kayıt işlemi başarısız.");
                    }
                    baglan.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void btn_geri_Click(object sender, EventArgs e)
        {
            //bulunduğu sayfayı kapatarak bir önceki sayfaya dönmesini sağlıyor.
            this.Close();
        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            txt_sifre.UseSystemPasswordChar = true; // Şifre başlangıçta gizli
            btn_goz.BackgroundImage = Image.FromFile("C:\\Users\\esint\\Desktop\\k\\bitirme projesi\\hide.png"); // Kapalı göz simgesi
        }
        private bool sifreGizli = true;
        private void btn_goz_Click(object sender, EventArgs e)
        {

            if (sifreGizli)
            {
                // Eğer şifre gizliyse, açık göz simgesini ayarla ve şifreyi görünür yap
                txt_sifre.UseSystemPasswordChar = false; // Şifreyi görünür yap
                btn_goz.BackgroundImage = Image.FromFile("C:\\Users\\esint\\Desktop\\k\\bitirme projesi\\witness.png"); // Açık göz simgesi
                sifreGizli = false; // Durumu güncelle
            }
            else
            {
                // Eğer şifre görünüyorsa, kapalı göz simgesini ayarla ve şifreyi gizle
                txt_sifre.UseSystemPasswordChar = true; // Şifreyi gizle
                btn_goz.BackgroundImage = Image.FromFile("C:\\Users\\esint\\Desktop\\k\\bitirme projesi\\hide.png"); // Kapalı göz simgesi
                sifreGizli = true; // Durumu güncelle   
            }
        }
    }
}
