using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
using DAL.Models;
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
    public partial class FrmBtnSuaKH : Form
    {
        private IQLKhachHangService _iQLKhachHangService;

        public Guid IdKH { get; set; }
        public string MaKH { get; set; }
        public string HoTenKH { get; set; }
        public string CCCDKH { get; set; }
        public string SDTKH { get; set; }
        public string DiaChiKH { get; set; }
        public string GioiTinhKH { get; set; }
        public string QuocTich { get; set; }
        public FrmBtnSuaKH()
        {
            InitializeComponent();
            _iQLKhachHangService = new QLKhachHangService();
        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có chắc chắn sửa khách hàng này không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                KhachHangView khN = new KhachHangView();
                khN.ID = IdKH;
                khN.MaKH = tbt_MaKh.Text;
                khN.HovaTen = tbt_HoTenKH.Text;
                khN.CCCD = tbt_CCCD.Text;
                khN.SDT = tbt_SDTKh.Text;
                khN.GioiTinh = cbb_GioiTinh.Text == "Nam" ? 1 : cbb_GioiTinh.Text == "Nữ" ? 2 : 3;
                khN.QuocTich = tbt_QuocTichKH.Text;
                khN.DiaChi = tbt_DiaChiKH.Text;
                MessageBox.Show(_iQLKhachHangService.Update(khN));
            }
            else
            {
                MessageBox.Show("Bạn đã hủy sửa khách hàng này");
            }
        }

        private void FrmBtnSuaKH_Load(object sender, EventArgs e)
        {
            tbt_MaKh.Text = MaKH;
            tbt_HoTenKH.Text = HoTenKH;
            tbt_CCCD.Text = CCCDKH;
            tbt_SDTKh.Text = SDTKH;
            tbt_DiaChiKH.Text = DiaChiKH;
            cbb_GioiTinh.Text = GioiTinhKH;
            tbt_QuocTichKH.Text = QuocTich;
        }
    }
}
