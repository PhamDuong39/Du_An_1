namespace GUI.View.UserControls
{
    partial class FrmHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_SearchHDByDay = new System.Windows.Forms.DateTimePicker();
            this.tbt_SearchHDByMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtg_DanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_SearchHDByDay);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(81, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 55);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn ngày";
            // 
            // dtp_SearchHDByDay
            // 
            this.dtp_SearchHDByDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_SearchHDByDay.Location = new System.Drawing.Point(6, 18);
            this.dtp_SearchHDByDay.Name = "dtp_SearchHDByDay";
            this.dtp_SearchHDByDay.Size = new System.Drawing.Size(141, 23);
            this.dtp_SearchHDByDay.TabIndex = 0;
            // 
            // tbt_SearchHDByMa
            // 
            this.tbt_SearchHDByMa.Location = new System.Drawing.Point(570, 44);
            this.tbt_SearchHDByMa.Margin = new System.Windows.Forms.Padding(0);
            this.tbt_SearchHDByMa.Name = "tbt_SearchHDByMa";
            this.tbt_SearchHDByMa.PlaceholderText = "    Tìm mã hóa đơn";
            this.tbt_SearchHDByMa.Size = new System.Drawing.Size(360, 23);
            this.tbt_SearchHDByMa.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(487, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tìm kiếm";
            // 
            // dtg_DanhSachHoaDon
            // 
            this.dtg_DanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachHoaDon.Location = new System.Drawing.Point(90, 108);
            this.dtg_DanhSachHoaDon.Name = "dtg_DanhSachHoaDon";
            this.dtg_DanhSachHoaDon.RowTemplate.Height = 25;
            this.dtg_DanhSachHoaDon.Size = new System.Drawing.Size(840, 473);
            this.dtg_DanhSachHoaDon.TabIndex = 12;
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(998, 638);
            this.Controls.Add(this.dtg_DanhSachHoaDon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbt_SearchHDByMa);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtp_SearchHDByDay;
        private TextBox tbt_SearchHDByMa;
        private Label label4;
        private DataGridView dtg_DanhSachHoaDon;
    }
}