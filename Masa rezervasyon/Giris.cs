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

namespace Masa_rezervasyon
{
    // Mail adresini saklayacak sınıf
   

    public partial class Giris : Form
    {
  
        public Giris()
        {
            InitializeComponent();
         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //kayıt ol linkinkine tıkladığında, kayıt olma ekranı açılacak
            Kayit kyt = new Kayit();
            kyt.Show();
        }





        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yonetici yntc = new yonetici();
            yntc.Show();
        }
       
        private void btngiris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txt_kullaniciadi.Text;
            string mail=txt_mail.Text;  
            string sifre = txt_sifre.Text;


        // Veritabanı bağlantısı
        string connectionString = "Server=localhost;Database=masarezervasyon;Uid=root;Pwd='esin1021.Tkn';";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL sorgusu: Kullanıcı adı ve mail ile şifreyi kontrol et
                    string query = @"SELECT COUNT(*) 
                             FROM kullanici 
                             WHERE kullaniciadi = @Kullaniciadi 
                             AND mail = @mail 
                             AND sifre = @Sifre";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Kullaniciadi", kullaniciadi);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@Sifre", sifre);

                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Kullanıcı doğrulama
                    if (userCount > 0)
                    {
                        // Giriş başarılı, ana ekrana geçiş yapılabilir
                        // Örnek: Ana formu açın
                        this.Hide(); // Mevcut formu gizleyin
                        MusteriRez mstr = new MusteriRez(mail); // Ana form örneği
                        mstr.Show(); // Ana formu açın
                       

                    }
                    if (mail == "e")
                    {

                        yonetici yntc = new yonetici();
                        this.Close();
                        yntc.Show();
                    }
                    /* if("@mail"==mail)
                    {
                        Console.WriteLine("Bu mail kullanımda. Lütfem başka bir mail giriniz.");
                    }*/

                    else
                    {
                        MessageBox.Show("Geçersiz kullanıcı adı, şifre veya mail.");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

            }
        }
    }

}
