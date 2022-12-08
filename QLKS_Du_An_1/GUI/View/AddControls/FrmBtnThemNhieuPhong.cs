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
    public partial class FrmBtnThemNhieuPhong : Form
    {
        private IQLPhongService _qlphong;
        private IQLLoaiPhongService qlloaiPhong;
        public FrmBtnThemNhieuPhong()
        {
            InitializeComponent();
            _qlphong = new IPhongService();
            qlloaiPhong = new ILoaiPhongService();
            LoadCBB();
        }

        private void LoadCBB()
        {
            cbb_tang.Items.Add("Tầng 1");
            cbb_tang.Items.Add("Tầng 2");
            cbb_tang.Items.Add("Tầng 3");

            var lst = qlloaiPhong.GetAll();
            foreach (var item in lst)
            {
                cbb_TenLoaiPhong.Items.Add(item.TenLoaiPhong);
            }

            cbb_TinhTrangPhong.Items.Clear();
            cbb_TinhTrangPhong.Items.Add("Phòng trống");
            cbb_TinhTrangPhong.Items.Add("Phòng có khách");
            cbb_TinhTrangPhong.Items.Add("Phòng đang dọn dẹp");
        }
        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            DialogResult dls = MessageBox.Show("Bạn có muốn thêm nhũng phòng này không ?","Trả Lời",MessageBoxButtons.YesNo);
            if(dls == DialogResult.Yes)
            {
                for(int x = 0; x < Convert.ToInt32(tb_SoLuongThem.Text) - 1; x++)
                {
                    PhongView pv = new PhongView();
                    var lstPhong = _qlphong.GetAll();
                    var lstmaPhong = _qlphong.GetAll().Select(p => p.MaPhong).ToList();
                    if(lstmaPhong.Count == 0)
                    {
                        pv.MaPhong = "P" + cbb_tang.Text.Substring(5, 1) + "01";
                    }
                    else
                    {
                        int so = lstPhong.Max(p => Convert.ToInt32(p.MaPhong.Substring(2, p.MaPhong.Length - 2)) + 1);
                        pv.MaPhong = "P" + cbb_tang.Text.Substring(5, 1) + so;
                    }
                    pv.TinhTrang = cbb_TinhTrangPhong.Text == "Phòng trống" ? 0 : cbb_TinhTrangPhong.Text == "Phòng có khách" ? 1 : 2;
                    pv.IDLoaiPhong = _qlphong.GetIdLoaiPhongByName(cbb_TenLoaiPhong.Text);
                    MessageBox.Show(_qlphong.Add(pv));
                    
                }

            }
            else if(dls == DialogResult.No)
            {
                MessageBox.Show("Bạn đã không thêm nhưng phòng này");
            }
        }
    }
}
