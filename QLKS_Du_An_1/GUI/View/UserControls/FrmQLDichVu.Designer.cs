﻿namespace GUI.View.UserControls
{
    partial class FrmQLDichVu
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
            this.btn_ThemDichVu = new System.Windows.Forms.Button();
            this.tbt_SearchServicesName = new System.Windows.Forms.TextBox();
            this.dtg_DanhSachDichVu = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThemDichVu
            // 
            this.btn_ThemDichVu.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemDichVu.FlatAppearance.BorderSize = 0;
            this.btn_ThemDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemDichVu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemDichVu.Location = new System.Drawing.Point(759, 42);
            this.btn_ThemDichVu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThemDichVu.Name = "btn_ThemDichVu";
            this.btn_ThemDichVu.Size = new System.Drawing.Size(180, 40);
            this.btn_ThemDichVu.TabIndex = 18;
            this.btn_ThemDichVu.Text = "Thêm dịch vụ";
            this.btn_ThemDichVu.UseVisualStyleBackColor = false;
            this.btn_ThemDichVu.Click += new System.EventHandler(this.btn_ThemDichVu_Click);
            // 
            // tbt_SearchServicesName
            // 
            this.tbt_SearchServicesName.Location = new System.Drawing.Point(60, 50);
            this.tbt_SearchServicesName.Margin = new System.Windows.Forms.Padding(0);
            this.tbt_SearchServicesName.Name = "tbt_SearchServicesName";
            this.tbt_SearchServicesName.PlaceholderText = "    Nhập tên dịch vụ cần tìm";
            this.tbt_SearchServicesName.Size = new System.Drawing.Size(300, 23);
            this.tbt_SearchServicesName.TabIndex = 17;
            // 
            // dtg_DanhSachDichVu
            // 
            this.dtg_DanhSachDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DanhSachDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachDichVu.Location = new System.Drawing.Point(88, 115);
            this.dtg_DanhSachDichVu.Name = "dtg_DanhSachDichVu";
            this.dtg_DanhSachDichVu.RowHeadersWidth = 51;
            this.dtg_DanhSachDichVu.RowTemplate.Height = 25;
            this.dtg_DanhSachDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DanhSachDichVu.Size = new System.Drawing.Size(807, 482);
            this.dtg_DanhSachDichVu.TabIndex = 16;
            this.dtg_DanhSachDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachDichVu_CellClick);
            this.dtg_DanhSachDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachDichVu_CellContentClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(520, 42);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(180, 40);
            this.btn_Refresh.TabIndex = 19;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // FrmQLDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_ThemDichVu);
            this.Controls.Add(this.tbt_SearchServicesName);
            this.Controls.Add(this.dtg_DanhSachDichVu);
            this.Name = "FrmQLDichVu";
            this.Text = "FrmQLDichVu";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ThemDichVu;
        private TextBox tbt_SearchServicesName;
        private DataGridView dtg_DanhSachDichVu;
        private Button btn_Refresh;
    }
}