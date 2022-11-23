namespace GUI.View
{
    partial class FrmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_Taikhoan = new System.Windows.Forms.TextBox();
            this.Tb_Matkhau = new System.Windows.Forms.TextBox();
            this.Bt_Dangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // Tb_Taikhoan
            // 
            this.Tb_Taikhoan.Location = new System.Drawing.Point(490, 123);
            this.Tb_Taikhoan.Name = "Tb_Taikhoan";
            this.Tb_Taikhoan.Size = new System.Drawing.Size(196, 23);
            this.Tb_Taikhoan.TabIndex = 2;
            // 
            // Tb_Matkhau
            // 
            this.Tb_Matkhau.Location = new System.Drawing.Point(490, 187);
            this.Tb_Matkhau.Name = "Tb_Matkhau";
            this.Tb_Matkhau.Size = new System.Drawing.Size(196, 23);
            this.Tb_Matkhau.TabIndex = 3;
            // 
            // Bt_Dangnhap
            // 
            this.Bt_Dangnhap.Location = new System.Drawing.Point(518, 261);
            this.Bt_Dangnhap.Name = "Bt_Dangnhap";
            this.Bt_Dangnhap.Size = new System.Drawing.Size(117, 42);
            this.Bt_Dangnhap.TabIndex = 4;
            this.Bt_Dangnhap.Text = "Đăng nhập";
            this.Bt_Dangnhap.UseVisualStyleBackColor = true;
            this.Bt_Dangnhap.Click += new System.EventHandler(this.Bt_Dangnhap_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bt_Dangnhap);
            this.Controls.Add(this.Tb_Matkhau);
            this.Controls.Add(this.Tb_Taikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Tb_Taikhoan;
        private TextBox Tb_Matkhau;
        private Button Bt_Dangnhap;
    }
}