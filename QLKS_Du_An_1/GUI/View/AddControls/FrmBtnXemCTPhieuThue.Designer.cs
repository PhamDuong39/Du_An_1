﻿namespace GUI.View.AddControls
{
    partial class FrmBtnXemCTPhieuThue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_NgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.lb_TenNV = new System.Windows.Forms.Label();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.dtg_ChiTietPhieuThue = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ChiTietPhieuThue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dtp_NgayLapPhieu);
            this.panel1.Controls.Add(this.lb_TenNV);
            this.panel1.Controls.Add(this.lb_TenKH);
            this.panel1.Controls.Add(this.dtg_ChiTietPhieuThue);
            this.panel1.Location = new System.Drawing.Point(62, 104);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 443);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(585, 29);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 45);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 45);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_NgayLapPhieu
            // 
            this.dtp_NgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLapPhieu.Location = new System.Drawing.Point(306, 32);
            this.dtp_NgayLapPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_NgayLapPhieu.Name = "dtp_NgayLapPhieu";
            this.dtp_NgayLapPhieu.Size = new System.Drawing.Size(131, 27);
            this.dtp_NgayLapPhieu.TabIndex = 3;
            // 
            // lb_TenNV
            // 
            this.lb_TenNV.AutoSize = true;
            this.lb_TenNV.Location = new System.Drawing.Point(629, 40);
            this.lb_TenNV.Name = "lb_TenNV";
            this.lb_TenNV.Size = new System.Drawing.Size(102, 20);
            this.lb_TenNV.TabIndex = 2;
            this.lb_TenNV.Text = "Ten Nhân viên";
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Location = new System.Drawing.Point(87, 40);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(113, 20);
            this.lb_TenKH.TabIndex = 1;
            this.lb_TenKH.Text = "Tên Khách hàng";
            // 
            // dtg_ChiTietPhieuThue
            // 
            this.dtg_ChiTietPhieuThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_ChiTietPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ChiTietPhieuThue.Location = new System.Drawing.Point(61, 109);
            this.dtg_ChiTietPhieuThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtg_ChiTietPhieuThue.Name = "dtg_ChiTietPhieuThue";
            this.dtg_ChiTietPhieuThue.RowHeadersWidth = 51;
            this.dtg_ChiTietPhieuThue.RowTemplate.Height = 25;
            this.dtg_ChiTietPhieuThue.Size = new System.Drawing.Size(662, 300);
            this.dtg_ChiTietPhieuThue.TabIndex = 0;
            this.dtg_ChiTietPhieuThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ChiTietPhieuThue_CellClick);
            this.dtg_ChiTietPhieuThue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ChiTietPhieuThue_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(350, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 41);
            this.label1.TabIndex = 22;
            this.label1.Text = "Chi Tiết Phiếu Thuê";
            // 
            // FrmBtnXemCTPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBtnXemCTPhieuThue";
            this.Text = "FrmBtnXemCTPhieuThue";
            this.Load += new System.EventHandler(this.FrmBtnXemCTPhieuThue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ChiTietPhieuThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dtg_ChiTietPhieuThue;
        private Label lb_TenNV;
        private Label lb_TenKH;
        private DateTimePicker dtp_NgayLapPhieu;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}