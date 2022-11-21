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
    public partial class FrmBtnSuaLoaiPhong : Form
    {
        private IQLLoaiPhongService _iqlLoaiPhongService;
        public Guid IDLoaiPhongSua { get; set; }
        public string MaLoaiPhongSua { get; set; }
        public string TenLoaiPhongSua { get; set; }
        public int SoGiuongLoaiPhongSua { get; set; }
        public int GiaNgayLoaiPhongSua { get; set; }
        public FrmBtnSuaLoaiPhong()
        {
            InitializeComponent();
            _iqlLoaiPhongService = new ILoaiPhongService();
        }

        private void btn_SuaLoaiPhong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn sửa loại phòng này không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoaiPhongView lpv = new LoaiPhongView();
                lpv.ID = IDLoaiPhongSua;
                lpv.MaLoaiPhong = tb_MaLoaiPhong.Text;
                lpv.TenLoaiPhong = tb_TenLoaiPhong.Text;
                lpv.SoGiuong = int.Parse(tb_SoGiuong.Text);
                lpv.GiaNgay = int.Parse(tb_GiaNgay.Text);
                MessageBox.Show(_iqlLoaiPhongService.Update(lpv));
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy sửa loại phòng");
            }
        }

        private void FrmBtnSuaLoaiPhong_Load(object sender, EventArgs e)
        {
            tb_MaLoaiPhong.Text = MaLoaiPhongSua;
            tb_TenLoaiPhong.Text = TenLoaiPhongSua;
            tb_SoGiuong.Text = Convert.ToString(SoGiuongLoaiPhongSua);
            tb_GiaNgay.Text = Convert.ToString(GiaNgayLoaiPhongSua);
        }
    }
}
