namespace Masa_rezervasyon
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
            btn_geri = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            btn_giris = new Button();
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
            groupBox1.Controls.Add(btn_geri);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btn_giris);
            groupBox1.Controls.Add(btn_göz);
            groupBox1.Controls.Add(txt_sifre);
            groupBox1.Controls.Add(txt_mail);
            groupBox1.Controls.Add(txt_kullaniciadi);
            groupBox1.Controls.Add(lbl_sifre);
            groupBox1.Controls.Add(lbl_mail);
            groupBox1.Controls.Add(lbl_kullaniciadi);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(175, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 419);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giriş Yap";
            // 
            // btn_geri
            // 
            btn_geri.Location = new Point(0, 391);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(90, 28);
            btn_geri.TabIndex = 11;
            btn_geri.Text = "Geri";
            btn_geri.UseVisualStyleBackColor = true;
            btn_geri.Click += btn_geri_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(259, 356);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(80, 20);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kayıt Olun.";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 356);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 9;
            label2.Text = "Hesabınız yoksa";
            // 
            // btn_giris
            // 
            btn_giris.Location = new Point(306, 268);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(90, 28);
            btn_giris.TabIndex = 8;
            btn_giris.Text = "Giriş";
            btn_giris.UseVisualStyleBackColor = true;
            btn_giris.Click += btn_giris_Click;
            // 
            // btn_göz
            // 
            btn_göz.Location = new Point(366, 223);
            btn_göz.Name = "btn_göz";
            btn_göz.Size = new Size(30, 28);
            btn_göz.TabIndex = 7;
            btn_göz.UseVisualStyleBackColor = true;
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(152, 223);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(208, 26);
            txt_sifre.TabIndex = 6;
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(150, 179);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(210, 26);
            txt_mail.TabIndex = 5;
            // 
            // txt_kullaniciadi
            // 
            txt_kullaniciadi.Location = new Point(152, 132);
            txt_kullaniciadi.Name = "txt_kullaniciadi";
            txt_kullaniciadi.Size = new Size(208, 26);
            txt_kullaniciadi.TabIndex = 4;
            // 
            // lbl_sifre
            // 
            lbl_sifre.AutoSize = true;
            lbl_sifre.Location = new Point(77, 229);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(42, 20);
            lbl_sifre.TabIndex = 3;
            lbl_sifre.Text = "Şifre:";
            // 
            // lbl_mail
            // 
            lbl_mail.AutoSize = true;
            lbl_mail.Location = new Point(77, 185);
            lbl_mail.Name = "lbl_mail";
            lbl_mail.Size = new Size(41, 20);
            lbl_mail.TabIndex = 2;
            lbl_mail.Text = "Mail:";
            // 
            // lbl_kullaniciadi
            // 
            lbl_kullaniciadi.AutoSize = true;
            lbl_kullaniciadi.Location = new Point(23, 138);
            lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            lbl_kullaniciadi.Size = new Size(95, 20);
            lbl_kullaniciadi.TabIndex = 1;
            lbl_kullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("LEMON MILK Medium", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 22);
            label1.Name = "label1";
            label1.Size = new Size(210, 37);
            label1.TabIndex = 0;
            label1.Text = "HOŞ GELDİNİZ";
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 479);
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
        private LinkLabel linkLabel1;
        private Label label2;
        private Button btn_giris;
        private Button btn_geri;
    }
}