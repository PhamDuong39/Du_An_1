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
namespace GUI.View.UserControls
{
    public partial class FrmThongKe : Form
    {
        private IQLHoaDonChiTietView _iqlHoaDonCT;
        private IHoaDonService hoaDonService;
        public int Month;
        public Guid IdHDSelect { get; set; }
        public FrmThongKe()
        {
            InitializeComponent();
            _iqlHoaDonCT = new QLHoaDonChiTietView();
            hoaDonService = new HoaDonService();
            LoadDAta();
        }
        private void LoadDAta()
        {
            int stt = 1;
            dtg_thongke.Rows.Clear();
            dtg_thongke.ColumnCount = 4;
            dtg_thongke.Columns[0].Name = "STT";
            dtg_thongke.Columns[1].Name = "Tháng";
            dtg_thongke.Columns[2].Name = "Năm";
            dtg_thongke.Columns[3].Name = "Tổng Doanh Thu";
            
                for(int i = 1; i<= 12; i++)
                {
                    dtg_thongke.Rows.Add(i,i,2022,TongTienThang());
                }
            
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            
        }
        private int TongTienThang()
        {
            int tongtien = 0;
            
            
            for(int month = 0; month <= 12; month++)
            {
                var lst = hoaDonService.GetAll().Where(c => c.NgayTaoHD.Month == month);
                foreach (var t in lst)
                {
                    tongtien = tongtien + t.TongTien;
                }
                
            }
            return tongtien;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
