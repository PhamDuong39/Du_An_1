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

namespace GUI.View.UserControls
{
    public partial class FrmHoaDon : Form
    {
        private IHoaDonService _hoaDonService;
        public FrmHoaDon()
        {
            _hoaDonService = new HoaDonService();
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            int stt = 1;
            dtg_DanhSachHoaDon.ColumnCount = 8;
            dtg_DanhSachHoaDon.Columns[0].Name = "STT";
            dtg_DanhSachHoaDon.Columns[1].Name = "ID HĐ";
            dtg_DanhSachHoaDon.Columns[2].Name = "Mã HĐ";
            dtg_DanhSachHoaDon.Columns[3].Name = "Ngày Tạo HĐ";
            dtg_DanhSachHoaDon.Columns[4].Name = "Ngày TT";
            dtg_DanhSachHoaDon.Columns[5].Name = "Tên KH";
            dtg_DanhSachHoaDon.Columns[6].Name = "Tên NV TT";
            dtg_DanhSachHoaDon.Columns[7].Name = "Mã Phòng Thuê";

            DataGridViewButtonColumn cbn_XemCTHD = new DataGridViewButtonColumn();
            cbn_XemCTHD.HeaderText = "Xem CT HĐ";
            cbn_XemCTHD.Text = "Xem Chi tiết";
            cbn_XemCTHD.Name = "btn_XemCTHD";
            cbn_XemCTHD.UseColumnTextForButtonValue = true;
            dtg_DanhSachHoaDon.Columns.Add(cbn_XemCTHD);

            dtg_DanhSachHoaDon.Columns[1].Visible = false;
            dtg_DanhSachHoaDon.Rows.Clear();
            foreach (var x in _hoaDonService.GetCTHoaDon())
            {
                dtg_DanhSachHoaDon.Rows.Add(stt++, x.Id, x.MaHD, x.NgayTaoHD, x.NgayKetThuc, x.TenKH, x.TenNV, x.MaPhong);
            }
        }

        private void tbt_SearchHDByMa_TextChanged(object sender, EventArgs e)
        {
            _hoaDonService.Search(tbt_SearchHDByMa.Text);
        }

        private void dtp_SearchHDByDay_ValueChanged(object sender, EventArgs e)
        {
            int stt = 0;
            dtg_DanhSachHoaDon.ColumnCount = 8;
            dtg_DanhSachHoaDon.Columns[0].Name = "STT";
            dtg_DanhSachHoaDon.Columns[1].Name = "ID HĐ";
            dtg_DanhSachHoaDon.Columns[2].Name = "Mã HĐ";
            dtg_DanhSachHoaDon.Columns[3].Name = "Ngày Tạo HĐ";
            dtg_DanhSachHoaDon.Columns[4].Name = "Ngày TT";
            dtg_DanhSachHoaDon.Columns[5].Name = "Tên KH";
            dtg_DanhSachHoaDon.Columns[6].Name = "Tên NV TT";
            dtg_DanhSachHoaDon.Columns[7].Name = "Mã Phòng Thuê";

            DataGridViewButtonColumn cbn_XemCTHD = new DataGridViewButtonColumn();
            cbn_XemCTHD.HeaderText = "Xem CT HĐ";
            cbn_XemCTHD.Text = "Xem Chi tiết";
            cbn_XemCTHD.Name = "btn_XemCTHD";
            cbn_XemCTHD.UseColumnTextForButtonValue = true;
            dtg_DanhSachHoaDon.Columns.Add(cbn_XemCTHD);

            dtg_DanhSachHoaDon.Columns[1].Visible = false;
            dtg_DanhSachHoaDon.Rows.Clear();
            foreach (var x in _hoaDonService.GetCTHoaDon().Where(c => c.NgayTaoHD == dtp_SearchHDByDay.Value))
            {
                dtg_DanhSachHoaDon.Rows.Add(stt++, x.Id, x.MaHD, x.NgayTaoHD, x.NgayKetThuc, x.TenKH, x.TenNV, x.MaPhong);
            }
        }
    }
}
