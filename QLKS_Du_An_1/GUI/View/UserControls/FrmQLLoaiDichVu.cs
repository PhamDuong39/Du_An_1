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
    public partial class FrmQLLoaiDichVu : Form
    {
        public FrmQLLoaiDichVu()
        {
            InitializeComponent();
        }

        private void btn_ThemLoaiDichVu_Click(object sender, EventArgs e)
        {
            FrmBtnThemLoaiDichVu ldv = new FrmBtnThemLoaiDichVu();
            ldv.ShowDialog();
        }
    }
}
