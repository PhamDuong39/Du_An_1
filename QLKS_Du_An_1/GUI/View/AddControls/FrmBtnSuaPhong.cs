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
    public partial class FrmBtnSuaPhong : Form
    {
        private IQLPhongService _iqlPhongService;
        private IQLLoaiPhongService _iqlLoaiPhongService;

        // Các prop để nhận dữ liệu từ cell click 
        public Guid IDPhongSua { get; set; }
        
        public string MaPhongSua { get; set; }
        public string TinhTrangSua { get; set; }
        public string TenLoaiPhongSua { get; set; }
        public FrmBtnSuaPhong()
        {
            InitializeComponent();
            _iqlPhongService = new IPhongService();
            _iqlLoaiPhongService = new ILoaiPhongService();

            LoadDataCbb();
            
        }

        private void LoadDataCbb()
        {
            var lstLoaiPhong = _iqlLoaiPhongService.GetAll();
            cbb_TenLoaiPhong.Items.Clear();
            foreach (var item in lstLoaiPhong)
            {
                cbb_TenLoaiPhong.Items.Add(item.TenLoaiPhong);
            }
            
            cbb_TrangThai.Items.Clear();
            cbb_TrangThai.Items.Add("Phòng trống");
            cbb_TrangThai.Items.Add("Phòng có khách");
            cbb_TrangThai.Items.Add("Phòng đang dọn dẹp");
        }

        private void btn_SuaPhong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn sửa phòng này không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                PhongView pv = new PhongView();
                pv.Id = IDPhongSua;
                pv.MaPhong = tb_MaPhong.Text;
                // 0 = Phòng trống, 1= Phòng có khách , 2 = Phòng đang dọn dẹp
                pv.TinhTrang = cbb_TrangThai.Text == "Phòng trống" ? 0 : cbb_TrangThai.Text == "Phòng có khách" ? 1 : 2 ;
                pv.IDLoaiPhong = _iqlPhongService.GetIdLoaiPhongByName(cbb_TenLoaiPhong.Text);
                MessageBox.Show(_iqlPhongService.Update(pv));

                FrmQLPhong frmQLPhong = new FrmQLPhong();
                frmQLPhong.LoadData(_iqlPhongService.GetAll());
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn đã hủy sửa phòng");
            }
        }

        private void FrmBtnSuaPhong_Load(object sender, EventArgs e)
        {
            lb_TenPhongSua.Text = MaPhongSua;
            tb_MaPhong.Text = MaPhongSua;
            cbb_TrangThai.Text = TinhTrangSua;
            cbb_TenLoaiPhong.Text = TenLoaiPhongSua;
        }
    }
}
