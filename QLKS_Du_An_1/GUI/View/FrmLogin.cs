using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.IServices;
using BUS.Services;

namespace GUI.View
{
    public partial class FrmLogin : Form
    {
        private IQLTaiKhoanServices _iqLTaiKhoanServices;
        public FrmLogin()
        {
            InitializeComponent();
            _iqLTaiKhoanServices = new QLTaiKhoanServices();
        }

        private void Bt_Dangnhap_Click(object sender, EventArgs e)
        {
            if(_iqLTaiKhoanServices.GetAll().Where(p => p.TenTaiKhoan == Tb_Taikhoan.Text && p.MatKhau == Tb_Matkhau.Text && p.CapDoQuyen == 0) != null)
            {
                MessageBox.Show("Chào mừng admin");
            }
            else if(_iqLTaiKhoanServices.GetAll().Where(p => p.TenTaiKhoan == Tb_Taikhoan.Text && p.MatKhau == Tb_Matkhau.Text && p.CapDoQuyen == 1) != null)
            {
                MessageBox.Show("Chào mừng quản lý");
            }
            else if (_iqLTaiKhoanServices.GetAll().Where(p => p.TenTaiKhoan == Tb_Taikhoan.Text && p.MatKhau == Tb_Matkhau.Text && p.CapDoQuyen == 2) != null)
            {
                MessageBox.Show("Chào mừng nhân viên");
            }
            else if (_iqLTaiKhoanServices.GetAll().Where(p => p.TenTaiKhoan == Tb_Taikhoan.Text && p.MatKhau == Tb_Matkhau.Text) == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
        }
    }
}
