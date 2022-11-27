namespace GUI.View.UserControls
{
    partial class ListItemRooms
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_MaPhong = new System.Windows.Forms.Label();
            this.lb_TTPhongThue = new System.Windows.Forms.Label();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.lb_DonDep = new System.Windows.Forms.Label();
            this.lb_TenLoaiPhong = new System.Windows.Forms.Label();
            this.lb_IdRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_MaPhong
            // 
            this.lb_MaPhong.AutoSize = true;
            this.lb_MaPhong.Location = new System.Drawing.Point(3, 9);
            this.lb_MaPhong.Name = "lb_MaPhong";
            this.lb_MaPhong.Size = new System.Drawing.Size(62, 15);
            this.lb_MaPhong.TabIndex = 0;
            this.lb_MaPhong.Text = "Mã phòng";
            // 
            // lb_TTPhongThue
            // 
            this.lb_TTPhongThue.AutoSize = true;
            this.lb_TTPhongThue.Location = new System.Drawing.Point(3, 67);
            this.lb_TTPhongThue.Name = "lb_TTPhongThue";
            this.lb_TTPhongThue.Size = new System.Drawing.Size(84, 15);
            this.lb_TTPhongThue.TabIndex = 1;
            this.lb_TTPhongThue.Text = "TT Phong thue";
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.AutoSize = true;
            this.lb_TenKH.Location = new System.Drawing.Point(140, 39);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(44, 15);
            this.lb_TenKH.TabIndex = 2;
            this.lb_TenKH.Text = "Ten KH";
            // 
            // lb_DonDep
            // 
            this.lb_DonDep.AutoSize = true;
            this.lb_DonDep.Location = new System.Drawing.Point(117, 67);
            this.lb_DonDep.Name = "lb_DonDep";
            this.lb_DonDep.Size = new System.Drawing.Size(67, 15);
            this.lb_DonDep.TabIndex = 5;
            this.lb_DonDep.Text = "TT Don dep";
            // 
            // lb_TenLoaiPhong
            // 
            this.lb_TenLoaiPhong.AutoSize = true;
            this.lb_TenLoaiPhong.Location = new System.Drawing.Point(99, 9);
            this.lb_TenLoaiPhong.Name = "lb_TenLoaiPhong";
            this.lb_TenLoaiPhong.Size = new System.Drawing.Size(85, 15);
            this.lb_TenLoaiPhong.TabIndex = 6;
            this.lb_TenLoaiPhong.Text = "Ten loại phòng";
            // 
            // lb_IdRoom
            // 
            this.lb_IdRoom.AutoSize = true;
            this.lb_IdRoom.Location = new System.Drawing.Point(3, 39);
            this.lb_IdRoom.Name = "lb_IdRoom";
            this.lb_IdRoom.Size = new System.Drawing.Size(17, 15);
            this.lb_IdRoom.TabIndex = 7;
            this.lb_IdRoom.Text = "Id";
            // 
            // ListItemRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.lb_IdRoom);
            this.Controls.Add(this.lb_TenLoaiPhong);
            this.Controls.Add(this.lb_DonDep);
            this.Controls.Add(this.lb_TenKH);
            this.Controls.Add(this.lb_TTPhongThue);
            this.Controls.Add(this.lb_MaPhong);
            this.Name = "ListItemRooms";
            this.Size = new System.Drawing.Size(192, 94);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_MaPhong;
        private Label lb_TTPhongThue;
        private Label lb_TenKH;
        private Label lb_DonDep;
        private Label lb_TenLoaiPhong;
        private Label lb_IdRoom;
    }
}
