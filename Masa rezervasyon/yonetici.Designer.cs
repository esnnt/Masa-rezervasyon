namespace Masa_rezervasyon
{
    partial class yonetici
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
            dataGridView1 = new DataGridView();
            btn_onay = new Button();
            yiyecek_list = new ListView();
            label2 = new Label();
            txt_menu = new TextBox();
            icecek = new RadioButton();
            yiyecek = new RadioButton();
            btn_sil = new Button();
            icecek_list = new ListView();
            lbl_icecek = new Label();
            lbl_yiyecek = new Label();
            rez_iptal = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            btn_yenile = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.Size = new Size(623, 331);
            dataGridView1.TabIndex = 0;
            // 
            // btn_onay
            // 
            btn_onay.Location = new Point(806, 44);
            btn_onay.Name = "btn_onay";
            btn_onay.Size = new Size(77, 48);
            btn_onay.TabIndex = 4;
            btn_onay.Text = "Onay";
            btn_onay.UseVisualStyleBackColor = true;
            btn_onay.Click += btn_onay_Click;
            // 
            // yiyecek_list
            // 
            yiyecek_list.Location = new Point(641, 120);
            yiyecek_list.Name = "yiyecek_list";
            yiyecek_list.Size = new Size(117, 223);
            yiyecek_list.TabIndex = 5;
            yiyecek_list.UseCompatibleStateImageBehavior = false;
            yiyecek_list.View = View.SmallIcon;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(641, 17);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 7;
            label2.Text = "Menüye ekle:";
            // 
            // txt_menu
            // 
            txt_menu.Location = new Point(735, 11);
            txt_menu.Name = "txt_menu";
            txt_menu.Size = new Size(148, 27);
            txt_menu.TabIndex = 9;
            // 
            // icecek
            // 
            icecek.AutoSize = true;
            icecek.Location = new Point(641, 73);
            icecek.Name = "icecek";
            icecek.Size = new Size(71, 24);
            icecek.TabIndex = 10;
            icecek.TabStop = true;
            icecek.Text = "İçecek";
            icecek.UseVisualStyleBackColor = true;
            // 
            // yiyecek
            // 
            yiyecek.AutoSize = true;
            yiyecek.Location = new Point(641, 44);
            yiyecek.Name = "yiyecek";
            yiyecek.Size = new Size(79, 24);
            yiyecek.TabIndex = 11;
            yiyecek.TabStop = true;
            yiyecek.Text = "Yiyecek";
            yiyecek.UseVisualStyleBackColor = true;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(719, 44);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(81, 48);
            btn_sil.TabIndex = 12;
            btn_sil.Text = "sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // icecek_list
            // 
            icecek_list.Location = new Point(764, 120);
            icecek_list.Name = "icecek_list";
            icecek_list.Size = new Size(119, 223);
            icecek_list.TabIndex = 13;
            icecek_list.UseCompatibleStateImageBehavior = false;
            icecek_list.View = View.SmallIcon;
            // 
            // lbl_icecek
            // 
            lbl_icecek.AutoSize = true;
            lbl_icecek.Location = new Point(764, 96);
            lbl_icecek.Name = "lbl_icecek";
            lbl_icecek.Size = new Size(67, 20);
            lbl_icecek.TabIndex = 14;
            lbl_icecek.Text = "İçecekler";
            // 
            // lbl_yiyecek
            // 
            lbl_yiyecek.AutoSize = true;
            lbl_yiyecek.Location = new Point(642, 96);
            lbl_yiyecek.Name = "lbl_yiyecek";
            lbl_yiyecek.Size = new Size(75, 20);
            lbl_yiyecek.TabIndex = 14;
            lbl_yiyecek.Text = "Yiyecekler";
            // 
            // rez_iptal
            // 
            rez_iptal.Location = new Point(205, 350);
            rez_iptal.Name = "rez_iptal";
            rez_iptal.Size = new Size(145, 29);
            rez_iptal.TabIndex = 15;
            rez_iptal.Text = "Rezervasyon iptali";
            rez_iptal.UseVisualStyleBackColor = true;
            rez_iptal.Click += rez_iptal_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 350);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 27);
            textBox1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 355);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 17;
            label1.Text = "Müşteri id:";
            // 
            // btn_yenile
            // 
            btn_yenile.Location = new Point(541, 349);
            btn_yenile.Name = "btn_yenile";
            btn_yenile.Size = new Size(94, 29);
            btn_yenile.TabIndex = 18;
            btn_yenile.Text = "Yenile";
            btn_yenile.UseVisualStyleBackColor = true;
            btn_yenile.Click += btn_yenile_Click;
            // 
            // yonetici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 504);
            Controls.Add(btn_yenile);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(rez_iptal);
            Controls.Add(lbl_yiyecek);
            Controls.Add(lbl_icecek);
            Controls.Add(icecek_list);
            Controls.Add(btn_sil);
            Controls.Add(yiyecek);
            Controls.Add(icecek);
            Controls.Add(txt_menu);
            Controls.Add(label2);
            Controls.Add(yiyecek_list);
            Controls.Add(btn_onay);
            Controls.Add(dataGridView1);
            Name = "yonetici";
            Text = "yonetici";
            Load += yonetici_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ListView yiyecek_list;
        

        private DataGridView dataGridView1;
        private Button btn_onay;
        private Label label2;
        private TextBox txt_menu;
        private RadioButton yiyecek;
        private Button btn_sil;
        private RadioButton icecek;
        private ListView icecek_list;
        private Label lbl_icecek;
        private Label lbl_yiyecek;
        private Button rez_iptal;
        private TextBox textBox1;
        private Label label1;
        private Button btn_yenile;
        // private ListView listView1;
    }
}