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
    public partial class FrmBtnThemLoaiTienNghi : Form
    {
        private IQLLoaiTienNghiService _iqlLoaiTiennghi;
        public FrmBtnThemLoaiTienNghi()
        {
            InitializeComponent();
            _iqlLoaiTiennghi = new QLLoaiTienNghiService();
        }

        private void btn_ThemLoaiTienNghi_Click(object sender, EventArgs e)
        {
            DialogResult dls = MessageBox.Show("Bạn có muốn thêm loai tiện nghi này không?", "Thông báo", MessageBoxButtons.YesNo);
            if(dls == DialogResult.Yes)
            {
                var ltn = new LoaiTienNghiView()
                {
                    ID = Guid.NewGuid(),
                    TenLoaiTienNghi = tb_tenThemLoaiTienNghi.Text,
                    MaLoaiTienNghi = tb_maThemLoaiTienNghi.Text
                };
                MessageBox.Show(_iqlLoaiTiennghi.Add(ltn));
            }
            else
            {
                MessageBox.Show("Bạn đã không thên loại tiện nghi này");
            }
        }
    }
}
