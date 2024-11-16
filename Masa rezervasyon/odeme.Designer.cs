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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            btn_listele = new Button();
            SuspendLayout();
            // 
            // yiyecek_list
            // 
            yiyecek_list.Location = new Point(345, 35);
            yiyecek_list.Name = "yiyecek_list";
            yiyecek_list.Size = new Size(255, 432);
            yiyecek_list.TabIndex = 0;
            yiyecek_list.UseCompatibleStateImageBehavior = false;
            // 
            // icecek_list
            // 
            icecek_list.Location = new Point(622, 35);
            icecek_list.Name = "icecek_list";
            icecek_list.Size = new Size(261, 432);
            icecek_list.TabIndex = 1;
            icecek_list.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(279, 26);
            dateTimePicker1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(237, 439);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 3;
            button1.Text = "Rezerve";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 12);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Yiyecekler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(622, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 6;
            label2.Text = "İçecekler";
            // 
            // btn_listele
            // 
            btn_listele.Location = new Point(793, 4);
            btn_listele.Name = "btn_listele";
            btn_listele.Size = new Size(90, 28);
            btn_listele.TabIndex = 7;
            btn_listele.Text = "Listele";
            btn_listele.UseVisualStyleBackColor = true;
            btn_listele.Click += btn_listele_Click;
            // 
            // odeme
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 479);
            Controls.Add(btn_listele);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
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
        private Button button1;
        private Label label1;
        private Label label2;
        private Button btn_listele;
    }
}