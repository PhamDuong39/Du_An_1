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
    public partial class FrmTrangThaiPhong : Form
    {
        public string MaPhong { get; set; }
        public string TenKH { get; set; }
        public Guid IdPhong { get; set; }
        public Guid IdPTCT { get; set; }
        public Guid IdPT { get; set; }
        public Guid IdKH { get; set; }

        private IQLChiTietPhieuThueService _iqlCTPTService;
        private IQLPhongService _iqlPhongService;
        private IHoaDonService _iqlHDService;
        public FrmTrangThaiPhong()
        {
            InitializeComponent();
            _iqlCTPTService = new QLChiTietPhieuThueService();
            _iqlPhongService = new IPhongService();
            _iqlHDService = new HoaDonService();
        }
        // truyền ngày BD và ngày ngày KT load lên form
        // dựa theo đó làm chức năng nhận phòng
        // chuyển trạng thái phòng từ xám => đỏ =  sự kiện click button Nhận phòng
        // chuyển trạng thái từ đỏ => vàng = sự kiện click butotn thanh toán
        private void FrmTrangThaiPhong_Load(object sender, EventArgs e)
        {
            dtp_NgayBatDau.Format = DateTimePickerFormat.Custom;
            dtp_NgayBatDau.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dtp_NgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtp_NgayKetThuc.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            lb_MaPhong.Text = MaPhong;
            lb_TenKH.Text = TenKH;
            if (IdPTCT == Guid.Empty)
            {
                dtp_NgayBatDau.Value = DateTime.Now;
                dtp_NgayKetThuc.Value = DateTime.Now;
                return;
            }
            else
            {
                dtp_NgayBatDau.Value = _iqlCTPTService.GetAll().FirstOrDefault(p => p.ID == IdPTCT).NgayBatDau;
                dtp_NgayKetThuc.Value = _iqlCTPTService.GetAll().FirstOrDefault(p => p.ID == IdPTCT).NgayKetThuc;
            }        
        }

        private void btn_NhanPhong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn nhận phòng cho khách hàng này không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (IdPTCT == null)
                {
                    MessageBox.Show("Vui lòng đặt 1 phòng trước khi nhận phòng");
                    return;
                }
                PhongView pv = new PhongView();
                pv.Id = _iqlCTPTService.GetAll().FirstOrDefault(p => p.ID == IdPTCT).IdPhong;
                pv.MaPhong = MaPhong;
                pv.IDLoaiPhong = _iqlPhongService.GetAll().FirstOrDefault(p => p.MaPhong == MaPhong).IDLoaiPhong;
                pv.TinhTrang = 1;
                _iqlPhongService.Update(pv);

                HoaDonView hdv = new HoaDonView();
                hdv.MaHD = "HD1";
                hdv.NgayTaoHD = DateTime.Now;
                hdv.IdCTPhieuThue = IdPTCT;
                MessageBox.Show(_iqlHDService.Add(hdv));
                MessageBox.Show("Nhận phòng thành công");
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn vừa hủy nhận phòng này");
            }
        }


        // Frm này sẽ hiển thị danh sách dịch vụ
        // click button thêm dịch vụ sẽ thêm dịch vụ vào 1 list tạm thời
        // Bấm lưu để chạy hàm Tạo hóa đơn chi tiết với các dịch vụ đã chọn. Nếu lst = null thì vẫn ghi lưu thành công
        // Sau đó click button thanh toán để chạy sự kiện btn thanh toán click
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            // clicl button này sẽ hiển thị lên FrmPrintHoaDon
            // FrmPrintHoaDon sẽ hiển thị lên giá tiền của phòng đã thuê, số dịch vụ đã sử dụng
            // Mỗi phòng sẽ chỉ có 1 hóa đơn duy nhất == Mỗi CPPT sẽ có 1 hóa đơn cho riêng nó
        }
    }
}
