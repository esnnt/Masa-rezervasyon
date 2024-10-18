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
            listView1 = new ListView();
            listView2 = new ListView();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(345, 35);
            listView1.Name = "listView1";
            listView1.Size = new Size(255, 432);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(622, 35);
            listView2.Name = "listView2";
            listView2.Size = new Size(261, 432);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
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
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(622, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(678, 9);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // button2
            // 
            button2.Location = new Point(811, 5);
            button2.Name = "button2";
            button2.Size = new Size(72, 24);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 5);
            button3.Name = "button3";
            button3.Size = new Size(90, 28);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // odeme
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 479);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Name = "odeme";
            Text = "odeme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ListView listView2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
    }
}