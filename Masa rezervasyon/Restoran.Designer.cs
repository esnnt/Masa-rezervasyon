namespace Masa_rezervasyon
{
    partial class Restoran
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            res1 = new Button();
            res2 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // res1
            // 
            res1.Location = new Point(19, 54);
            res1.Name = "res1";
            res1.Size = new Size(186, 104);
            res1.TabIndex = 0;
            res1.Text = "Restoran A";
            res1.UseVisualStyleBackColor = true;
            res1.Click += res1_Click;
            // 
            // res2
            // 
            res2.Location = new Point(241, 54);
            res2.Name = "res2";
            res2.Size = new Size(191, 108);
            res2.TabIndex = 1;
            res2.Text = "Restoran B";
            res2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(res1);
            groupBox1.Controls.Add(res2);
            groupBox1.Location = new Point(112, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(653, 441);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Restoran seçimi";
            // 
            // Restoran
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 479);
            Controls.Add(groupBox1);
            Name = "Restoran";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button res1;
        private Button res2;
        private GroupBox groupBox1;
    }
}
