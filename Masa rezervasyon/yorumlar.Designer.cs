namespace Masa_rezervasyon
{
    partial class yorumlar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            datagridYorum = new DataGridView();
            btn_geri = new Button();
            ((System.ComponentModel.ISupportInitialize)datagridYorum).BeginInit();
            SuspendLayout();
            // 
            // datagridYorum
            // 
            datagridYorum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridYorum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagridYorum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            datagridYorum.DefaultCellStyle = dataGridViewCellStyle1;
            datagridYorum.Location = new Point(12, 12);
            datagridYorum.Name = "datagridYorum";
            datagridYorum.RowHeadersWidth = 51;
            datagridYorum.Size = new Size(871, 413);
            datagridYorum.TabIndex = 0;
           
            // 
            // btn_geri
            // 
            btn_geri.Location = new Point(12, 431);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(94, 29);
            btn_geri.TabIndex = 1;
            btn_geri.Text = "Geri";
            btn_geri.UseVisualStyleBackColor = true;
            btn_geri.Click += btn_geri_Click;
            // 
            // yorumlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 504);
            Controls.Add(btn_geri);
            Controls.Add(datagridYorum);
            Name = "yorumlar";
            Text = "yorumlar";
            Load += yorumlar_Load;
            ((System.ComponentModel.ISupportInitialize)datagridYorum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView datagridYorum;
        private Button btn_geri;
    }
}