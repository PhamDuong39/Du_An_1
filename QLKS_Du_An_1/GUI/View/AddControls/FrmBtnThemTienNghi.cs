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
    public partial class FrmBtnThemTienNghi : Form
    {
        private IQLChiTietTienNghiService _iqlCTTNService;
        private IQLLoaiTienNghiService _iqlLoaiTNService;
        private IQLPhongService _iqLPhongService;
     
        public FrmBtnThemTienNghi()
        {
            InitializeComponent();
            _iqlCTTNService = new QLChiTietTienNghiService();
            _iqlLoaiTNService = new QLLoaiTienNghiService();
            _iqLPhongService = new IPhongService();

            LoadDataCBB();
        }

        private void LoadDataCBB()
        {
            var lstLoaiPhong = _iqlLoaiTNService.GetAll();
            cbb_TenLoaiTienNghi.Items.Clear();
            foreach (var item in lstLoaiPhong)
            {
                cbb_TenLoaiTienNghi.Items.Add(item.TenLoaiTienNghi);
            }

            var lstMaPhong = _iqLPhongService.GetAll();
            cbb_MaPhong.Items.Clear();
            foreach (var item in lstMaPhong)
            {
                cbb_MaPhong.Items.Add(item.MaPhong);
            }

        }

        private void btn_ThemCTTienNghi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm tiện nghi này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ChiTietTienNghiView ctnv = new ChiTietTienNghiView();
                ctnv.MaCTTienNghi = tb_MaCTTNThem.Text;
                ctnv.TenCTTienNghi = tb_TenCTTNThem.Text;
                ctnv.IDLoaiTienNghi = _iqlLoaiTNService.GetIdByName(cbb_TenLoaiTienNghi.Text);

                if (cbb_MaPhong.Text=="")
                {
                    ctnv.IdPhong = null;
                }
                else
                {
                    ctnv.IdPhong = _iqlCTTNService.GetIdByRoomCode(cbb_MaPhong.Text);
                }
                
                MessageBox.Show(_iqlCTTNService.Add(ctnv));

            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy thêm tiện nghi");
            }
        }
    }
}
