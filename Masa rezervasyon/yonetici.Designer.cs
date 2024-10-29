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
            onay_btn = new Button();
            listView_yiyecek = new ListView();
            listView_icecek = new ListView();
            label2 = new Label();
            label3 = new Label();
            yiyecek_txtbox = new TextBox();
            icecek_txtbox = new TextBox();
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
            // onay_btn
            // 
            onay_btn.Location = new Point(641, 336);
            onay_btn.Name = "onay_btn";
            onay_btn.Size = new Size(242, 28);
            onay_btn.TabIndex = 4;
            onay_btn.Text = "Onay";
            onay_btn.UseVisualStyleBackColor = true;
            // 
            // listView_yiyecek
            // 
            listView_yiyecek.Location = new Point(641, 40);
            listView_yiyecek.Name = "listView_yiyecek";
            listView_yiyecek.Size = new Size(242, 119);
            listView_yiyecek.TabIndex = 5;
            listView_yiyecek.UseCompatibleStateImageBehavior = false;
            // 
            // listView_icecek
            // 
            listView_icecek.Location = new Point(641, 200);
            listView_icecek.Name = "listView_icecek";
            listView_icecek.Size = new Size(242, 127);
            listView_icecek.TabIndex = 6;
            listView_icecek.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(641, 13);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 7;
            label2.Text = "Yiyecek ekle:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(641, 176);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 8;
            label3.Text = "İçecek ekle:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yiyecek_txtbox
            // 
            yiyecek_txtbox.Location = new Point(735, 10);
            yiyecek_txtbox.Name = "yiyecek_txtbox";
            yiyecek_txtbox.Size = new Size(148, 26);
            yiyecek_txtbox.TabIndex = 9;
            // 
            // icecek_txtbox
            // 
            icecek_txtbox.Location = new Point(735, 170);
            icecek_txtbox.Name = "icecek_txtbox";
            icecek_txtbox.Size = new Size(148, 26);
            icecek_txtbox.TabIndex = 10;
            // 
            // yonetici
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 479);
            Controls.Add(icecek_txtbox);
            Controls.Add(yiyecek_txtbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView_icecek);
            Controls.Add(listView_yiyecek);
            Controls.Add(onay_btn);
            Controls.Add(masa_tasi);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "yonetici";
            Text = "yonetici";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Button masa_tasi;
        private Button onay_btn;
        private ListView listView_yiyecek;
        private ListView listView_icecek;
        private Label label2;
        private Label label3;
        private TextBox yiyecek_txtbox;
        private TextBox icecek_txtbox;
    }
}