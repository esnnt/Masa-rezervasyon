﻿namespace Masa_rezervasyon
{
    partial class Giris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button1 = new Button();
            btn_geri = new Button();
            label2 = new Label();
            btngiris = new Button();
            btn_göz = new Button();
            txt_sifre = new TextBox();
            txt_mail = new TextBox();
            txt_kullaniciadi = new TextBox();
            lbl_sifre = new Label();
            lbl_mail = new Label();
            lbl_kullaniciadi = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btn_geri);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btngiris);
            groupBox1.Controls.Add(btn_göz);
            groupBox1.Controls.Add(txt_sifre);
            groupBox1.Controls.Add(txt_mail);
            groupBox1.Controls.Add(txt_kullaniciadi);
            groupBox1.Controls.Add(lbl_sifre);
            groupBox1.Controls.Add(lbl_mail);
            groupBox1.Controls.Add(lbl_kullaniciadi);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(175, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 441);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giriş Yap";
            // 
            // button1
            // 
            button1.Location = new Point(266, 370);
            button1.Name = "button1";
            button1.Size = new Size(94, 31);
            button1.TabIndex = 12;
            button1.Text = "Kayıt olun";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btn_geri
            // 
            btn_geri.Location = new Point(0, 412);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(90, 29);
            btn_geri.TabIndex = 11;
            btn_geri.Text = "Geri";
            btn_geri.UseVisualStyleBackColor = true;
            btn_geri.Click += btn_geri_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 375);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 9;
            label2.Text = "Hesabınız yoksa";
            // 
            // btngiris
            // 
            btngiris.Location = new Point(306, 282);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(90, 29);
            btngiris.TabIndex = 8;
            btngiris.Text = "Giriş";
            btngiris.UseVisualStyleBackColor = true;
            btngiris.Click += btngiris_Click;
            // 
            // btn_göz
            // 
            btn_göz.BackgroundImageLayout = ImageLayout.Stretch;
            btn_göz.Location = new Point(366, 235);
            btn_göz.Name = "btn_göz";
            btn_göz.Size = new Size(30, 29);
            btn_göz.TabIndex = 7;
            btn_göz.UseVisualStyleBackColor = true;
            btn_göz.Click += btn_göz_Click;
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(152, 235);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(208, 27);
            txt_sifre.TabIndex = 6;
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(150, 188);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(210, 27);
            txt_mail.TabIndex = 5;
            // 
            // txt_kullaniciadi
            // 
            txt_kullaniciadi.Location = new Point(152, 139);
            txt_kullaniciadi.Name = "txt_kullaniciadi";
            txt_kullaniciadi.Size = new Size(208, 27);
            txt_kullaniciadi.TabIndex = 4;
            // 
            // lbl_sifre
            // 
            lbl_sifre.AutoSize = true;
            lbl_sifre.Location = new Point(77, 241);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(42, 20);
            lbl_sifre.TabIndex = 3;
            lbl_sifre.Text = "Şifre:";
            // 
            // lbl_mail
            // 
            lbl_mail.AutoSize = true;
            lbl_mail.Location = new Point(77, 195);
            lbl_mail.Name = "lbl_mail";
            lbl_mail.Size = new Size(41, 20);
            lbl_mail.TabIndex = 2;
            lbl_mail.Text = "Mail:";
            // 
            // lbl_kullaniciadi
            // 
            lbl_kullaniciadi.AutoSize = true;
            lbl_kullaniciadi.Location = new Point(23, 145);
            lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            lbl_kullaniciadi.Size = new Size(95, 20);
            lbl_kullaniciadi.TabIndex = 1;
            lbl_kullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("LEMON MILK Medium", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 23);
            label1.Name = "label1";
            label1.Size = new Size(226, 40);
            label1.TabIndex = 0;
            label1.Text = "HOŞ GELDİNİZ";
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 504);
            Controls.Add(groupBox1);
            Name = "Giris";
            Text = "Giris";
            Load += Giris_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_sifre;
        private TextBox txt_mail;
        private TextBox txt_kullaniciadi;
        private Label lbl_sifre;
        private Label lbl_mail;
        private Label lbl_kullaniciadi;
        private Label label1;
        private Button btn_göz;
        private Label label2;
        private Button btngiris;
        private Button btn_geri;
        private Button button1;
    }
}