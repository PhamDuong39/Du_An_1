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
using System.Windows.Documents;
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


        private List<PhongView> list_phong_trong;

        public TimeSpan oneHour = new TimeSpan(1, 0, 0);


        private List<PhongView> lstRoomChoosen;
        public FrmBtnDatPhong()
        {
            InitializeComponent();
            _iqlPhongService = new IPhongService();
            _iqlKHService = new QLKhachHangService();
            _iqlPTService = new QLPhieuThueService();
            _iqlCTPTService = new QLChiTietPhieuThueService();
            lstRoomChoosen = new List<PhongView>();
            list_phong_trong = new List<PhongView>();

            /*LoadDataDSPhongTrong();
            LoadDataDSPhongDaChon();*/

        }

        private void LoadDataDSPhongTrong(List<PhongView> list)
        {
            dtg_DSPhongTrong.ColumnCount = 3;
            dtg_DSPhongTrong.Rows.Clear();
            dtg_DSPhongTrong.Columns[0].Name = "Id Room";
            dtg_DSPhongTrong.Columns[0].Visible = false;
            dtg_DSPhongTrong.Columns[1].Name = "Mã phòng";
            dtg_DSPhongTrong.Columns[2].Name = "Loại phòng";
            dtg_DSPhongTrong.Rows.Clear();
            foreach (var item in list)
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

        private void LoadDataDSPhongDaChon(List<PhongView> _list)
        {
            dtg_DSPhongDaChon.ColumnCount = 3;
            dtg_DSPhongDaChon.Rows.Clear();
            dtg_DSPhongDaChon.Columns[0].Name = "Id Room";
            dtg_DSPhongDaChon.Columns[0].Visible = false;
            dtg_DSPhongDaChon.Columns[1].Name = "Mã phòng";
            dtg_DSPhongDaChon.Columns[2].Name = "Loại phòng";

            foreach (var item in _list)
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

                PhongView roomChoosen = _iqlPhongService.GetAll().FirstOrDefault(p => p.Id == IdRoomPicked);
                for (int i = 0; i < list_phong_trong.Count; i++)
                {
                    if (list_phong_trong[i].Id == roomChoosen.Id)
                    {
                        lstRoomChoosen.Add(list_phong_trong[i]);
                        list_phong_trong.Remove(list_phong_trong[i]);
                    }
                }

                LoadDataDSPhongTrong(list_phong_trong);
                LoadDataDSPhongDaChon(lstRoomChoosen);
                /*_iqlPhongService.Update(pv);*/
                /*LoadDataDSPhongTrong();*/

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
                ptv.IdNV = FrmMain.IdNV;
                var lstmaPT = _iqlPTService.GetAll().Select(p => p.MaPhieuThue);
                //int so = lstmaPT.Max() + 1;
                //ptv.MaPhieuThue = so;
                ptv.MaPhieuThue = 1;
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
                    // ĐOẠN NÀY là tôi ko biết là đặt xong chuyển sang trạng thái phòng khi đặt là  j ko thig tùy ý ông nhé  ông tự ấy theo đsung ý ông nhé ( chọn đc cái list muốn đặt rồi ông mới thay đổi trạng thái phòng)

                    ChiTietPhieuThueView ctptv = new ChiTietPhieuThueView();
                    ctptv.NgayBatDau = dtp_NgayBatDau.Value;
                    ctptv.NgayKetThuc = dtp_NgayKetThuc.Value;
                    ctptv.IdPhong = item.Id;
                    ctptv.IdPhieuThue = _iqlPTService.GetAll().FirstOrDefault(p => p.MaPhieuThue == 1).ID;
                    //DateTime now = DateTime.Now;

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
            dtp_NgayBatDau.CustomFormat = "MM'/'dd'/'yyyy hh':'mm tt";
            dtp_NgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtp_NgayKetThuc.CustomFormat = "MM'/'dd'/'yyyy hh':'mm tt";
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
                for (int i = 0; i < lstRoomChoosen.Count; i++)
                {
                    if (lstRoomChoosen[i].Id == roomChoosen.Id)
                    {
                        list_phong_trong.Add(lstRoomChoosen[i]);
                        lstRoomChoosen.Remove(lstRoomChoosen[i]);

                    }
                }
                LoadDataDSPhongDaChon(lstRoomChoosen);
                LoadDataDSPhongTrong(list_phong_trong);

            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            lstRoomChoosen = null;
            /*LoadDataDSPhongDaChon();*/
            /*LoadDataDSPhongTrong();*/
        }
        public void take_empty_room()
        {
            list_phong_trong.Clear();
            lstRoomChoosen.Clear();
            DateTime dt1 = dtp_NgayBatDau.Value;
            DateTime dt2 = dtp_NgayKetThuc.Value;


            List<ChiTietPhieuThueView> y = _iqlCTPTService.GetAll().ToList();
            List<ChiTietPhieuThueView> List_loc_ctpt = new List<ChiTietPhieuThueView>();
            foreach (var item in y)
            {
                if (item.NgayBatDau.CompareTo(dt1) >= 1 && item.NgayKetThuc.CompareTo(dt2) <= -1)
                {
                    List_loc_ctpt.Add(item);
                }
                else if (item.NgayBatDau.CompareTo(dt1) <= -1 && item.NgayKetThuc.CompareTo(dt1) >= 1 && item.NgayKetThuc.CompareTo(dt2) <= -1)
                {
                    List_loc_ctpt.Add(item);
                }
                else if (item.NgayBatDau.CompareTo(dt1) >= 1 && item.NgayBatDau.CompareTo(dt2) <= -1 && item.NgayKetThuc.CompareTo(dt2) >= 1)
                {
                    List_loc_ctpt.Add(item);
                }
                else if (item.NgayBatDau.CompareTo(dt1) <= -1 && item.NgayKetThuc.CompareTo(dt2) >= 1)
                {
                    List_loc_ctpt.Add(item);
                }
            }
            if (List_loc_ctpt.Count == 0)
            {
                list_phong_trong = _iqlPhongService.GetAll();
            }
            else
            {
                foreach (var item in _iqlPhongService.GetAll())
                {
                    foreach (var item2 in List_loc_ctpt)
                    {
                        if (item.Id != item2.IdPhong)
                        {
                            list_phong_trong.Add(item);
                        }
                    }
                }
            }

            LoadDataDSPhongTrong(list_phong_trong);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            take_empty_room();
        }
    }
}