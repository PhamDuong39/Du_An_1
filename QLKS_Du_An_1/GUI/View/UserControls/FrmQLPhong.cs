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
    public partial class FrmQLPhong : Form
    {
        public FrmQLPhong()
        {
            InitializeComponent();
        }

        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            FrmBtnThemPhong p = new FrmBtnThemPhong();
            p.ShowDialog();
        }
    }
}
