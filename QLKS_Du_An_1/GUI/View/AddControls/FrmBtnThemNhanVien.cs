﻿using BUS.IServices;
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
    public partial class FrmBtnThemNhanVien : Form
    {
        IQLNhanVienServices _iqLNhanVien;
        IChucVuService _iqLChucVu;

        public FrmBtnThemNhanVien()
        {
            InitializeComponent();
            _iqLNhanVien = new QLNhanVienServices();
            _iqLChucVu= new ChucVuService();
            loadcbo();
        }
        public void loadcbo()
        {
            foreach( var item in _iqLChucVu.GetAll())
            {
                cbo_chucvuNV.Items.Add(item.TenCV);
            }
            cbo_gioitinhNV.Items.Add("Nam");
            cbo_gioitinhNV.Items.Add("Nữ");
            cbo_gioitinhNV.Items.Add("Khác");
        }
        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm nhân viên này không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                
                NhanVienView nhanVienView = new NhanVienView();

                nhanVienView.ID =Guid.NewGuid();
                nhanVienView.MaNV= txt_maNV.Text;
                nhanVienView.TenNV = txt_tenNV.Text;
                nhanVienView.CCCD = txt_cccdNV.Text;
                nhanVienView.NgaySinh = DateTime.Parse(dte_ngaysinhNV.Text);
                nhanVienView.GioiTinh = (cbo_gioitinhNV.Text == "Nam") ? 1 : (cbo_gioitinhNV.Text == "Nữ") ? 2 : 3;
                nhanVienView.SDT=txt_sdtNV.Text;
                nhanVienView.DiaChi=txt_diachiNV.Text;
                nhanVienView.Luong = int.Parse(txt_luongNV.Text);
                nhanVienView.IDCv = _iqLChucVu.GetAll().FirstOrDefault(c => c.TenCV == cbo_chucvuNV.Text).ID;
                nhanVienView.TenCV=cbo_chucvuNV.Text;
                MessageBox.Show(_iqLNhanVien.Add(nhanVienView));
                
            }
        }
    }
}
