﻿namespace GUI.View.UserControls
{
    partial class FrmQLKhachHang
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
            this.btn_ThemKhachHang = new System.Windows.Forms.Button();
            this.tbt_SearchCusName = new System.Windows.Forms.TextBox();
            this.dtg_DanhSachKH = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachKH)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThemKhachHang
            // 
            this.btn_ThemKhachHang.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemKhachHang.FlatAppearance.BorderSize = 0;
            this.btn_ThemKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemKhachHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemKhachHang.Location = new System.Drawing.Point(768, 44);
            this.btn_ThemKhachHang.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThemKhachHang.Name = "btn_ThemKhachHang";
            this.btn_ThemKhachHang.Size = new System.Drawing.Size(180, 40);
            this.btn_ThemKhachHang.TabIndex = 12;
            this.btn_ThemKhachHang.Text = "Thêm khách hàng";
            this.btn_ThemKhachHang.UseVisualStyleBackColor = false;
            this.btn_ThemKhachHang.Click += new System.EventHandler(this.btn_ThemKhachHang_Click);
            // 
            // tbt_SearchCusName
            // 
            this.tbt_SearchCusName.Location = new System.Drawing.Point(69, 52);
            this.tbt_SearchCusName.Margin = new System.Windows.Forms.Padding(0);
            this.tbt_SearchCusName.Name = "tbt_SearchCusName";
            this.tbt_SearchCusName.PlaceholderText = "    Nhập tên khách hàng cần tìm";
            this.tbt_SearchCusName.Size = new System.Drawing.Size(300, 23);
            this.tbt_SearchCusName.TabIndex = 11;
            // 
            // dtg_DanhSachKH
            // 
            this.dtg_DanhSachKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DanhSachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachKH.Location = new System.Drawing.Point(54, 117);
            this.dtg_DanhSachKH.Name = "dtg_DanhSachKH";
            this.dtg_DanhSachKH.RowHeadersWidth = 51;
            this.dtg_DanhSachKH.RowTemplate.Height = 25;
            this.dtg_DanhSachKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DanhSachKH.Size = new System.Drawing.Size(894, 482);
            this.dtg_DanhSachKH.TabIndex = 10;
            this.dtg_DanhSachKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachKH_CellClick);
            this.dtg_DanhSachKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachKH_CellContentClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(539, 44);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(180, 40);
            this.btn_Refresh.TabIndex = 17;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // FrmQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_ThemKhachHang);
            this.Controls.Add(this.tbt_SearchCusName);
            this.Controls.Add(this.dtg_DanhSachKH);
            this.Name = "FrmQLKhachHang";
            this.Text = "FrmQLKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ThemKhachHang;
        private TextBox tbt_SearchCusName;
        private DataGridView dtg_DanhSachKH;
        private Button btn_Refresh;
    }
}