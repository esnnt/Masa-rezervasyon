﻿namespace Masa_rezervasyon
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
            datagridgecmisyorum = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)datagridYorum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagridgecmisyorum).BeginInit();
            SuspendLayout();
            // 
            // datagridYorum
            // 
            datagridYorum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            datagridYorum.Location = new Point(12, 31);
            datagridYorum.Name = "datagridYorum";
            datagridYorum.ReadOnly = true;
            datagridYorum.RowHeadersWidth = 51;
            datagridYorum.Size = new Size(844, 189);
            datagridYorum.TabIndex = 0;
            datagridYorum.CellContentClick += datagridYorum_CellContentClick;
            // 
            // btn_geri
            // 
            btn_geri.Location = new Point(12, 463);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(94, 29);
            btn_geri.TabIndex = 1;
            btn_geri.Text = "Geri";
            btn_geri.UseVisualStyleBackColor = true;
            btn_geri.Click += btn_geri_Click;
            // 
            // datagridgecmisyorum
            // 
            datagridgecmisyorum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridgecmisyorum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagridgecmisyorum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridgecmisyorum.Location = new Point(12, 265);
            datagridgecmisyorum.Name = "datagridgecmisyorum";
            datagridgecmisyorum.ReadOnly = true;
            datagridgecmisyorum.RowHeadersWidth = 51;
            datagridgecmisyorum.Size = new Size(844, 192);
            datagridgecmisyorum.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 3;
            label1.Text = "Genel Yorumlar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 242);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 4;
            label2.Text = "Id Yorumları";
            // 
            // yorumlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 504);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datagridgecmisyorum);
            Controls.Add(btn_geri);
            Controls.Add(datagridYorum);
            Name = "yorumlar";
            Text = "yorumlar";
            Load += yorumlar_Load;
            ((System.ComponentModel.ISupportInitialize)datagridYorum).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagridgecmisyorum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView datagridYorum;
        private Button btn_geri;
        private DataGridView datagridgecmisyorum;
        private Label label1;
        private Label label2;
    }
}