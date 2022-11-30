namespace GUI.View.AddControls
{
    partial class FrmTrangThaiPhong
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
            this.btn_DatPhong = new System.Windows.Forms.Button();
            this.dtg_DSPhongTrong = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btn_HuyDatPhong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ThemDichVu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_MaPhong = new System.Windows.Forms.Label();
            this.btn_NhanPhong = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DSPhongTrong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DatPhong
            // 
            this.btn_DatPhong.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_DatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DatPhong.FlatAppearance.BorderSize = 0;
            this.btn_DatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DatPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DatPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DatPhong.Location = new System.Drawing.Point(506, 473);
            this.btn_DatPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.Size = new System.Drawing.Size(80, 30);
            this.btn_DatPhong.TabIndex = 28;
            this.btn_DatPhong.Text = "Lưu";
            this.btn_DatPhong.UseVisualStyleBackColor = false;
            // 
            // dtg_DSPhongTrong
            // 
            this.dtg_DSPhongTrong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DSPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DSPhongTrong.Location = new System.Drawing.Point(51, 177);
            this.dtg_DSPhongTrong.Name = "dtg_DSPhongTrong";
            this.dtg_DSPhongTrong.RowHeadersWidth = 51;
            this.dtg_DSPhongTrong.RowTemplate.Height = 25;
            this.dtg_DSPhongTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DSPhongTrong.Size = new System.Drawing.Size(385, 165);
            this.dtg_DSPhongTrong.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(529, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Danh sách dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(51, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Danh sách dịch vụ đã chọn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_NgayKetThuc);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(529, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 53);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngày trả";
            // 
            // dtp_NgayKetThuc
            // 
            this.dtp_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayKetThuc.Location = new System.Drawing.Point(6, 18);
            this.dtp_NgayKetThuc.Name = "dtp_NgayKetThuc";
            this.dtp_NgayKetThuc.Size = new System.Drawing.Size(221, 23);
            this.dtp_NgayKetThuc.TabIndex = 0;
            // 
            // btn_HuyDatPhong
            // 
            this.btn_HuyDatPhong.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_HuyDatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HuyDatPhong.FlatAppearance.BorderSize = 0;
            this.btn_HuyDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyDatPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HuyDatPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_HuyDatPhong.Location = new System.Drawing.Point(625, 473);
            this.btn_HuyDatPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_HuyDatPhong.Name = "btn_HuyDatPhong";
            this.btn_HuyDatPhong.Size = new System.Drawing.Size(80, 30);
            this.btn_HuyDatPhong.TabIndex = 29;
            this.btn_HuyDatPhong.Text = "Hủy";
            this.btn_HuyDatPhong.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_NgayBatDau);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(224, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 53);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngày nhận";
            // 
            // dtp_NgayBatDau
            // 
            this.dtp_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayBatDau.Location = new System.Drawing.Point(6, 18);
            this.dtp_NgayBatDau.Name = "dtp_NgayBatDau";
            this.dtp_NgayBatDau.Size = new System.Drawing.Size(206, 23);
            this.dtp_NgayBatDau.TabIndex = 0;
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TenKH.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lb_TenKH.Location = new System.Drawing.Point(51, 24);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(59, 20);
            this.lb_TenKH.TabIndex = 1;
            this.lb_TenKH.Text = "Tên KH";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtg_DSPhongTrong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lb_TenKH);
            this.panel1.Location = new System.Drawing.Point(30, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 372);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_ThemDichVu);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(529, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 165);
            this.panel2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Giá tiền";
            // 
            // btn_ThemDichVu
            // 
            this.btn_ThemDichVu.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemDichVu.FlatAppearance.BorderSize = 0;
            this.btn_ThemDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemDichVu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemDichVu.Location = new System.Drawing.Point(104, 117);
            this.btn_ThemDichVu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThemDichVu.Name = "btn_ThemDichVu";
            this.btn_ThemDichVu.Size = new System.Drawing.Size(132, 32);
            this.btn_ThemDichVu.TabIndex = 32;
            this.btn_ThemDichVu.Text = "Thêm dịch vụ";
            this.btn_ThemDichVu.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 23);
            this.textBox1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên dịch vụ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 23);
            this.comboBox1.TabIndex = 34;
            // 
            // lb_MaPhong
            // 
            this.lb_MaPhong.AutoSize = true;
            this.lb_MaPhong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_MaPhong.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lb_MaPhong.Location = new System.Drawing.Point(358, 24);
            this.lb_MaPhong.Name = "lb_MaPhong";
            this.lb_MaPhong.Size = new System.Drawing.Size(138, 32);
            this.lb_MaPhong.TabIndex = 26;
            this.lb_MaPhong.Text = "Mã phòng ";
            // 
            // btn_NhanPhong
            // 
            this.btn_NhanPhong.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_NhanPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NhanPhong.FlatAppearance.BorderSize = 0;
            this.btn_NhanPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhanPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NhanPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NhanPhong.Location = new System.Drawing.Point(342, 473);
            this.btn_NhanPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_NhanPhong.Name = "btn_NhanPhong";
            this.btn_NhanPhong.Size = new System.Drawing.Size(132, 30);
            this.btn_NhanPhong.TabIndex = 30;
            this.btn_NhanPhong.Text = "Nhận phòng";
            this.btn_NhanPhong.UseVisualStyleBackColor = false;
            this.btn_NhanPhong.Click += new System.EventHandler(this.btn_NhanPhong_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThanhToan.FlatAppearance.BorderSize = 0;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThanhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThanhToan.Location = new System.Drawing.Point(741, 473);
            this.btn_ThanhToan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(132, 30);
            this.btn_ThanhToan.TabIndex = 31;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // FrmTrangThaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 537);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_NhanPhong);
            this.Controls.Add(this.btn_DatPhong);
            this.Controls.Add(this.btn_HuyDatPhong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_MaPhong);
            this.Name = "FrmTrangThaiPhong";
            this.Text = "FrmTrangThaiPhong";
            this.Load += new System.EventHandler(this.FrmTrangThaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DSPhongTrong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_DatPhong;
        private DataGridView dtg_DSPhongTrong;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private DateTimePicker dtp_NgayKetThuc;
        private Button btn_HuyDatPhong;
        private GroupBox groupBox1;
        private DateTimePicker dtp_NgayBatDau;
        private Label lb_TenKH;
        private Panel panel1;
        private Label lb_MaPhong;
        private Button btn_NhanPhong;
        private Button btn_ThanhToan;
        private Button btn_ThemDichVu;
        private Panel panel2;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
    }
}