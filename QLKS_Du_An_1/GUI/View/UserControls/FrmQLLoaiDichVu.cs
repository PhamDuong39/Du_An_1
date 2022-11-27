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
using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
namespace GUI.View.UserControls
{
    public partial class FrmQLLoaiDichVu : Form
    {
        private IQLLoaiDichVuService _iqlLoaiDichVu;

        public Guid IdLoaiDichVuSelect { get; set; }
        public string MaLoaiDichVuSelect;
        public string TenLoaiDichVuSelect;
        public FrmQLLoaiDichVu()
        {
            InitializeComponent();
            _iqlLoaiDichVu = new QLLoaiDichVuService();
            LoadData(_iqlLoaiDichVu.GetAll());
        }

        private void btn_ThemLoaiDichVu_Click(object sender, EventArgs e)
        {
            FrmBtnThemLoaiDichVu ldv = new FrmBtnThemLoaiDichVu();
            ldv.ShowDialog();
        }
        private void LoadData(List<LoaiDichVuView> lst)
        {
            dtg_DanhSachLoaiDichVu.ColumnCount = 3;
            dtg_DanhSachLoaiDichVu.Rows.Clear();
            dtg_DanhSachLoaiDichVu.Columns[0].Name = "ID";
            dtg_DanhSachLoaiDichVu.Columns[0].Visible = true;
            dtg_DanhSachLoaiDichVu.Columns[1].Name = "Mã loại dịch vụ";
            dtg_DanhSachLoaiDichVu.Columns[2].Name = "Tên loại dịch vụ";


            foreach (var item in lst)
            {
                dtg_DanhSachLoaiDichVu.Rows.Add(item.ID, item.MaLoaiDichVu, item.TenLoaiDichVu);
            }

            // Thêm button control vào datadridview
            DataGridViewButtonColumn cbn_ChucNangSua = new DataGridViewButtonColumn();
            cbn_ChucNangSua.HeaderText = "Chức năng sửa";
            cbn_ChucNangSua.Text = "Sửa";
            cbn_ChucNangSua.Name = "btn_SuaLoaiDichVu";
            cbn_ChucNangSua.UseColumnTextForButtonValue = true;
            dtg_DanhSachLoaiDichVu.Columns.Add(cbn_ChucNangSua);

            DataGridViewButtonColumn cbn_ChucNangXoa = new DataGridViewButtonColumn();
            cbn_ChucNangXoa.HeaderText = "Chức năng xóa";
            cbn_ChucNangXoa.Text = "Xóa";
            cbn_ChucNangXoa.Name = "btn_XoaLoaiDichVu";
            cbn_ChucNangXoa.UseColumnTextForButtonValue = true;
            dtg_DanhSachLoaiDichVu.Columns.Add(cbn_ChucNangXoa);
        }

        private void dtg_DanhSachLoaiDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_DanhSachLoaiDichVu.Rows.Count - 1)
            {
                return;
            }
            IdLoaiDichVuSelect = Guid.Parse(Convert.ToString(dtg_DanhSachLoaiDichVu.Rows[rd].Cells[0].Value));
            MaLoaiDichVuSelect = Convert.ToString(dtg_DanhSachLoaiDichVu.Rows[rd].Cells[1].Value);
            TenLoaiDichVuSelect = Convert.ToString(dtg_DanhSachLoaiDichVu.Rows[rd].Cells[2].Value);
        }

        private void dtg_DanhSachLoaiDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_DanhSachLoaiDichVu.Columns[e.ColumnIndex].Name == "btn_SuaLoaiDichVu")
            {
                // Open Form BtnSuaPhong
                FrmBtnSuaLoaiDichVu btnsualtn = new FrmBtnSuaLoaiDichVu();
                // Đấy dữ liệu vừa cell click sang các prop bên form BtnSuaPhong
                btnsualtn.IdLoaiDichVu = IdLoaiDichVuSelect;
                btnsualtn.MaLoaiDichVu = MaLoaiDichVuSelect;
                btnsualtn.TenLoaiDichVu = TenLoaiDichVuSelect;
                btnsualtn.ShowDialog();
            }
            if (dtg_DanhSachLoaiDichVu.Columns[e.ColumnIndex].Name == "btn_XoaLoaiDichVu")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa loại tiện nghi này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    LoaiDichVuView pv = new LoaiDichVuView();
                    pv.ID = IdLoaiDichVuSelect;
                    MessageBox.Show(_iqlLoaiDichVu.Delete(pv));
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Xóa loai tiện nghi thất bại");
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadData(_iqlLoaiDichVu.GetAll());
        }
    }
}
