﻿namespace GUI.View.UserControls
{
    partial class FrmQLLoaiPhong
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
            this.btn_ThemLoaiPhong = new System.Windows.Forms.Button();
            this.tbt_SearchRoomTypeName = new System.Windows.Forms.TextBox();
            this.dtg_DanhSachLoaiPhong = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThemLoaiPhong
            // 
            this.btn_ThemLoaiPhong.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemLoaiPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemLoaiPhong.FlatAppearance.BorderSize = 0;
            this.btn_ThemLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemLoaiPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemLoaiPhong.Location = new System.Drawing.Point(759, 42);
            this.btn_ThemLoaiPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThemLoaiPhong.Name = "btn_ThemLoaiPhong";
            this.btn_ThemLoaiPhong.Size = new System.Drawing.Size(180, 40);
            this.btn_ThemLoaiPhong.TabIndex = 27;
            this.btn_ThemLoaiPhong.Text = "Thêm loại phòng";
            this.btn_ThemLoaiPhong.UseVisualStyleBackColor = false;
            this.btn_ThemLoaiPhong.Click += new System.EventHandler(this.btn_ThemLoaiPhong_Click);
            // 
            // tbt_SearchRoomTypeName
            // 
            this.tbt_SearchRoomTypeName.Location = new System.Drawing.Point(60, 50);
            this.tbt_SearchRoomTypeName.Margin = new System.Windows.Forms.Padding(0);
            this.tbt_SearchRoomTypeName.Name = "tbt_SearchRoomTypeName";
            this.tbt_SearchRoomTypeName.PlaceholderText = "    Tìm theo loại phòng";
            this.tbt_SearchRoomTypeName.Size = new System.Drawing.Size(300, 23);
            this.tbt_SearchRoomTypeName.TabIndex = 26;
            // 
            // dtg_DanhSachLoaiPhong
            // 
            this.dtg_DanhSachLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DanhSachLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachLoaiPhong.Location = new System.Drawing.Point(88, 115);
            this.dtg_DanhSachLoaiPhong.Name = "dtg_DanhSachLoaiPhong";
            this.dtg_DanhSachLoaiPhong.RowHeadersWidth = 51;
            this.dtg_DanhSachLoaiPhong.RowTemplate.Height = 25;
            this.dtg_DanhSachLoaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DanhSachLoaiPhong.Size = new System.Drawing.Size(807, 482);
            this.dtg_DanhSachLoaiPhong.TabIndex = 25;
            this.dtg_DanhSachLoaiPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachLoaiPhong_CellClick);
            this.dtg_DanhSachLoaiPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachLoaiPhong_CellContentClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(548, 42);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(180, 40);
            this.btn_Refresh.TabIndex = 28;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // FrmQLLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_ThemLoaiPhong);
            this.Controls.Add(this.tbt_SearchRoomTypeName);
            this.Controls.Add(this.dtg_DanhSachLoaiPhong);
            this.Name = "FrmQLLoaiPhong";
            this.Text = "FrmQLLoaiPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachLoaiPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ThemLoaiPhong;
        private TextBox tbt_SearchRoomTypeName;
        private DataGridView dtg_DanhSachLoaiPhong;
        private Button btn_Refresh;
    }
}