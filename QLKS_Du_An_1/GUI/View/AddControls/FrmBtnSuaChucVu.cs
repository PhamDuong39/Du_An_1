﻿using System;
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
using BUS.ViewModels;

namespace GUI.View.AddControls
{
    public partial class FrmBtnSuaChucVu : Form
    {
        public ChucVuView _cvView;
        private IChucVuService _chucVuService;
        public FrmBtnSuaChucVu()
        {
            _chucVuService = new ChucVuService();
            _cvView = new ChucVuView();
            InitializeComponent();
            
        }
        private void LoadData()
        {
            tb_MaChucVuSua.Text = _cvView.MaCV;
            tb_tenChucVuSua.Text = _cvView.TenCV;
        }
        private ChucVuView GetData()
        {
            return new ChucVuView()
            {
                ID = _cvView.ID,
                MaCV = tb_MaChucVuSua.Text,
                TenCV = tb_tenChucVuSua.Text
            };
        }
        private void btn_SuaChucVu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) MessageBox.Show(_chucVuService.Update(GetData()));
            if (result == DialogResult.No) MessageBox.Show("Canncel");
        }

        private void btn_HuySuaChucVu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBtnSuaChucVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
