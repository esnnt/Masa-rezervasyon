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
    public partial class yorumlar : Form
    {
        public yorumlar()
        {
            InitializeComponent();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yorumlar_Load(object sender, EventArgs e)
        {
            //yapılan yorumları datagridviewde görme
            string connectionString = "Server=localhost;Database=masarezervasyon;Uid=root;Pwd='esin1021.Tkn';";

            using (MySqlConnection baglan = new MySqlConnection(connectionString))
            {
                try
                {
                    baglan.Open();

                    // Yorumları çekmek için SQL sorgusu
                    string query = @"SELECT mail, yorum FROM degerlendirme";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, baglan);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // DataGridView'e bağla
                    datagridYorum.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}

