namespace Masa_rezervasyon
{
    partial class odeme
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
            yiyecek_list = new ListView();
            icecek_list = new ListView();
            dateTimePicker1 = new DateTimePicker();
            rezerve = new Button();
            label1 = new Label();
            label2 = new Label();
            btn_listele = new Button();
            baslangicsaat = new ComboBox();
            saatbitis = new ComboBox();
            lbl_Masa = new Label();
            SuspendLayout();
            // 
            // yiyecek_list
            // 
            yiyecek_list.CheckBoxes = true;
            yiyecek_list.Location = new Point(345, 37);
            yiyecek_list.Name = "yiyecek_list";
            yiyecek_list.Size = new Size(255, 455);
            yiyecek_list.TabIndex = 0;
            yiyecek_list.UseCompatibleStateImageBehavior = false;
            yiyecek_list.View = View.List;
            // 
            // icecek_list
            // 
            icecek_list.CheckBoxes = true;
            icecek_list.Location = new Point(622, 37);
            icecek_list.Name = "icecek_list";
            icecek_list.Size = new Size(261, 455);
            icecek_list.TabIndex = 1;
            icecek_list.UseCompatibleStateImageBehavior = false;
            icecek_list.View = View.List;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(11, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(315, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // rezerve
            // 
            rezerve.Location = new Point(237, 462);
            rezerve.Name = "rezerve";
            rezerve.Size = new Size(90, 29);
            rezerve.TabIndex = 3;
            rezerve.Text = "Rezerve";
            rezerve.UseVisualStyleBackColor = true;
            rezerve.Click += rezerve_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 13);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Yiyecekler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(622, 12);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 6;
            label2.Text = "İçecekler";
            // 
            // btn_listele
            // 
            btn_listele.Location = new Point(793, 4);
            btn_listele.Name = "btn_listele";
            btn_listele.Size = new Size(90, 29);
            btn_listele.TabIndex = 7;
            btn_listele.Text = "Listele";
            btn_listele.UseVisualStyleBackColor = true;
            btn_listele.Click += btn_listele_Click;
            // 
            // baslangicsaat
            // 
            baslangicsaat.FormattingEnabled = true;
            baslangicsaat.Items.AddRange(new object[] { "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00" });
            baslangicsaat.Location = new Point(11, 119);
            baslangicsaat.Name = "baslangicsaat";
            baslangicsaat.Size = new Size(145, 28);
            baslangicsaat.TabIndex = 8;
            baslangicsaat.Text = "Başlangıç Saati";
            baslangicsaat.SelectedIndexChanged += saatbitis_SelectedIndexChanged;
            // 
            // saatbitis
            // 
            saatbitis.FormattingEnabled = true;
            saatbitis.Items.AddRange(new object[] { "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00" });
            saatbitis.Location = new Point(181, 119);
            saatbitis.Name = "saatbitis";
            saatbitis.Size = new Size(145, 28);
            saatbitis.TabIndex = 9;
            saatbitis.Text = "Bitiş Saati";
            saatbitis.SelectedIndexChanged += saatbitis_SelectedIndexChanged;
            // 
            // lbl_Masa
            // 
            lbl_Masa.AutoSize = true;
            lbl_Masa.Location = new Point(11, 12);
            lbl_Masa.Name = "lbl_Masa";
            lbl_Masa.Size = new Size(111, 20);
            lbl_Masa.TabIndex = 10;
           
            // 
            // odeme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 504);
            Controls.Add(lbl_Masa);
            Controls.Add(saatbitis);
            Controls.Add(baslangicsaat);
            Controls.Add(btn_listele);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rezerve);
            Controls.Add(dateTimePicker1);
            Controls.Add(icecek_list);
            Controls.Add(yiyecek_list);
            Name = "odeme";
            Text = "odeme";
            Load += odeme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView yiyecek_list;
        private ListView icecek_list;
        private DateTimePicker dateTimePicker1;
        private Button rezerve;
        private Label label1;
        private Label label2;
        private Button btn_listele;
        private ComboBox baslangicsaat;
        private ComboBox saatbitis;
        private Label lbl_Masa;
    }
}