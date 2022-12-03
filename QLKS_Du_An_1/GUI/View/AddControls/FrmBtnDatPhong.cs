using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.View.AddControls
{
    public partial class FrmBtnDatPhong : Form
    {
        private IQLPhongService _iqlPhongService;
        private IQLKhachHangService _iqlKHService;
        private IQLPhieuThueService _iqlPTService;
        private IQLChiTietPhieuThueService _iqlCTPTService;
        private Guid IdRoomPicked { get; set; }

        private List<PhongView> lstRoomChoosen;
        public FrmBtnDatPhong()
        {
            InitializeComponent();
            _iqlPhongService = new IPhongService();
            _iqlKHService = new QLKhachHangService();
            _iqlPTService = new QLPhieuThueService();
            _iqlCTPTService = new QLChiTietPhieuThueService();
            lstRoomChoosen = new List<PhongView>();

            LoadDataDSPhongTrong();
            LoadDataDSPhongDaChon();
            
        }
        
        private void LoadDataDSPhongTrong()
        {
            dtg_DSPhongTrong.ColumnCount = 3;
            dtg_DSPhongTrong.Rows.Clear();
            dtg_DSPhongTrong.Columns[0].Name = "Id Room";
            dtg_DSPhongTrong.Columns[0].Visible = false;
            dtg_DSPhongTrong.Columns[1].Name = "Mã phòng";
            dtg_DSPhongTrong.Columns[2].Name = "Loại phòng";

            var lstPhongTrong = _iqlPhongService.GetAll().Where(p => p.TinhTrang == 0);
            foreach (var item in lstPhongTrong)
            {
                dtg_DSPhongTrong.Rows.Add(item.Id, item.MaPhong, item.TenLoaiPhong);
            }

            DataGridViewButtonColumn cbn_ChucNangChonPhong = new DataGridViewButtonColumn();
            cbn_ChucNangChonPhong.HeaderText = "Thêm";
            cbn_ChucNangChonPhong.Text = "Thêm";
            cbn_ChucNangChonPhong.Name = "btn_ChooseRoom";
            cbn_ChucNangChonPhong.UseColumnTextForButtonValue = true;
            dtg_DSPhongTrong.Columns.Add(cbn_ChucNangChonPhong);
        }

        private void LoadDataDSPhongDaChon()
        {
            dtg_DSPhongDaChon.ColumnCount = 3;
            dtg_DSPhongDaChon.Rows.Clear();
            dtg_DSPhongDaChon.Columns[0].Name = "Id Room";
            dtg_DSPhongDaChon.Columns[0].Visible = false;
            dtg_DSPhongDaChon.Columns[1].Name = "Mã phòng";
            dtg_DSPhongDaChon.Columns[2].Name = "Loại phòng";

            foreach (var item in lstRoomChoosen)
            {
                dtg_DSPhongDaChon.Rows.Add(item.Id, item.MaPhong, item.TenLoaiPhong);
            }

            DataGridViewButtonColumn cbn_ChucNangHuyChonPhong = new DataGridViewButtonColumn();
            cbn_ChucNangHuyChonPhong.HeaderText = "Hủy";
            cbn_ChucNangHuyChonPhong.Text = "Hủy";
            cbn_ChucNangHuyChonPhong.Name = "btn_CancelChooseRoom";
            cbn_ChucNangHuyChonPhong.UseColumnTextForButtonValue = true;
            dtg_DSPhongDaChon.Columns.Add(cbn_ChucNangHuyChonPhong);
        }

        private void dtg_DSPhongTrong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_DSPhongTrong.Columns[e.ColumnIndex].Name == "btn_ChooseRoom")
            {
                var roomChoosen = _iqlPhongService.GetAll().FirstOrDefault(p => p.Id == IdRoomPicked);
                lstRoomChoosen.Add(roomChoosen);
                LoadDataDSPhongDaChon();
                PhongView pv = new PhongView();
                pv.Id = IdRoomPicked;
                pv.MaPhong = dtg_DSPhongTrong.Rows[e.RowIndex].Cells[1].Value.ToString();
                pv.IDLoaiPhong = _iqlPhongService.GetIdLoaiPhongByName(dtg_DSPhongTrong.Rows[e.RowIndex].Cells[2].Value.ToString());
                pv.TinhTrang = 1;
                _iqlPhongService.Update(pv);
                LoadDataDSPhongTrong();
            }
        }

        private void dtg_DSPhongTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_DSPhongTrong.Rows.Count - 1)
            {
                return;
            }
            IdRoomPicked = Guid.Parse(dtg_DSPhongTrong.Rows[rd].Cells[0].Value.ToString());
        }

        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đặt phòng không ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                PhieuThueView ptv = new PhieuThueView();              
                ptv.NgayLapPhieu = DateTime.Now;
                 //ptv.IdNV = Guid.Parse(Convert.ToString("8A157923-11AC-4AE4-A206-2E8A2A1D7237"));
                //FrmMain main = new FrmMain(TaiKhoanView tkv);
                ptv.IdNV = FrmMain.IdNV;
                var lstmaPT = _iqlPTService.GetAll().Select(p => p.MaPhieuThue);
                int so = lstmaPT.Max() + 1;
                ptv.MaPhieuThue = so;
                var lstKH = _iqlKHService.GetAll().FirstOrDefault(p => p.CCCD == tb_CCCDKH.Text);
                if (lstKH == null)
                {
                    KhachHangView khv = new KhachHangView();
                    khv.CCCD = tb_CCCDKH.Text;
                    khv.MaKH = tb_MaKH.Text;
                    khv.HovaTen = tb_TenKH.Text;
                    khv.SDT = tb_SDTKH.Text;
                    khv.DiaChi = tb_DiaChiKH.Text;
                    khv.QuocTich = tb_QuocTichKH.Text;
                    khv.GioiTinh = cbb_GioiTinhKH.Text == "Nam" ? 1 : cbb_GioiTinhKH.Text == "Nữ" ? 2 : 3;
                    _iqlKHService.Add(khv);
                    ptv.IdKH = _iqlKHService.GetAll().FirstOrDefault(p => p.CCCD == tb_CCCDKH.Text).ID;
                }
                else
                {
                    ptv.IdKH = lstKH.ID;
                }
                _iqlPTService.Add(ptv);

                foreach (var item in lstRoomChoosen)
                {
                    ChiTietPhieuThueView ctptv = new ChiTietPhieuThueView();
                    ctptv.NgayBatDau = dtp_NgayBatDau.Value;
                    ctptv.NgayKetThuc = dtp_NgayKetThuc.Value;
                    ctptv.IdPhong = item.Id;
                    ctptv.IdPhieuThue = _iqlPTService.GetAll().FirstOrDefault(p => p.MaPhieuThue == so).ID;
                    MessageBox.Show(_iqlCTPTService.Add(ctptv));
                }             
            }
            if (result == DialogResult.No)
            {
                foreach (var item in lstRoomChoosen)
                {
                    PhongView pv = new PhongView();
                    pv.Id = item.Id;
                    pv.MaPhong = item.MaPhong;
                    pv.IDLoaiPhong = item.IDLoaiPhong;
                    pv.TinhTrang = 0;
                    _iqlPhongService.Update(pv);
                }              
                MessageBox.Show("Bạn đã hủy đặt phòng");
            }
        }

        private void FrmBtnDatPhong_Load(object sender, EventArgs e)
        {
            dtp_NgayBatDau.Format = DateTimePickerFormat.Custom;
            dtp_NgayBatDau.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dtp_NgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtp_NgayKetThuc.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void dtg_DSPhongDaChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == -1 || rd == dtg_DSPhongDaChon.Rows.Count - 1)
            {
                return;
            }
            IdRoomPicked = Guid.Parse(dtg_DSPhongDaChon.Rows[rd].Cells[0].Value.ToString());
        }

        private void dtg_DSPhongDaChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_DSPhongDaChon.Columns[e.ColumnIndex].Name == "btn_CancelChooseRoom")
            {
                var roomChoosen = _iqlPhongService.GetAll().FirstOrDefault(p => p.Id == IdRoomPicked);
                //var room = lstRoomChoosen.FirstOrDefault(p => p.Id == IdRoomPicked);
                lstRoomChoosen.Remove(roomChoosen);
                LoadDataDSPhongDaChon();
                PhongView pv = new PhongView();
                pv.Id = IdRoomPicked;
                pv.MaPhong = dtg_DSPhongDaChon.Rows[e.RowIndex].Cells[1].Value.ToString();
                pv.IDLoaiPhong = _iqlPhongService.GetIdLoaiPhongByName(dtg_DSPhongDaChon.Rows[e.RowIndex].Cells[2].Value.ToString());
                pv.TinhTrang = 0;
                _iqlPhongService.Update(pv);
                LoadDataDSPhongTrong();               
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            lstRoomChoosen = null;
            LoadDataDSPhongDaChon();
            LoadDataDSPhongTrong();
        }
    }
}
