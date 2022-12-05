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

namespace GUI.View.AddControls
{
    public partial class FrmViewHDCT : Form
    {
        public List<HoaDonView> _lstHoaDon;
        public List<HoaDonView> _lstHoaDonCT;
        public List<HoaDonView> _lstGiaPhong;
        public IQLChiTietPhieuThueService _iqlCTPTService;
        public IHoaDonService _iqlHDService;
        public IPhongService _iqlPhongService;
        public int GiaGio = 150;
        public FrmViewHDCT()
        {
            InitializeComponent();
            _lstHoaDon = new List<HoaDonView>();
            _lstHoaDonCT = new List<HoaDonView>();
            _lstGiaPhong = new List<HoaDonView>();
            _iqlCTPTService = new QLChiTietPhieuThueService();
            _iqlHDService = new HoaDonService();
            _iqlPhongService = new IPhongService();
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
            TinhTienThanhToan();
        }

        private void TinhTienThanhToan()
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
            foreach (var x in _lstHoaDon)
            {
                lbl_MaHD.Text = x.MaHD;
                lbl_TenNV.Text = x.TenNV;
                //lb_NgayBD.Text = _iqlCTPTService.GetAll().FirstOrDefault(p => p.ID == x.IdCTPhieuThue).NgayBatDau.ToString();
                //lb_NgayKT.Text = _iqlCTPTService.GetAll().FirstOrDefault(p => p.ID == x.IdCTPhieuThue).NgayBatDau.ToString();
                lbl_HoVaTen.Text = x.TenKH;
                lbl_MaPhong.Text = x.MaPhong;
                lbl_NgayThanhToan.Text = x.NgayTT.ToString();
                lbl_TongTien.Text = tongTien.ToString() + " Đồng";
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            // thanh toán sẽ cập nhật trạng thái hóa đơn , chuyển trạng thái phòng sang phòng đang dọn dẹp
            DialogResult result = MessageBox.Show("Vui lòng xác nhận thanh toán !!", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (var item in _lstHoaDon)
                {
                    HoaDonView hdv = new HoaDonView();
                    hdv.Id = item.Id;
                    hdv.MaHD = item.MaHD;
                    hdv.NgayTaoHD = item.NgayTaoHD;
                    hdv.IdCTPhieuThue = item.IdCTPhieuThue;
                    hdv.NgayTT = item.NgayTT;
                    hdv.TrangThai = 1;
                    MessageBox.Show(_iqlHDService.Update(hdv));
                   // MessageBox.Show(_iqlHDService.Update(_lstHoaDon.FirstOrDefault(c => c.Id == item.Id)));

                    PhongView pv = new PhongView();
                    pv.Id = _iqlPhongService.GetAll().FirstOrDefault(p => p.MaPhong == item.MaPhong).Id;
                    pv.MaPhong = item.MaPhong;
                    pv.IDLoaiPhong = _iqlPhongService.GetAll().FirstOrDefault(p => p.MaPhong == item.MaPhong).IDLoaiPhong;
                    pv.TinhTrang = 2;
                    MessageBox.Show(_iqlPhongService.Update(pv));
                }
                
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy thanh toán phòng này!");
            }
        }
    }
}
