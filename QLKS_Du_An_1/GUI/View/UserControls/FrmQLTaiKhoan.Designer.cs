namespace GUI.View.UserControls
{
    partial class FrmQLTaiKhoan
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
            this.btn_ThemTaiKhoan = new System.Windows.Forms.Button();
            this.tbt_SearchAccountName = new System.Windows.Forms.TextBox();
            this.dtg_DanhSachTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThemTaiKhoan
            // 
            this.btn_ThemTaiKhoan.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btn_ThemTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemTaiKhoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemTaiKhoan.Location = new System.Drawing.Point(759, 42);
            this.btn_ThemTaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThemTaiKhoan.Name = "btn_ThemTaiKhoan";
            this.btn_ThemTaiKhoan.Size = new System.Drawing.Size(180, 40);
            this.btn_ThemTaiKhoan.TabIndex = 24;
            this.btn_ThemTaiKhoan.Text = "Thêm tài khoản";
            this.btn_ThemTaiKhoan.UseVisualStyleBackColor = false;
            this.btn_ThemTaiKhoan.Click += new System.EventHandler(this.btn_ThemTaiKhoan_Click);
            // 
            // tbt_SearchAccountName
            // 
            this.tbt_SearchAccountName.Location = new System.Drawing.Point(60, 50);
            this.tbt_SearchAccountName.Margin = new System.Windows.Forms.Padding(0);
            this.tbt_SearchAccountName.Name = "tbt_SearchAccountName";
            this.tbt_SearchAccountName.PlaceholderText = "    Tìm theo tài khoản";
            this.tbt_SearchAccountName.Size = new System.Drawing.Size(300, 23);
            this.tbt_SearchAccountName.TabIndex = 23;
            // 
            // dtg_DanhSachTaiKhoan
            // 
            this.dtg_DanhSachTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DanhSachTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachTaiKhoan.Location = new System.Drawing.Point(88, 115);
            this.dtg_DanhSachTaiKhoan.Name = "dtg_DanhSachTaiKhoan";
            this.dtg_DanhSachTaiKhoan.RowHeadersWidth = 51;
            this.dtg_DanhSachTaiKhoan.RowTemplate.Height = 25;
            this.dtg_DanhSachTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DanhSachTaiKhoan.Size = new System.Drawing.Size(807, 482);
            this.dtg_DanhSachTaiKhoan.TabIndex = 22;
            this.dtg_DanhSachTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachTaiKhoan_CellClick);
            this.dtg_DanhSachTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachTaiKhoan_CellContentClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(532, 42);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(180, 40);
            this.btn_Refresh.TabIndex = 25;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // FrmQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_ThemTaiKhoan);
            this.Controls.Add(this.tbt_SearchAccountName);
            this.Controls.Add(this.dtg_DanhSachTaiKhoan);
            this.Name = "FrmQLTaiKhoan";
            this.Text = "FrmQLTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ThemTaiKhoan;
        private TextBox tbt_SearchAccountName;
        private DataGridView dtg_DanhSachTaiKhoan;
        private Button btn_Refresh;
    }
}