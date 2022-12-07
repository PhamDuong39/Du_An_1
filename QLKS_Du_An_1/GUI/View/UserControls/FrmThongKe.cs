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
        private IHoaDonService _qlHoadon;
       
        public FrmThongKe()
        {
            InitializeComponent();
            _qlHoadon = new HoaDonService();
            LoadData();
        }
        
        private void LoadData()
        {
            dtg_thongke.Rows.Clear();
            int stt = 1;
            dtg_thongke.ColumnCount = 4;
            dtg_thongke.Columns[0].Name = "STT";
            dtg_thongke.Columns[1].Name = "Thang";
            dtg_thongke.Columns[2].Name = "Nam";
            dtg_thongke.Columns[3].Name = "Doanh Thu";
            for(int i = 1; i <= 12; i++)
            {
                dtg_thongke.Rows.Add(stt++, i, DateTime.Now.Year, TongTienThang(i));
            }
           
        }
        public int TongTienThang(int Month)
        {
            int tongtien = 0;
            var lst = _qlHoadon.GetAll().Where(c => c.NgayTaoHD.Month == Month && c.NgayTaoHD.Year == 2000);
            foreach(var i in lst){
                tongtien = tongtien + i.TongTien;
            }
            return tongtien;
        }
    }
}
