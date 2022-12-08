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
        public DateTime NgayThanhToanHD { get; set; }
        public IQLChiTietPhieuThueService _iqlCTPTService;
        public IHoaDonService _iqlHDService;
        public IPhongService _iqlPhongService;
        public int GiaTienTraPhongMuon = 50000;
        public int TongTienPhaiTra { get; set; }
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
            foreach (var item in _lstHoaDon)
            {
                if (item.TrangThai == 1)//Trạng thái đã thanh toán
                {
                    btn_ThanhToan.Visible = false;
                }
                else
                {
                    btn_ThanhToan.Visible=true;
                }
            }
        }

        private void TinhTienThanhToan()
        {
            int stt = 1, tienDV = 0;
            double tienPhong = 0, tongTien, SoNgayTinhToan = 0;
            foreach (var x in _lstGiaPhong)
            {
                double SoNgayThue = 0;
                int count = 0;
                DateTime NgayBDThue = x.NgayBatDau;
                DateTime NgayTT = NgayThanhToanHD;
                TimeSpan SLNgayThue = NgayTT - NgayBDThue;
                TimeSpan SoNgayThueDatTruoc = x.NgayKetThuc - x.NgayBatDau;

                if (SLNgayThue.TotalHours <= 24.24)// TH1 : Số ngày thuê < 1 ngày
                {
                    count = 1;
                    SoNgayThue = 1;
                    
                }
                else if (SLNgayThue.TotalHours > 24.24 && SLNgayThue.TotalHours <= (SoNgayThueDatTruoc.TotalHours + 0.24)) // TH2 : Số ngày thuê nhiều hơn 1 ngày nhưng ít hơn tổng số ngày đặt trước
                {
                    count = 2;
                    int soNgayTinhToan = (int)SLNgayThue.TotalHours / 24;
                    double GioLe = SLNgayThue.TotalHours - soNgayTinhToan * 24;// Giờ lẻ của giờ thực tế thuê
                    if (GioLe <= 1)
                    {
                        SoNgayThue = soNgayTinhToan;
                    }
                    else if (GioLe > 1 && GioLe <= 13)
                    {
                        SoNgayThue = soNgayTinhToan + 0.5;
                    }
                    else
                    {
                        SoNgayThue = soNgayTinhToan + 1;
                    }
                }
                else// SLNgayThue.ToTalHours > SoNgayThueDatTruoc.TotalHours + 0.24 -- TH3 : Số ngày thuê vượt quá số ngày đã đặt
                {
                    count = 3;
                    double SoGioQua = SLNgayThue.TotalHours - SoNgayThueDatTruoc.TotalHours;
                    if (SoGioQua <= 1)  // OK
                    {
                        SoNgayThue = Math.Round(SoNgayThueDatTruoc.TotalHours / 24);
                    }
                    else if (SoGioQua > 1 && SoGioQua <= 11)
                    {
                        SoNgayThue = Math.Round(SoNgayThueDatTruoc.TotalHours / 24) + 0.5;
                    }
                    else if (SoGioQua > 11 && SoGioQua <= 24.24)
                    {
                        SoNgayThue = Math.Round(SoNgayThueDatTruoc.TotalHours / 24) + 1;
                    }
                    else//SoGioQua > 24
                    {
                        SoNgayTinhToan = SoGioQua / 24;
                        double GioQuaLe = SoGioQua - SoNgayTinhToan * 24;
                        if (GioQuaLe <= 1)
                        {
                            SoNgayTinhToan = (int)SoGioQua / 24;
                        } 
                        else if (GioQuaLe > 1 && GioQuaLe <= 12)
                        {
                            SoNgayTinhToan += 0.5;
                        }
                        else
                        {
                            SoNgayTinhToan += 1;
                        }
                        SoNgayThue = Math.Round(SLNgayThue.TotalHours / 24);
                    }
                }
                if (count == 1 || count == 2)
                {
                    tienPhong = x.GiaNgay * SoNgayThue;
                }
                else if (count == 3)
                {
                    //tienPhong = x.GiaNgay * SoNgayThue + (x.GiaNgay + GiaTienTraPhongMuon) * SoNgayTinhToan;
                    tienPhong = x.GiaNgay * Math.Round(SoNgayThueDatTruoc.TotalHours / 24) + (x.GiaNgay + GiaTienTraPhongMuon) * SoNgayTinhToan;                   
                }
               
                dgrid_HDCT.Rows.Add(stt++, x.TenLoaiPhong, x.GiaNgay, SoNgayThue, tienPhong);
               
                
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
