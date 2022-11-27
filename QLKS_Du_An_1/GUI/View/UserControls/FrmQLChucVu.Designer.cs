namespace GUI.View.UserControls
{
    partial class FrmQLChucVu
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
            this.btn_ThemChucVu = new System.Windows.Forms.Button();
            this.tbt_SearchRoleName = new System.Windows.Forms.TextBox();
            this.dtg_DanhSachChucVu = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThemChucVu
            // 
            this.btn_ThemChucVu.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemChucVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemChucVu.FlatAppearance.BorderSize = 0;
            this.btn_ThemChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemChucVu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemChucVu.Location = new System.Drawing.Point(753, 16);
            this.btn_ThemChucVu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThemChucVu.Name = "btn_ThemChucVu";
            this.btn_ThemChucVu.Size = new System.Drawing.Size(180, 40);
            this.btn_ThemChucVu.TabIndex = 30;
            this.btn_ThemChucVu.Text = "Thêm chức vụ";
            this.btn_ThemChucVu.UseVisualStyleBackColor = false;
            this.btn_ThemChucVu.Click += new System.EventHandler(this.btn_ThemChucVu_Click);
            // 
            // tbt_SearchRoleName
            // 
            this.tbt_SearchRoleName.Location = new System.Drawing.Point(54, 24);
            this.tbt_SearchRoleName.Margin = new System.Windows.Forms.Padding(0);
            this.tbt_SearchRoleName.Name = "tbt_SearchRoleName";
            this.tbt_SearchRoleName.PlaceholderText = "    Tìm theo tên chức vụ";
            this.tbt_SearchRoleName.Size = new System.Drawing.Size(300, 23);
            this.tbt_SearchRoleName.TabIndex = 29;
            this.tbt_SearchRoleName.TextChanged += new System.EventHandler(this.tbt_SearchRoleName_TextChanged);
            // 
            // dtg_DanhSachChucVu
            // 
            this.dtg_DanhSachChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DanhSachChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachChucVu.Location = new System.Drawing.Point(82, 89);
            this.dtg_DanhSachChucVu.Name = "dtg_DanhSachChucVu";
            this.dtg_DanhSachChucVu.RowHeadersWidth = 51;
            this.dtg_DanhSachChucVu.RowTemplate.Height = 25;
            this.dtg_DanhSachChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DanhSachChucVu.Size = new System.Drawing.Size(807, 482);
            this.dtg_DanhSachChucVu.TabIndex = 28;
            this.dtg_DanhSachChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachChucVu_CellClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(539, 16);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(180, 40);
            this.btn_Refresh.TabIndex = 31;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // FrmQLChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_ThemChucVu);
            this.Controls.Add(this.tbt_SearchRoleName);
            this.Controls.Add(this.dtg_DanhSachChucVu);
            this.Name = "FrmQLChucVu";
            this.Text = "FrmQLChucVu";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ThemChucVu;
        private TextBox tbt_SearchRoleName;
        private DataGridView dtg_DanhSachChucVu;
        private Button btn_Refresh;
    }
}