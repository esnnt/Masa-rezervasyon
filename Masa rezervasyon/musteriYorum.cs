using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;


namespace Masa_rezervasyon
{
    public partial class musteriYorum : Form
    {
        private string kullaniciMail;
        public musteriYorum(string mail)
        {
            InitializeComponent();
            kullaniciMail = mail;
        }
        // Mail adresini saklamak için
        private void musteriYorum_Load(object sender, EventArgs e)
        {

            string connectionString = "Server=localhost;Database=masarezervasyon;Uid=root;Pwd='esin1021.Tkn';";
            string query = @"SELECT rezervasyonId, masaNo, tarih, baslangicsaat, saatbitis, secilenyemekler 
                     FROM odeme 
                     WHERE mail = @mail";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@mail", kullaniciMail); // Kullanıcının oturumdaki maili

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt; // DataGridView'e bağla
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }


        }

        private void gndr_btn_Click(object sender, EventArgs e)
        {

            // Kullanıcıdan gelen girişleri al
            string rezervasyonIdStr = id_txt.Text.Trim();
            string yorum = degerlendirme_rtb.Text.Trim();

            // Girişleri doğrula
            if (string.IsNullOrWhiteSpace(rezervasyonIdStr) || string.IsNullOrWhiteSpace(yorum))
            {
                MessageBox.Show("Lütfen bir rezervasyon ID ve yorum yazın.");
                return;
            }

            if (!int.TryParse(rezervasyonIdStr, out int rezervasyonId))
            {
                MessageBox.Show("Lütfen geçerli bir rezervasyon ID girin.");
                return;
            }

            string connectionString = "Server=localhost;Database=masarezervasyon;Uid=root;Pwd='esin1021.Tkn';";

            using (MySqlConnection baglan = new MySqlConnection(connectionString))
            {
                try
                {
                    baglan.Open();

                    // Yorum ekleme sorgusu
                    string query = @"INSERT INTO degerlendirme (mail, yorum, rezervasyonId) 
                             VALUES (@mail, @yorum, @rezervasyonId)";
                    MySqlCommand cmd = new MySqlCommand(query, baglan);
                    cmd.Parameters.AddWithValue("@mail", kullaniciMail); // Kullanıcının oturumdaki maili
                    cmd.Parameters.AddWithValue("@yorum", yorum);
                    cmd.Parameters.AddWithValue("@rezervasyonId", rezervasyonId);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Yorum başarıyla eklendi.");
                        degerlendirme_rtb.Clear(); // Yorum alanını temizle
                        id_txt.Clear(); // Rezervasyon ID alanını temizle
                        baglan.Close();
                    }
                    else
                    {
                        MessageBox.Show("Yorum eklenemedi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

