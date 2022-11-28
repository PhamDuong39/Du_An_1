namespace GUI.View.UserControls
{
    partial class FrmQLLoaiDichVu
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
            this.btn_ThemLoaiDichVu = new System.Windows.Forms.Button();
            this.tbt_SearchServicesTypeName = new System.Windows.Forms.TextBox();
            this.dtg_DanhSachLoaiDichVu = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachLoaiDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThemLoaiDichVu
            // 
            this.btn_ThemLoaiDichVu.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemLoaiDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemLoaiDichVu.FlatAppearance.BorderSize = 0;
            this.btn_ThemLoaiDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemLoaiDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemLoaiDichVu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemLoaiDichVu.Location = new System.Drawing.Point(759, 42);
            this.btn_ThemLoaiDichVu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThemLoaiDichVu.Name = "btn_ThemLoaiDichVu";
            this.btn_ThemLoaiDichVu.Size = new System.Drawing.Size(180, 40);
            this.btn_ThemLoaiDichVu.TabIndex = 18;
            this.btn_ThemLoaiDichVu.Text = "Thêm loại dịch vụ";
            this.btn_ThemLoaiDichVu.UseVisualStyleBackColor = false;
            this.btn_ThemLoaiDichVu.Click += new System.EventHandler(this.btn_ThemLoaiDichVu_Click);
            // 
            // tbt_SearchServicesTypeName
            // 
            this.tbt_SearchServicesTypeName.Location = new System.Drawing.Point(60, 50);
            this.tbt_SearchServicesTypeName.Margin = new System.Windows.Forms.Padding(0);
            this.tbt_SearchServicesTypeName.Name = "tbt_SearchServicesTypeName";
            this.tbt_SearchServicesTypeName.PlaceholderText = "    Nhập tên loại dịch vụ cần tìm";
            this.tbt_SearchServicesTypeName.Size = new System.Drawing.Size(300, 23);
            this.tbt_SearchServicesTypeName.TabIndex = 17;
            // 
            // dtg_DanhSachLoaiDichVu
            // 
            this.dtg_DanhSachLoaiDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DanhSachLoaiDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachLoaiDichVu.Location = new System.Drawing.Point(88, 115);
            this.dtg_DanhSachLoaiDichVu.Name = "dtg_DanhSachLoaiDichVu";
            this.dtg_DanhSachLoaiDichVu.RowHeadersWidth = 51;
            this.dtg_DanhSachLoaiDichVu.RowTemplate.Height = 25;
            this.dtg_DanhSachLoaiDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DanhSachLoaiDichVu.Size = new System.Drawing.Size(807, 482);
            this.dtg_DanhSachLoaiDichVu.TabIndex = 16;
            this.dtg_DanhSachLoaiDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachLoaiDichVu_CellClick);
            this.dtg_DanhSachLoaiDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachLoaiDichVu_CellContentClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(543, 42);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(180, 40);
            this.btn_Refresh.TabIndex = 19;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // FrmQLLoaiDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_ThemLoaiDichVu);
            this.Controls.Add(this.tbt_SearchServicesTypeName);
            this.Controls.Add(this.dtg_DanhSachLoaiDichVu);
            this.Name = "FrmQLLoaiDichVu";
            this.Text = "FrmQLLoaiDichVu";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachLoaiDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ThemLoaiDichVu;
        private TextBox tbt_SearchServicesTypeName;
        private DataGridView dtg_DanhSachLoaiDichVu;
        private Button btn_Refresh;
    }
}