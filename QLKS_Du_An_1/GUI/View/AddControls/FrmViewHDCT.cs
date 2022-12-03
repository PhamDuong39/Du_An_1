using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.ViewModels;

namespace GUI.View.AddControls
{
    public partial class FrmViewHDCT : Form
    {
        public List<HoaDonView> _lstHoaDon;
        public List<HoaDonView> _lstHoaDonCT;
        public List<HoaDonView> _lstGiaPhong;
        public FrmViewHDCT()
        {
            InitializeComponent();
            _lstHoaDon = new List<HoaDonView>();
            _lstHoaDonCT = new List<HoaDonView>();
            _lstGiaPhong = new List<HoaDonView>();
            LoadData();
        }
        private void LoadData()
        {
            
            dgrid_HDCT.ColumnCount = 5;
            dgrid_HDCT.Columns[0].Name = "STT";
            dgrid_HDCT.Columns[1].Name = "Ten";
            dgrid_HDCT.Columns[2].Name = "Don Gia";
            dgrid_HDCT.Columns[3].Name = "So Luong";
            dgrid_HDCT.Columns[4].Name = "So Tien";
            dgrid_HDCT.Rows.Clear();
        }

        private void FrmViewHDCT_Load(object sender, EventArgs e)
        {
            int stt = 1, tienPhong = 0, tienDV = 0, tongTien;
            foreach (var x in _lstGiaPhong)
            {
                dgrid_HDCT.Rows.Add(stt++, x.TenLoaiPhong, x.GiaNgay, "1", x.GiaNgay);
                tienPhong = x.GiaNgay;
            }
            foreach (var x in _lstHoaDonCT)
            {
                dgrid_HDCT.Rows.Add(stt++, x.TenDichVu, x.DonGia, x.SoLuongDichVu, x.DonGia * x.SoLuongDichVu);
                tienDV = x.DonGia * x.SoLuongDichVu;
            }
            tongTien = tienDV + tienPhong;
            foreach(var x in _lstHoaDon)
            {
                lbl_MaHD.Text = x.MaHD;
                lbl_TenNV.Text = x.TenNV;
                lbl_HoVaTen.Text = x.TenKH;
                lbl_MaPhong.Text = x.MaPhong;
                lbl_NgayThanhToan.Text = x.NgayTT.ToString();
                lbl_TongTien.Text = tongTien.ToString()+" Đồng";
            }
        }
    }
}
