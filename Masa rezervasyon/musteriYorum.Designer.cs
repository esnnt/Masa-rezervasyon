namespace Masa_rezervasyon
{
    partial class musteriYorum
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
            id_txt = new TextBox();
            label1 = new Label();
            gndr_btn = new Button();
            degerlendirme_rtb = new RichTextBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(756, 305);
            dataGridView1.TabIndex = 0;
            // 
            // id_txt
            // 
            id_txt.Location = new Point(132, 323);
            id_txt.Name = "id_txt";
            id_txt.Size = new Size(61, 27);
            id_txt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 326);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 2;
            label1.Text = "Rezervasyon id:";
            // 
            // gndr_btn
            // 
            gndr_btn.Location = new Point(500, 409);
            gndr_btn.Name = "gndr_btn";
            gndr_btn.Size = new Size(94, 29);
            gndr_btn.TabIndex = 3;
            gndr_btn.Text = "Gönder";
            gndr_btn.UseVisualStyleBackColor = true;
            gndr_btn.Click += gndr_btn_Click;
            // 
            // degerlendirme_rtb
            // 
            degerlendirme_rtb.Location = new Point(132, 356);
            degerlendirme_rtb.Name = "degerlendirme_rtb";
            degerlendirme_rtb.Size = new Size(362, 82);
            degerlendirme_rtb.TabIndex = 4;
            degerlendirme_rtb.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 359);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 5;
            label2.Text = "Değerlendirme:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 409);
            button1.Name = "button1";
            button1.Size = new Size(83, 29);
            button1.TabIndex = 6;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // musteriYorum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(degerlendirme_rtb);
            Controls.Add(gndr_btn);
            Controls.Add(label1);
            Controls.Add(id_txt);
            Controls.Add(dataGridView1);
            Name = "musteriYorum";
            Text = "musteriYorum";
            Load += musteriYorum_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox id_txt;
        private Label label1;
        private Button gndr_btn;
        private RichTextBox degerlendirme_rtb;
        private Label label2;
        private Button button1;
    }
}