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
        private IQLHoaDonChiTietView _qlHoadon;
        public FrmThongKe()
        {
            InitializeComponent();
            _qlHoadon = new QLHoaDonChiTietView();
        }
        

    }
}
