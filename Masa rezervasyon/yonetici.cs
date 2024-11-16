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
    public partial class yonetici : Form
    {
        public yonetici()
        {
            InitializeComponent();
        }

        public void MenuItemleriniGetir(ListView yiyecek_list,ListView icecek_list)
        {
            // Veritabanına bağlantı oluşturma
            MySqlConnection baglan = new MySqlConnection(
                  "Server='localhost';" +
                  "Database='masarezervasyon';" +
                  "Uid='root';" +
                  "Pwd='esin1021.Tkn';");
            try
            {
                // Veritabanından verileri çekme sorgusu
                string query = "SELECT ad FROM menuekle";
                MySqlCommand command = new MySqlCommand(query, baglan);

                // Bağlantıyı açma
                baglan.Open();

                // Sorguyu çalıştırma ve veri okuyucu oluşturma
                string yiyecekQuery = "SELECT ad FROM menuekle WHERE tur = 'yiyecek'";
                MySqlCommand yiyecekCommand = new MySqlCommand(yiyecekQuery, baglan);

                // ListBox'ı temizleme
                yiyecek_list.Items.Clear();
                icecek_list.Items.Clear();

                // Verileri ListBox'a ekleme
                using (MySqlDataReader yiyecekReader = yiyecekCommand.ExecuteReader())
                {
                    // Yiyecekleri listeye ekleme
                    while (yiyecekReader.Read())
                    {
                        string itemName = yiyecekReader["ad"].ToString();
                        yiyecek_list.Items.Add(new ListViewItem(itemName));
                    }
                }
                string icecekQuery = "SELECT ad FROM menuekle WHERE tur = 'içecek'";
                MySqlCommand icecekCommand = new MySqlCommand(icecekQuery, baglan);

                using (MySqlDataReader icecekReader = icecekCommand.ExecuteReader())
                {
                    // İçecekleri listeye ekleme
                    while (icecekReader.Read())
                    {
                        string itemName = icecekReader["ad"].ToString();
                        icecek_list.Items.Add(new ListViewItem(itemName));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }


        private void btn_onay_Click(object sender, EventArgs e)
        {

            // Veritabanına bağlantı oluşturma
            MySqlConnection baglan = new MySqlConnection(
                  "Server='localhost';" +
                  "Database='masarezervasyon';" +
                  "Uid='root';" +
                  "Pwd='esin1021.Tkn';");


            try
            {
                // Veritabanına ekleme sorgusu
                string query = "INSERT INTO menuekle(ad, tur) VALUES (@ad, @tur)";

                // Komut nesnesi oluşturma
                MySqlCommand command = new MySqlCommand(query, baglan);

                // TextBox'tan değer alma
                string ad = txt_menu.Text;  // TextBox'ın adı txtAd

                // RadioButton'lardan değer alma
                string tur = string.Empty;
                

                if (yiyecek.Checked)
                {
                    tur = "yiyecek";  // Eğer radioYiyecek seçiliyse "Yiyecek" atar
                }
                else if (icecek.Checked)
                {
                    tur = "içecek";  // Eğer radioIcecek seçiliyse "İçecek" atar
                }
                else
                {
                    MessageBox.Show("Lütfen bir kategori seçin.");
                    return; // Seçim yapılmadığı için işlemi durdur.
                }

                // Parametre ekleme

                command.Parameters.AddWithValue("@ad", ad);
                command.Parameters.AddWithValue("@tur", tur);

                // Bağlantıyı açma
                baglan.Open();

                // Sorguyu çalıştırma
                int result = command.ExecuteNonQuery();
               
                if (result > 0)
                {
                   
                    string yeniItem = txt_menu.Text;

                    // Eğer TextBox boş değilse, ListBox'a ekle
                    if (!string.IsNullOrEmpty(yeniItem))
                    {
                        if (yiyecek.Checked)
                        {
                            yiyecek_list.Items.Add(yeniItem);
                            MessageBox.Show("Ekleme başarılı.");
                        }
                        if (icecek.Checked)
                        {
                            icecek_list.Items.Add(yeniItem);
                            MessageBox.Show("Ekleme başarılı.");
                        }
                        // TextBox'ı temizle
                        txt_menu.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir ad girin.");
                    }
                }
                else
                {
                    MessageBox.Show("Ekleme başarısız.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                txt_menu.Clear();        // TextBox'ı temizler
                yiyecek.Checked = false; // RadioButton'u false'a çekerek temizler
                icecek.Checked = false;

                // Bağlantıyı kapatma
                if (baglan.State == System.Data.ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
        }

        private void yonetici_Load(object sender, EventArgs e)
        {
            MenuItemleriniGetir(yiyecek_list,icecek_list);

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection(
                 "Server='localhost';" +
                 "Database='masarezervasyon';" +
                 "Uid='root';" +
                 "Pwd='esin';");

            try
            {
                // ListView'den seçili elemanı al
                if (yiyecek_list.SelectedItems.Count > 0)
                {
                    // Seçili öğenin adını al (örneğin, menü adı)
                    string secilenAd = yiyecek_list.SelectedItems[0].Text;

                    // Veritabanı silme sorgusu
                    string query = "DELETE FROM menuekle WHERE ad = @ad";

                    // Komut nesnesi oluşturma
                    MySqlCommand command = new MySqlCommand(query, baglan);

                    // Parametre ekleme
                    command.Parameters.AddWithValue("@ad", secilenAd);

                    // Bağlantıyı açma
                    baglan.Open();

                    // Sorguyu çalıştır
                    int result = command.ExecuteNonQuery();


                    if (result > 0)
                    {
                        // Veritabanından başarıyla silindi, ListView'den de sil
                        yiyecek_list.Items.Remove(yiyecek_list.SelectedItems[0]);
                        MessageBox.Show("Seçilen eleman başarıyla silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi başarısız. Eleman bulunamadı.");
                    }

                }
               
                else if (icecek_list.SelectedItems.Count > 0)
                {
                    // Seçili öğenin adını al (örneğin, menü adı)
                    string secilenAd = icecek_list.SelectedItems[0].Text;

                    // Veritabanı silme sorgusu
                    string query = "DELETE FROM menuekle WHERE ad = @ad";

                    // Komut nesnesi oluşturma
                    MySqlCommand command = new MySqlCommand(query, baglan);

                    // Parametre ekleme
                    command.Parameters.AddWithValue("@ad", secilenAd);

                    // Bağlantıyı açma
                    baglan.Open();

                    // Sorguyu çalıştır
                    int result = command.ExecuteNonQuery();


                    if (result > 0)
                    {
                        // Veritabanından başarıyla silindi, ListView'den de sil
                        icecek_list.Items.Remove(icecek_list.SelectedItems[0]);
                        MessageBox.Show("Seçilen eleman başarıyla silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi başarısız. Eleman bulunamadı.");
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen silmek için bir eleman seçin.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatma
                if (baglan.State == System.Data.ConnectionState.Open)
                {
                    baglan.Close();
                }
            }

        }
  
    }
}
