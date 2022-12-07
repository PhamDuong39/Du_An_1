namespace GUI.View.UserControls
{
    partial class FrmQLCTTienNghi
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
            this.btn_ThemCTTienNghi = new System.Windows.Forms.Button();
            this.tbt_SearchUseDetailName = new System.Windows.Forms.TextBox();
            this.dtg_DanhSachCTTienNghi = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachCTTienNghi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ThemCTTienNghi
            // 
            this.btn_ThemCTTienNghi.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemCTTienNghi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemCTTienNghi.FlatAppearance.BorderSize = 0;
            this.btn_ThemCTTienNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemCTTienNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemCTTienNghi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemCTTienNghi.Location = new System.Drawing.Point(759, 42);
            this.btn_ThemCTTienNghi.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThemCTTienNghi.Name = "btn_ThemCTTienNghi";
            this.btn_ThemCTTienNghi.Size = new System.Drawing.Size(180, 40);
            this.btn_ThemCTTienNghi.TabIndex = 21;
            this.btn_ThemCTTienNghi.Text = "Thêm chi tiết tiện nghi";
            this.btn_ThemCTTienNghi.UseVisualStyleBackColor = false;
            this.btn_ThemCTTienNghi.Click += new System.EventHandler(this.btn_ThemCTTienNghi_Click);
            // 
            // tbt_SearchUseDetailName
            // 
            this.tbt_SearchUseDetailName.Location = new System.Drawing.Point(60, 50);
            this.tbt_SearchUseDetailName.Margin = new System.Windows.Forms.Padding(0);
            this.tbt_SearchUseDetailName.Name = "tbt_SearchUseDetailName";
            this.tbt_SearchUseDetailName.PlaceholderText = "    Nhập tên chi tiết tiện nghi cần tìm";
            this.tbt_SearchUseDetailName.Size = new System.Drawing.Size(300, 23);
            this.tbt_SearchUseDetailName.TabIndex = 20;
            this.tbt_SearchUseDetailName.TextChanged += new System.EventHandler(this.tbt_SearchUseDetailName_TextChanged);
            // 
            // dtg_DanhSachCTTienNghi
            // 
            this.dtg_DanhSachCTTienNghi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DanhSachCTTienNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachCTTienNghi.Location = new System.Drawing.Point(88, 115);
            this.dtg_DanhSachCTTienNghi.Name = "dtg_DanhSachCTTienNghi";
            this.dtg_DanhSachCTTienNghi.RowHeadersWidth = 51;
            this.dtg_DanhSachCTTienNghi.RowTemplate.Height = 25;
            this.dtg_DanhSachCTTienNghi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DanhSachCTTienNghi.Size = new System.Drawing.Size(807, 482);
            this.dtg_DanhSachCTTienNghi.TabIndex = 19;
            this.dtg_DanhSachCTTienNghi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachCTTienNghi_CellClick);
            this.dtg_DanhSachCTTienNghi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachCTTienNghi_CellContentClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(536, 42);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(180, 40);
            this.btn_Refresh.TabIndex = 22;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // FrmQLCTTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(998, 562);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_ThemCTTienNghi);
            this.Controls.Add(this.tbt_SearchUseDetailName);
            this.Controls.Add(this.dtg_DanhSachCTTienNghi);
            this.Name = "FrmQLCTTienNghi";
            this.Text = "FrmQLCTTienNghi";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachCTTienNghi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ThemCTTienNghi;
        private TextBox tbt_SearchUseDetailName;
        private DataGridView dtg_DanhSachCTTienNghi;
        private Button btn_Refresh;
    }
}