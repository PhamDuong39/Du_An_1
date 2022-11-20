using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
using GUI.View.AddControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.View.UserControls
{
    public partial class FrmQLKhachHang : Form
    {
        private IQLKhachHangService _iQLKhachHangService;

        public FrmQLKhachHang()
        {
            InitializeComponent();
            _iQLKhachHangService = new QLKhachHangService();
            LoadData(_iQLKhachHangService.GetAll());
        }

        private void LoadData(List<KhachHangView> list)
        {
            int stt = 1;
            dtg_DanhSachKH.ColumnCount = 9;
            dtg_DanhSachKH.Columns[0].Name = "ID";
            //dtg_DanhSachKH.Columns[0].Visible = false;
            dtg_DanhSachKH.Columns[1].Name = "STT";
            dtg_DanhSachKH.Columns[2].Name = "Mã Khách Hàng";
            dtg_DanhSachKH.Columns[3].Name = "Họ tên";
            dtg_DanhSachKH.Columns[4].Name = "CCCD";
            dtg_DanhSachKH.Columns[5].Name = "Sđt";
            dtg_DanhSachKH.Columns[6].Name = "Địa chỉ";
            dtg_DanhSachKH.Columns[7].Name = "Giới tính";
            dtg_DanhSachKH.Columns[8].Name = "Quốc tịch";
            foreach (var x in list)
            {
                dtg_DanhSachKH.Rows.Add(x.ID, stt++, x.MaKH, x.HovaTen, x.CCCD, x.SDT, x.DiaChi, x.GioiTinh, x.QuocTich);
            }

    }

        private void btn_ThemKhachHang_Click(object sender, EventArgs e)
        {
            FrmBtnThemKH kh = new FrmBtnThemKH();
            kh.ShowDialog();
        }

        private void dtg_DanhSachKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
