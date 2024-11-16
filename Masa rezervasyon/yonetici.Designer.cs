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
            textBox1 = new TextBox();
            label1 = new Label();
            masa_tasi = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.Size = new Size(623, 314);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 359);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 26);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 336);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // masa_tasi
            // 
            masa_tasi.Location = new Point(12, 439);
            masa_tasi.Name = "masa_tasi";
            masa_tasi.Size = new Size(136, 28);
            masa_tasi.TabIndex = 3;
            masa_tasi.Text = "Masa Taşıma";
            masa_tasi.UseVisualStyleBackColor = true;
            // 
            // btn_onay
            // 
            btn_onay.Location = new Point(806, 42);
            btn_onay.Name = "btn_onay";
            btn_onay.Size = new Size(77, 46);
            btn_onay.TabIndex = 4;
            btn_onay.Text = "Onay";
            btn_onay.UseVisualStyleBackColor = true;
            btn_onay.Click += btn_onay_Click;
            // 
            // yiyecek_list
            // 
            yiyecek_list.Location = new Point(641, 114);
            yiyecek_list.Name = "yiyecek_list";
            yiyecek_list.Size = new Size(117, 212);
            yiyecek_list.TabIndex = 5;
            yiyecek_list.UseCompatibleStateImageBehavior = false;
            yiyecek_list.View = View.SmallIcon;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(641, 16);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 7;
            label2.Text = "Menüye ekle:";
            // 
            // txt_menu
            // 
            txt_menu.Location = new Point(735, 10);
            txt_menu.Name = "txt_menu";
            txt_menu.Size = new Size(148, 26);
            txt_menu.TabIndex = 9;
            // 
            // icecek
            // 
            icecek.AutoSize = true;
            icecek.Location = new Point(641, 69);
            icecek.Name = "icecek";
            icecek.Size = new Size(68, 24);
            icecek.TabIndex = 10;
            icecek.TabStop = true;
            icecek.Text = "İçecek";
            icecek.UseVisualStyleBackColor = true;
            // 
            // yiyecek
            // 
            yiyecek.AutoSize = true;
            yiyecek.Location = new Point(641, 42);
            yiyecek.Name = "yiyecek";
            yiyecek.Size = new Size(76, 24);
            yiyecek.TabIndex = 11;
            yiyecek.TabStop = true;
            yiyecek.Text = "Yiyecek";
            yiyecek.UseVisualStyleBackColor = true;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(719, 42);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(81, 46);
            btn_sil.TabIndex = 12;
            btn_sil.Text = "sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // icecek_list
            // 
            icecek_list.Location = new Point(764, 114);
            icecek_list.Name = "icecek_list";
            icecek_list.Size = new Size(119, 212);
            icecek_list.TabIndex = 13;
            icecek_list.UseCompatibleStateImageBehavior = false;
            icecek_list.View = View.SmallIcon;
            // 
            // lbl_icecek
            // 
            lbl_icecek.AutoSize = true;
            lbl_icecek.Location = new Point(764, 91);
            lbl_icecek.Name = "lbl_icecek";
            lbl_icecek.Size = new Size(67, 20);
            lbl_icecek.TabIndex = 14;
            lbl_icecek.Text = "İçecekler";
            // 
            // lbl_yiyecek
            // 
            lbl_yiyecek.AutoSize = true;
            lbl_yiyecek.Location = new Point(642, 91);
            lbl_yiyecek.Name = "lbl_yiyecek";
            lbl_yiyecek.Size = new Size(75, 20);
            lbl_yiyecek.TabIndex = 14;
            lbl_yiyecek.Text = "Yiyecekler";
            // 
            // yonetici
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 479);
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
            Controls.Add(masa_tasi);
            Controls.Add(label1);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label1;
        private Button masa_tasi;
        private Button btn_onay;
        private Label label2;
        private TextBox txt_menu;
        private RadioButton yiyecek;
        private Button btn_sil;
        private RadioButton icecek;
        private ListView icecek_list;
        private Label lbl_icecek;
        private Label lbl_yiyecek;
        // private ListView listView1;
    }
}