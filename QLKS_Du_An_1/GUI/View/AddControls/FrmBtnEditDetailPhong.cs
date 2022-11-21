using BUS.IServices;
using BUS.Services;
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
    public partial class FrmBtnEditDetailPhong : Form
    {
        public string MaPhong { get; set; }
        public Guid IdRoomSelected { get; set; }

        private IQLChiTietTienNghiService _iqlCTTNService;

        public FrmBtnEditDetailPhong()
        {
            InitializeComponent();
            _iqlCTTNService = new QLChiTietTienNghiService();

            LoadDataCTTNTrong();
            LoadDataCTTNPhong();
        }

        private void LoadDataCTTNTrong()
        {
            dtg_DanhSachCTTNTrong.ColumnCount = 4;
            dtg_DanhSachCTTNTrong.Rows.Clear();
            dtg_DanhSachCTTNTrong.Columns[0].Name = "ID CTTN";
            dtg_DanhSachCTTNTrong.Columns[0].Visible = false;
            dtg_DanhSachCTTNTrong.Columns[1].Name = "Ma CTTN";
            dtg_DanhSachCTTNTrong.Columns[2].Name = "Ten CTTN";
            dtg_DanhSachCTTNTrong.Columns[3].Name = "Ten Loai TN";

            var lstCTTNTrong = _iqlCTTNService.GetEmptyCTTN();
        
            foreach (var item in lstCTTNTrong)
            {
                dtg_DanhSachCTTNTrong.Rows.Add(item.ID, item.MaCTTienNghi, item.TenCTTienNghi, item.TenLoaiTienNghi);
            }
        }

        private void LoadDataCTTNPhong()
        {
            dtg_DanhSachCTTNPhong.ColumnCount = 6;
            dtg_DanhSachCTTNPhong.Rows.Clear();
            dtg_DanhSachCTTNPhong.Columns[0].Name = "ID CTTN";
            dtg_DanhSachCTTNPhong.Columns[0].Visible = false;
            dtg_DanhSachCTTNPhong.Columns[1].Name = "Mã CTTN";
            dtg_DanhSachCTTNPhong.Columns[2].Name = "Tên CTTN";
            dtg_DanhSachCTTNPhong.Columns[3].Name = "Tên Loại TN";
            dtg_DanhSachCTTNPhong.Columns[4].Name = "ID Phòng";
            dtg_DanhSachCTTNPhong.Columns[4].Visible = false;
            dtg_DanhSachCTTNPhong.Columns[5].Name = "Mã phòng";

            //var lstCTTNPhong = _iqlCTTNService.GetListCTTNRoom(Guid.Parse("86393AF9-2C4F-43C5-861C-1605E3B96938"));
            //var lstCTTNPhong = _iqlCTTNService.GetListCTTNRoom(IDPhong);
            
            

            var lstCTTNPhong = _iqlCTTNService.GetListCTTNRoom(Guid.Parse("86393AF9-2C4F-43C5-861C-1605E3B96938"));
  
            foreach (var item in lstCTTNPhong)
            {
                dtg_DanhSachCTTNPhong.Rows.Add(item.ID, item.MaCTTienNghi, item.TenCTTienNghi, item.TenLoaiTienNghi, item.IdPhong, item.MaPhong);
            }
           
        }

        private void FrmBtnEditDetailPhong_Load(object sender, EventArgs e)
        {
            lb_TenPhongCTTN.Text = MaPhong;
            //lb_TenPhongCTTN.Text = "" + IDPhong;           
            
        }
    }
}
