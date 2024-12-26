namespace Masa_rezervasyon
{
    partial class Kayit
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
            btn_kayit = new Button();
            btn_goz = new Button();
            txt_sifre = new TextBox();
            txt_mail = new TextBox();
            txt_kullaniciadi = new TextBox();
            lbl_sifre = new Label();
            lbl_mail = new Label();
            lbl_kullaniciadi = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_geri);
            groupBox1.Controls.Add(btn_kayit);
            groupBox1.Controls.Add(btn_goz);
            groupBox1.Controls.Add(txt_sifre);
            groupBox1.Controls.Add(txt_mail);
            groupBox1.Controls.Add(txt_kullaniciadi);
            groupBox1.Controls.Add(lbl_sifre);
            groupBox1.Controls.Add(lbl_mail);
            groupBox1.Controls.Add(lbl_kullaniciadi);
            groupBox1.Location = new Point(178, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 441);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kayıt Ol";
         
            // 
            // btn_geri
            // 
            btn_geri.Location = new Point(0, 412);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(90, 29);
            btn_geri.TabIndex = 8;
            btn_geri.Text = "Geri";
            btn_geri.UseVisualStyleBackColor = true;
            btn_geri.Click += btn_geri_Click;
            // 
            // btn_kayit
            // 
            btn_kayit.Location = new Point(332, 291);
            btn_kayit.Name = "btn_kayit";
            btn_kayit.Size = new Size(86, 29);
            btn_kayit.TabIndex = 7;
            btn_kayit.Text = "Kayıt Ol";
            btn_kayit.UseVisualStyleBackColor = true;
            btn_kayit.Click += btn_kayit_Click;
            // 
            // btn_goz
            // 
            btn_goz.BackgroundImageLayout = ImageLayout.Stretch;
            btn_goz.Location = new Point(388, 245);
            btn_goz.Name = "btn_goz";
            btn_goz.Size = new Size(30, 29);
            btn_goz.TabIndex = 6;
            btn_goz.UseVisualStyleBackColor = true;
            btn_goz.Click += btn_goz_Click;
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(161, 245);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(221, 27);
            txt_sifre.TabIndex = 5;
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(161, 189);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(221, 27);
            txt_mail.TabIndex = 4;
            // 
            // txt_kullaniciadi
            // 
            txt_kullaniciadi.Location = new Point(161, 132);
            txt_kullaniciadi.Name = "txt_kullaniciadi";
            txt_kullaniciadi.Size = new Size(221, 27);
            txt_kullaniciadi.TabIndex = 3;
            // 
            // lbl_sifre
            // 
            lbl_sifre.AutoSize = true;
            lbl_sifre.Location = new Point(101, 252);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(42, 20);
            lbl_sifre.TabIndex = 2;
            lbl_sifre.Text = "Şifre:";
            // 
            // lbl_mail
            // 
            lbl_mail.AutoSize = true;
            lbl_mail.Location = new Point(101, 196);
            lbl_mail.Name = "lbl_mail";
            lbl_mail.Size = new Size(41, 20);
            lbl_mail.TabIndex = 1;
            lbl_mail.Text = "Mail:";
            // 
            // lbl_kullaniciadi
            // 
            lbl_kullaniciadi.AutoSize = true;
            lbl_kullaniciadi.Location = new Point(47, 138);
            lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            lbl_kullaniciadi.Size = new Size(95, 20);
            lbl_kullaniciadi.TabIndex = 0;
            lbl_kullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // Kayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 504);
            Controls.Add(groupBox1);
            Name = "Kayit";
            Text = "Kayit";
            Load += Kayit_Load;
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
        private Button btn_goz;
        private Button btn_kayit;
        private Button btn_geri;
    }
}