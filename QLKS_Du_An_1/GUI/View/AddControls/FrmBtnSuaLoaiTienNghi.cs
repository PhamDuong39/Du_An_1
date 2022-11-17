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
using BUS.ViewModels;
using GUI.View.UserControls;
namespace GUI.View.AddControls
{
    public partial class FrmBtnSuaLoaiTienNghi : Form
    {
        private IQLLoaiTienNghiService _iqlLoaiTienNghi;
        private IQLChiTietTienNghiService iqlChiTietTienNghiService;
        public Guid IdLoaiTiennghi { get; set; }

        public string MaLoaiTienNghi { get; set; }
        public string TenLoaiTienNghi { get; set; }
        public FrmBtnSuaLoaiTienNghi()
        {
            InitializeComponent();
            _iqlLoaiTienNghi = new QLLoaiTienNghiService();
            iqlChiTietTienNghiService = new QLChiTietTienNghiService();
        }

        private void btn_SuaLoaiTienNghi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn sửa tiện nghi này không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoaiTienNghiView ltn = new LoaiTienNghiView();
                ltn.ID = IdLoaiTiennghi;
                ltn.MaLoaiTienNghi = tb_maLoaiTienNghi.Text;

                // 0 = Phòng trống, 1= Phòng có khách , 2 = Phòng đang dọn dẹp
                ltn.TenLoaiTienNghi = tb_tenLoaiTienNghi.Text;
                MessageBox.Show(_iqlLoaiTienNghi.Update(ltn)); 
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy sửa phòng");
            }
        }

        private void FrmBtnSuaLoaiTienNghi_Load(object sender, EventArgs e)
        {
            tb_maLoaiTienNghi.Text = MaLoaiTienNghi;
            tb_tenLoaiTienNghi.Text = TenLoaiTienNghi;
        }
    }
}
