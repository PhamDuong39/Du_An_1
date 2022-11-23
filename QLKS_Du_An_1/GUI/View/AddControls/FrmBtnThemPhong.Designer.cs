namespace GUI.View.AddControls
{
    partial class FrmBtnThemPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbb_TinhTrangPhong = new System.Windows.Forms.ComboBox();
            this.cbb_TenLoaiPhong = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_MaPhongThem = new System.Windows.Forms.TextBox();
            this.btn_HuyThemPhong = new System.Windows.Forms.Button();
            this.btn_ThemPhong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(117, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nhập thông tin phòng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.cbb_TinhTrangPhong);
            this.panel1.Controls.Add(this.cbb_TenLoaiPhong);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tb_MaPhongThem);
            this.panel1.Location = new System.Drawing.Point(86, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 269);
            this.panel1.TabIndex = 28;
            // 
            // cbb_TinhTrangPhong
            // 
            this.cbb_TinhTrangPhong.FormattingEnabled = true;
            this.cbb_TinhTrangPhong.Location = new System.Drawing.Point(107, 172);
            this.cbb_TinhTrangPhong.Name = "cbb_TinhTrangPhong";
            this.cbb_TinhTrangPhong.Size = new System.Drawing.Size(191, 23);
            this.cbb_TinhTrangPhong.TabIndex = 28;
            // 
            // cbb_TenLoaiPhong
            // 
            this.cbb_TenLoaiPhong.FormattingEnabled = true;
            this.cbb_TenLoaiPhong.Items.AddRange(new object[] {
            "--Chọn loại phòng--"});
            this.cbb_TenLoaiPhong.Location = new System.Drawing.Point(109, 97);
            this.cbb_TenLoaiPhong.Name = "cbb_TenLoaiPhong";
            this.cbb_TenLoaiPhong.Size = new System.Drawing.Size(191, 23);
            this.cbb_TenLoaiPhong.TabIndex = 27;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GUI.Properties.Resources._007_user_1;
            this.pictureBox4.Location = new System.Drawing.Point(62, 171);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources._007_user_1;
            this.pictureBox3.Location = new System.Drawing.Point(62, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources._007_user_1;
            this.pictureBox1.Location = new System.Drawing.Point(62, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // tb_MaPhongThem
            // 
            this.tb_MaPhongThem.Location = new System.Drawing.Point(107, 20);
            this.tb_MaPhongThem.Name = "tb_MaPhongThem";
            this.tb_MaPhongThem.PlaceholderText = "Nhập mã phòng";
            this.tb_MaPhongThem.Size = new System.Drawing.Size(191, 23);
            this.tb_MaPhongThem.TabIndex = 17;
            // 
            // btn_HuyThemPhong
            // 
            this.btn_HuyThemPhong.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_HuyThemPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HuyThemPhong.FlatAppearance.BorderSize = 0;
            this.btn_HuyThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyThemPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HuyThemPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_HuyThemPhong.Location = new System.Drawing.Point(363, 405);
            this.btn_HuyThemPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_HuyThemPhong.Name = "btn_HuyThemPhong";
            this.btn_HuyThemPhong.Size = new System.Drawing.Size(96, 30);
            this.btn_HuyThemPhong.TabIndex = 31;
            this.btn_HuyThemPhong.Text = "Hủy";
            this.btn_HuyThemPhong.UseVisualStyleBackColor = false;
            // 
            // btn_ThemPhong
            // 
            this.btn_ThemPhong.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemPhong.FlatAppearance.BorderSize = 0;
            this.btn_ThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemPhong.Location = new System.Drawing.Point(235, 405);
            this.btn_ThemPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThemPhong.Name = "btn_ThemPhong";
            this.btn_ThemPhong.Size = new System.Drawing.Size(96, 30);
            this.btn_ThemPhong.TabIndex = 30;
            this.btn_ThemPhong.Text = "Thêm";
            this.btn_ThemPhong.UseVisualStyleBackColor = false;
            this.btn_ThemPhong.Click += new System.EventHandler(this.btn_ThemPhong_Click);
            // 
            // FrmBtnThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_HuyThemPhong);
            this.Controls.Add(this.btn_ThemPhong);
            this.Name = "FrmBtnThemPhong";
            this.Text = "FrmBtnThemPhong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private TextBox tb_MaPhongThem;
        private Button btn_HuyThemPhong;
        private Button btn_ThemPhong;
        private ComboBox cbb_TenLoaiPhong;
        private ComboBox cbb_TinhTrangPhong;
    }
}