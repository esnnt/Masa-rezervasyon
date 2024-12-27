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
using System.Runtime.CompilerServices;
namespace Masa_rezervasyon
{
    public partial class gecmisYorum : Form
    {
        private string kullaniciMail;
        public gecmisYorum(string mail)
        {
            InitializeComponent();
            kullaniciMail = mail;
        }
        

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string connectionString = "Server=localhost;Database=masarezervasyon;Uid=root;Pwd='esin1021.Tkn';";

                // Seçili satırdaki yorum bilgilerini al
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string yorum = selectedRow.Cells["yorum"].Value.ToString();
                int rezervasyonId = selectedRow.Cells["rezervasyonId"].Value != DBNull.Value
                                    ? Convert.ToInt32(selectedRow.Cells["rezervasyonId"].Value)
                                    : 0;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Yorum silme sorgusu
                        string query = @"DELETE FROM degerlendirme WHERE mail = @mail AND yorum = @yorum AND rezervasyonId = @rezervasyonId";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@mail", kullaniciMail); // Kullanıcının maili
                        cmd.Parameters.AddWithValue("@yorum", yorum);
                        cmd.Parameters.AddWithValue("@rezervasyonId", rezervasyonId);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Yorum başarıyla silindi.");
                            dataGridView1.Rows.Remove(selectedRow); // DataGridView'den sil
                        }
                        else
                        {
                            MessageBox.Show("Yorum silinemedi.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz yorumu seçin.");
            }
        }

        private void gecmisYorum_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=masarezervasyon;Uid=root;Pwd='esin1021.Tkn';";
            string query = @"SELECT yorum, rezervasyonId FROM degerlendirme WHERE mail = @mail";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Kullanıcının yorumlarını çekmek için SQL sorgusu
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@mail", kullaniciMail); // Kullanıcının giriş yaptığı mail

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // DataGridView'e bağla
                    dataGridView1.DataSource = dt;
                    dataGridView1.ReadOnly = true; // Yorumlar düzenlenemez
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
