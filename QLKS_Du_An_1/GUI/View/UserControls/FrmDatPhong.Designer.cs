namespace GUI.View.UserControls
{
    partial class FrmDatPhong
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
            this.dtg_DanhSachPT = new System.Windows.Forms.DataGridView();
            this.tbt_SearchCusName = new System.Windows.Forms.TextBox();
            this.btn_DatPhong = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachPT)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_DanhSachPT
            // 
            this.dtg_DanhSachPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DanhSachPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DanhSachPT.Location = new System.Drawing.Point(91, 100);
            this.dtg_DanhSachPT.Name = "dtg_DanhSachPT";
            this.dtg_DanhSachPT.RowTemplate.Height = 25;
            this.dtg_DanhSachPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DanhSachPT.Size = new System.Drawing.Size(843, 482);
            this.dtg_DanhSachPT.TabIndex = 0;
            this.dtg_DanhSachPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachPT_CellClick);
            this.dtg_DanhSachPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DanhSachPT_CellContentClick);
            // 
            // tbt_SearchCusName
            // 
            this.tbt_SearchCusName.Location = new System.Drawing.Point(91, 39);
            this.tbt_SearchCusName.Margin = new System.Windows.Forms.Padding(0);
            this.tbt_SearchCusName.Name = "tbt_SearchCusName";
            this.tbt_SearchCusName.PlaceholderText = "    Tìm theo tên khách hàng";
            this.tbt_SearchCusName.Size = new System.Drawing.Size(300, 23);
            this.tbt_SearchCusName.TabIndex = 8;
            // 
            // btn_DatPhong
            // 
            this.btn_DatPhong.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_DatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DatPhong.FlatAppearance.BorderSize = 0;
            this.btn_DatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DatPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DatPhong.Location = new System.Drawing.Point(824, 31);
            this.btn_DatPhong.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.Size = new System.Drawing.Size(127, 40);
            this.btn_DatPhong.TabIndex = 9;
            this.btn_DatPhong.Text = "Đặt phòng";
            this.btn_DatPhong.UseVisualStyleBackColor = false;
            this.btn_DatPhong.Click += new System.EventHandler(this.btn_DatPhong_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(666, 31);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(127, 40);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Làm mới";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // FrmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(998, 638);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_DatPhong);
            this.Controls.Add(this.tbt_SearchCusName);
            this.Controls.Add(this.dtg_DanhSachPT);
            this.Name = "FrmDatPhong";
            this.Text = "FrmDatPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DanhSachPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtg_DanhSachPT;
        private TextBox tbt_SearchCusName;
        private Button btn_DatPhong;
        private Button btn_Refresh;
    }
}