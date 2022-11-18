using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
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
        private IQLPhongService _iqlPhongService;

        // CellClick lấy thông tin trên dtg
        public Guid IDRoomSelect { get; set; }
        public string MaRoomSelect;
        public string TinhTrangRoomSelect;
        public string TenLoaiPhongSelect;

        public FrmQLPhong()
        {
            InitializeComponent();
            _iqlPhongService = new IPhongService();
            LoadData(_iqlPhongService.GetAll());
        }

        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            FrmBtnThemPhong p = new FrmBtnThemPhong();
            p.ShowDialog();
        }

        private void LoadData(List<PhongView> lst)
        {
            dtg_DanhSachPhong.ColumnCount = 5;
            dtg_DanhSachPhong.Rows.Clear();
            dtg_DanhSachPhong.Columns[0].Name = "ID";
            dtg_DanhSachPhong.Columns[0].Visible = true;
            dtg_DanhSachPhong.Columns[1].Name = "Mã phòng";
            dtg_DanhSachPhong.Columns[2].Name = "Tình trạng";
            dtg_DanhSachPhong.Columns[3].Name = "ID Loại phòng";          
            dtg_DanhSachPhong.Columns[3].Visible = false;          
            dtg_DanhSachPhong.Columns[4].Name = "Tên loại phòng";

            foreach (var item in lst)
            {
                dtg_DanhSachPhong.Rows.Add(item.Id, item.MaPhong, item.TinhTrang == 0 ? "Phòng trống" : item.TinhTrang == 1 ? "Phòng đang có khách" : "Phòng đang dọn dẹp", item.IDLoaiPhong,  item.TenLoaiPhong);
            }

            // Thêm button control vào datadridview
            DataGridViewButtonColumn cbn_ChucNangSua = new DataGridViewButtonColumn();
            cbn_ChucNangSua.HeaderText = "Chức năng sửa";
            cbn_ChucNangSua.Text = "Sửa";
            cbn_ChucNangSua.Name = "btn_SuaPhong";
            cbn_ChucNangSua.UseColumnTextForButtonValue = true;
            dtg_DanhSachPhong.Columns.Add(cbn_ChucNangSua);

            DataGridViewButtonColumn cbn_ChucNangXoa = new DataGridViewButtonColumn();
            cbn_ChucNangXoa.HeaderText = "Chức năng xóa";
            cbn_ChucNangXoa.Text = "Xóa";
            cbn_ChucNangXoa.Name = "btn_XoaPhong";
            cbn_ChucNangXoa.UseColumnTextForButtonValue = true;
            dtg_DanhSachPhong.Columns.Add(cbn_ChucNangXoa);
        }

        private void dtg_DanhSachPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_DanhSachPhong.Rows.Count - 1)
            {
                return;
            }
            IDRoomSelect = Guid.Parse(Convert.ToString(dtg_DanhSachPhong.Rows[rd].Cells[0].Value));
            MaRoomSelect = Convert.ToString(dtg_DanhSachPhong.Rows[rd].Cells[1].Value);
            TinhTrangRoomSelect = Convert.ToString(dtg_DanhSachPhong.Rows[rd].Cells[2].Value);
            TenLoaiPhongSelect = Convert.ToString(dtg_DanhSachPhong.Rows[rd].Cells[4].Value);   
        }

        private void dtg_DanhSachPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_DanhSachPhong.Columns[e.ColumnIndex].Name == "btn_SuaPhong")
            {           
                // Open Form BtnSuaPhong
                FrmBtnSuaPhong btnSuaPhong = new FrmBtnSuaPhong();
                // Đấy dữ liệu vừa cell click sang các prop bên form BtnSuaPhong
                btnSuaPhong.IDPhongSua = IDRoomSelect;
                btnSuaPhong.MaPhongSua = MaRoomSelect;
                btnSuaPhong.TinhTrangSua = TinhTrangRoomSelect;
                btnSuaPhong.TenLoaiPhongSua = TenLoaiPhongSelect;
                btnSuaPhong.ShowDialog();
            }
            if (dtg_DanhSachPhong.Columns[e.ColumnIndex].Name == "btn_XoaPhong")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa phòng này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    PhongView pv = new PhongView();
                    pv.Id = IDRoomSelect;
                    MessageBox.Show(_iqlPhongService.Remove(pv));
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Xóa phòng thất bại");
                }
            }
        }
    }
}
