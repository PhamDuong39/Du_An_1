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
    public partial class FrmQLTienNghi : Form
    {
        public FrmQLTienNghi()
        {
            InitializeComponent();
        }

        private void btn_ThemTienNghi_Click(object sender, EventArgs e)
        {
            FrmBtnThemTienNghi tn = new FrmBtnThemTienNghi();
            tn.ShowDialog();
        }
    }
}
