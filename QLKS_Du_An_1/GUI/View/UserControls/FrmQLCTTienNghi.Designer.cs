﻿namespace GUI.View.UserControls
{
    partial class FrmQLCTTienNghi
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
            this.btn_ThemCTTienNghi = new System.Windows.Forms.Button();
            this.tbt_SearchUseDetailName = new System.Windows.Forms.TextBox();
            this.dtg_DanhSachCTTienNghi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachCTTienNghi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThemCTTienNghi
            // 
            this.btn_ThemCTTienNghi.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemCTTienNghi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemCTTienNghi.FlatAppearance.BorderSize = 0;
            this.btn_ThemCTTienNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemCTTienNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemCTTienNghi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemCTTienNghi.Location = new System.Drawing.Point(759, 42);
            this.btn_ThemCTTienNghi.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThemCTTienNghi.Name = "btn_ThemCTTienNghi";
            this.btn_ThemCTTienNghi.Size = new System.Drawing.Size(180, 40);
            this.btn_ThemCTTienNghi.TabIndex = 21;
            this.btn_ThemCTTienNghi.Text = "Thêm chi tiết tiện nghi";
            this.btn_ThemCTTienNghi.UseVisualStyleBackColor = false;
            // 
            // tbt_SearchUseDetailName
            // 
            this.tbt_SearchUseDetailName.Location = new System.Drawing.Point(60, 50);
            this.tbt_SearchUseDetailName.Margin = new System.Windows.Forms.Padding(0);
            this.tbt_SearchUseDetailName.Name = "tbt_SearchUseDetailName";
            this.tbt_SearchUseDetailName.PlaceholderText = "    Nhập tên chi tiết tiện nghi cần tìm";
            this.tbt_SearchUseDetailName.Size = new System.Drawing.Size(300, 23);
            this.tbt_SearchUseDetailName.TabIndex = 20;
            // 
            // dtg_DanhSachCTTienNghi
            // 
            this.dtg_DanhSachCTTienNghi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DanhSachCTTienNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachCTTienNghi.Location = new System.Drawing.Point(88, 115);
            this.dtg_DanhSachCTTienNghi.Name = "dtg_DanhSachCTTienNghi";
            this.dtg_DanhSachCTTienNghi.RowTemplate.Height = 25;
            this.dtg_DanhSachCTTienNghi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DanhSachCTTienNghi.Size = new System.Drawing.Size(807, 482);
            this.dtg_DanhSachCTTienNghi.TabIndex = 19;
            // 
            // FrmQLCTTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(998, 638);
            this.Controls.Add(this.btn_ThemCTTienNghi);
            this.Controls.Add(this.tbt_SearchUseDetailName);
            this.Controls.Add(this.dtg_DanhSachCTTienNghi);
            this.Name = "FrmQLCTTienNghi";
            this.Text = "FrmQLCTTienNghi";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachCTTienNghi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ThemCTTienNghi;
        private TextBox tbt_SearchUseDetailName;
        private DataGridView dtg_DanhSachCTTienNghi;
    }
}