using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
using GUI.View.UserControls;
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
    public partial class FrmBtnThemKH : Form
    {
        public send_kh _send;
        private IQLKhachHangService _iQLKhachHangService;
        public FrmBtnThemKH()
        {
            InitializeComponent();
            _iQLKhachHangService = new QLKhachHangService();
            LoadCbb();
        }
        public FrmBtnThemKH(send_kh send)
        {
            InitializeComponent();
            this._send= send;
            _iQLKhachHangService = new QLKhachHangService();
            this._send = send;
            LoadCbb();
        }
        private void LoadCbb()
        {
            cbb_GioiTinh.Items.Add("Nam");
            cbb_GioiTinh.Items.Add("Nữ");
        }
        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            DialogResult dls = MessageBox.Show("Bạn có muốn thêm khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dls == DialogResult.Yes)
            {
                var kh = new KhachHangView()
                {
                    ID = Guid.NewGuid(),
                    HovaTen = tbt_HoTenKH.Text,
                    MaKH = tbt_MaKh.Text,
                    CCCD = tbt_CCCD.Text,
                    SDT = tbt_SDTKh.Text,
                    DiaChi = tbt_DiaChiKH.Text,
                    QuocTich = tbt_QuocTichKH.Text,
                    GioiTinh = cbb_GioiTinh.Text == "Nam" ? 1 : cbb_GioiTinh.Text == "Nữ" ? 2 : 3,
                };
                MessageBox.Show(_iQLKhachHangService.Add(kh));
                _send(_iQLKhachHangService.GetAll());
            }
            else
            {
                MessageBox.Show("Bạn đã không thên khách hàng này");
            }
        }

        private void btn_HuyThemKH_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
