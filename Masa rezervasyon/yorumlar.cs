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
using System.Net.Mail;

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
            string connectionString = "Server=localhost;Database=masarezervasyon;Uid=root;Pwd='esin1021.Tkn';";

            using (MySqlConnection baglan = new MySqlConnection(connectionString))
            {
                try
                {
                    baglan.Open();

                    // Genel yorumları çekmek için SQL sorgusu
                    string genelYorumQuery = @"SELECT mail, yorum FROM degerlendirme WHERE rezervasyonId IS NULL OR rezervasyonId = 0";
                    MySqlDataAdapter genelYorumAdapter = new MySqlDataAdapter(genelYorumQuery, baglan);
                    DataTable genelYorumTable = new DataTable();
                    genelYorumAdapter.Fill(genelYorumTable);

                    // Genel yorumları DataGridView'e bağla
                    datagridYorum.DataSource = genelYorumTable;
                    datagridYorum.ReadOnly = true;

                    // Rezervasyonlara özel yorumları çekmek için SQL sorgusu
                    string rezervasyonYorumQuery = @"SELECT mail, yorum, rezervasyonId FROM degerlendirme WHERE rezervasyonId IS NOT NULL AND rezervasyonId != 0";
                    MySqlDataAdapter rezervasyonYorumAdapter = new MySqlDataAdapter(rezervasyonYorumQuery, baglan);
                    DataTable rezervasyonYorumTable = new DataTable();
                    rezervasyonYorumAdapter.Fill(rezervasyonYorumTable);

                    // Rezervasyon yorumlarını DataGridView'e bağla
                    datagridgecmisyorum.DataSource = rezervasyonYorumTable;
                    datagridgecmisyorum.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    if (baglan.State == ConnectionState.Open)
                    {
                        baglan.Close();
                    }
                }
            }
        }

        private void datagridYorum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

