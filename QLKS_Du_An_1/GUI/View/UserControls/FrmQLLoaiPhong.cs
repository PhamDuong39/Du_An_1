using GUI.View.AddControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI.View.UserControls
{
    public partial class FrmQLLoaiPhong : Form
    {
        public FrmQLLoaiPhong()
        {
            InitializeComponent();
        }

        private void btn_ThemLoaiPhong_Click(object sender, EventArgs e)
        {
            FrmBtnThemLoaiPhong frmBtnThemLoaiPhong = new FrmBtnThemLoaiPhong();
            frmBtnThemLoaiPhong.ShowDialog();
        }
    }
}
