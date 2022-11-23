using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.View.AddControls
{

    public partial class FrmBtnSuaTaiKhoan : Form
    {
        IQLTaiKhoanServices _iqLTaiKhoan;
        IQLNhanVienServices _iqLNhanVien;
        public Guid ID ;
        public string TenTaiKhoan ;
        public string MatKhau ;
        public int CapDoQuyen ;
        public Guid? IDNv ;
        public string? TenNV;
        public FrmBtnSuaTaiKhoan()
        {
            InitializeComponent();
            _iqLNhanVien = new QLNhanVienServices();
            _iqLTaiKhoan = new QLTaiKhoanServices();
            txt_maNV.Enabled= false;
            txt_tenTK.Enabled= false;
        }

        private void FrmBtnSuaTaiKhoan_Load(object sender, EventArgs e)
        {

            txt_maNV.Text = _iqLNhanVien.GetAll().FirstOrDefault(c=>c.ID==IDNv).MaNV.ToString();
            txt_tenTK.Text = TenTaiKhoan;
            cbb_capdoquyenTK.Text=CapDoQuyen.ToString();
            txt_matkhaucuTK.Text=MatKhau.ToString();
        }

        private void btn_ThemTaiKhoan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật nhân viên này không", "Thông Báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TaiKhoanView taiKhoanView = new TaiKhoanView();
                taiKhoanView.ID = ID;
                taiKhoanView.IDNv= IDNv;
                taiKhoanView.MatKhau= txt_matkhaucuTK.Text;
                taiKhoanView.CapDoQuyen = int.Parse(cbb_capdoquyenTK.Text);
                taiKhoanView.TenNV = TenNV;
                taiKhoanView.TenTaiKhoan = txt_tenTK.Text;
                MessageBox.Show(_iqLTaiKhoan.Update(taiKhoanView));
                
            }
        }

        private void btn_HuyDichVu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
