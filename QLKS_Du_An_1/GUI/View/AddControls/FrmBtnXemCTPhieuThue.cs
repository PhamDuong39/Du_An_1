using BUS.IServices;
using BUS.Services;
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
    public partial class FrmBtnXemCTPhieuThue : Form
    {
        private IQLChiTietPhieuThueService _iqlCTPTService;
        public Guid IdPT { get; set; }
        public Guid IdKH { get; set; }
        public string TenKH { get; set; }
        public string TenNV { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public FrmBtnXemCTPhieuThue()
        {
            InitializeComponent();
            _iqlCTPTService = new QLChiTietPhieuThueService();

            LoadDataCTPT();
        }

        private void LoadDataCTPT()
        {
            dtg_ChiTietPhieuThue.ColumnCount = 4;
            dtg_ChiTietPhieuThue.Rows.Clear();
            dtg_ChiTietPhieuThue.Columns[0].Name = "ID CTPT";
            dtg_ChiTietPhieuThue.Columns[1].Name = "Mã phòng";
            dtg_ChiTietPhieuThue.Columns[2].Name = "Ngày bắt đầu";
            dtg_ChiTietPhieuThue.Columns[3].Name = "Ngày kết thúc";
 

            //var lstCtsp = _iqlCTPTService.GetAll();
            var lstCtsp = _iqlCTPTService.GetAll().Where(p => p.IdPhieuThue == IdPT);
            foreach (var item in lstCtsp)
            {
                dtg_ChiTietPhieuThue.Rows.Add(item.ID, item.MaPhong, item.NgayBatDau, item.NgayKetThuc);
            }
        }

        private void FrmBtnXemCTPhieuThue_Load(object sender, EventArgs e)
        {
            lb_TenKH.Text = TenKH;
            lb_TenNV.Text = TenNV;
            dtp_NgayLapPhieu.Value = NgayLapPhieu;
            LoadDataCTPT();
        }
    }
}
