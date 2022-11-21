﻿namespace GUI.View.UserControls
{
    partial class FrmQLPhong
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
            this.btn_ThemPhong = new System.Windows.Forms.Button();
            this.tbt_SearchRoomName = new System.Windows.Forms.TextBox();
            this.dtg_DanhSachPhong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThemPhong
            // 
            this.btn_ThemPhong.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemPhong.FlatAppearance.BorderSize = 0;
            this.btn_ThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemPhong.Location = new System.Drawing.Point(766, 42);
            this.btn_ThemPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThemPhong.Name = "btn_ThemPhong";
            this.btn_ThemPhong.Size = new System.Drawing.Size(180, 40);
            this.btn_ThemPhong.TabIndex = 15;
            this.btn_ThemPhong.Text = "Thêm phòng";
            this.btn_ThemPhong.UseVisualStyleBackColor = false;
            this.btn_ThemPhong.Click += new System.EventHandler(this.btn_ThemPhong_Click);
            // 
            // tbt_SearchRoomName
            // 
            this.tbt_SearchRoomName.Location = new System.Drawing.Point(67, 50);
            this.tbt_SearchRoomName.Margin = new System.Windows.Forms.Padding(0);
            this.tbt_SearchRoomName.Name = "tbt_SearchRoomName";
            this.tbt_SearchRoomName.PlaceholderText = "    Nhập số phòng cần tìm";
            this.tbt_SearchRoomName.Size = new System.Drawing.Size(300, 23);
            this.tbt_SearchRoomName.TabIndex = 14;
            this.tbt_SearchRoomName.TextChanged += new System.EventHandler(this.tbt_SearchRoomName_TextChanged);
            // 
            // dtg_DanhSachPhong
            // 
            this.dtg_DanhSachPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachPhong.Location = new System.Drawing.Point(95, 115);
            this.dtg_DanhSachPhong.Name = "dtg_DanhSachPhong";
            this.dtg_DanhSachPhong.RowHeadersWidth = 51;
            this.dtg_DanhSachPhong.RowTemplate.Height = 25;
            this.dtg_DanhSachPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DanhSachPhong.Size = new System.Drawing.Size(807, 482);
            this.dtg_DanhSachPhong.TabIndex = 13;
            this.dtg_DanhSachPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachPhong_CellClick);
            this.dtg_DanhSachPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachPhong_CellContentClick);
            // 
            // FrmQLPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.Controls.Add(this.btn_ThemPhong);
            this.Controls.Add(this.tbt_SearchRoomName);
            this.Controls.Add(this.dtg_DanhSachPhong);
            this.Name = "FrmQLPhong";
            this.Text = "FrmQLPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ThemPhong;
        private TextBox tbt_SearchRoomName;
        private DataGridView dtg_DanhSachPhong;
    }
}