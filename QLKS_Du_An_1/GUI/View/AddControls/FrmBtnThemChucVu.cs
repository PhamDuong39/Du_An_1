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
    public partial class FrmBtnThemChucVu : Form
    {
        private IChucVuService _chucVuService;
        public FrmBtnThemChucVu()
        {
            _chucVuService = new ChucVuService();
            InitializeComponent();
        }
        private ChucVuView GetData()
        {
            return new ChucVuView() { ID = Guid.Empty, MaCV = tb_MaChucVuThem.Text, TenCV = tb_tenChucVuThem.Text };
        }

        private void btn_ThemChucVu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm ?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) MessageBox.Show(_chucVuService.Add(GetData()));
            if (result == DialogResult.No) MessageBox.Show("Canceled");
            this.Close();
        }
    }
}
