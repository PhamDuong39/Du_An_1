﻿using BUS.IServices;
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

namespace GUI.View.UserControls
{
    public partial class FrmPhong : Form
    {
        private IQLPhongService _iqlPhongService;
        private IQLListItemRoomViewService _iqlListRoomService;
        private IQLPhieuThueService _iqlPTService;
        private IQLChiTietPhieuThueService _iqlCTPTService;
        public TimeSpan oneHour = new TimeSpan(1, 0, 0);
        public TimeSpan zeroHour = new TimeSpan(0, 0, 0);
        private Guid? IdKHInPT { get; set; }
        private DateTime NgayBDThue { get; set; }
        private DateTime NgayKTThue { get; set; }

        public FrmPhong()
        {
            InitializeComponent();
            _iqlPhongService = new IPhongService();
            _iqlListRoomService = new QLListItemRoomViewService();
            _iqlPTService = new QLPhieuThueService();
            _iqlCTPTService = new QLChiTietPhieuThueService();

 
        }

        private void FrmPhong_Load(object sender, EventArgs e)
        {
            LoadItemRooms();
        }

        private void LoadItemRooms()
        {
            #region Tang1
            var lstPhongTang1 = _iqlPhongService.GetAll().Where(p => p.MaPhong.Substring(1, 1) == "1").ToList();
            ListItemRooms[] listItems1 = new ListItemRooms[lstPhongTang1.Count];
            int count1 = 0;
            foreach (var item in lstPhongTang1)
            {
                listItems1[count1] = new ListItemRooms();
                listItems1[count1].MaPhong = item.MaPhong;
                listItems1[count1].TenLoaiPhong = item.TenLoaiPhong;
                listItems1[count1].IdPhong = Convert.ToString(item.Id);
                
                if (item.TinhTrang == 1)    // co khach su dung
                {
                    listItems1[count1].BackColor = Color.Red;
                    IdKHInPT = _iqlCTPTService.GetAll().FirstOrDefault(p => p.IdPhong == item.Id).IdKH;
                    listItems1[count1].TenKH = _iqlPTService.GetAll().FirstOrDefault(p => p.IdKH == IdKHInPT).TenKH;
                    listItems1[count1].TTDonDep = "Phòng đang có khách";
                    listItems1[count1].IdPTCT = _iqlCTPTService.GetAll().FirstOrDefault(p => p.IdPhong== item.Id && p.NgayBatDau - DateTime.Now <= oneHour).ID;
                }
                else if (item.TinhTrang == 2) // dang don dep
                {
                    listItems1[count1].BackColor = Color.Yellow;
                    listItems1[count1].TenKH = "Phòng trống";
                    listItems1[count1].TTDonDep = "Phòng đang dọn dẹp";
                    listItems1[count1].IdPTCT = Guid.Empty;
                }
                else if (item.TinhTrang == 3) // Phong sap co khach thue trong vong 1 tieng
                {
                    listItems1[count1].BackColor = Color.LightGray;
                    IdKHInPT = _iqlCTPTService.GetAll().FirstOrDefault(p => p.IdPhong == item.Id).IdKH;
                    listItems1[count1].TenKH = _iqlPTService.GetAll().FirstOrDefault(p => p.IdKH == IdKHInPT).TenKH;
                    listItems1[count1].TTDonDep = "Phòng đã dọn dẹp";
                    listItems1[count1].IdPTCT = _iqlCTPTService.GetAll().FirstOrDefault(p => p.IdPhong == item.Id && p.NgayBatDau - DateTime.Now <= oneHour).ID;
                }
                else // phong trong
                {
                    listItems1[count1].BackColor = Color.Green;
                    listItems1[count1].TenKH = "Phòng trống";
                    listItems1[count1].TTDonDep = "Phòng đã dọn dẹp";
                    listItems1[count1].IdPTCT = Guid.Empty;
                    
                }
                if (flp_PhongTang1.Controls.Count < 0)
                {
                    flp_PhongTang1.Controls.Clear();
                }
                else
                {
                    flp_PhongTang1.Controls.Add(listItems1[count1]);
                }
                count1++;
                if (count1 == lstPhongTang1.Count)
                {
                    count1 = 0;
                }
            }
            #endregion

            #region Tang2
            var lstPhongTang2 = _iqlPhongService.GetAll().Where(p => p.MaPhong.Substring(1, 1) == "2").ToList();
            ListItemRooms[] listItems2 = new ListItemRooms[lstPhongTang2.Count];
            int count2 = 0;
            foreach (var item in lstPhongTang2)
            {
                listItems2[count2] = new ListItemRooms();
                listItems2[count2].MaPhong = item.MaPhong;
                listItems2[count2].TenLoaiPhong = item.TenLoaiPhong;
                listItems2[count2].IdPhong = Convert.ToString(item.Id);

                if (item.TinhTrang == 1)    // co khach su dung
                {
                    listItems2[count2].BackColor = Color.Red;
                    IdKHInPT = _iqlCTPTService.GetAll().FirstOrDefault(p => p.IdPhong == item.Id).IdKH;
                    listItems2[count2].TenKH = _iqlPTService.GetAll().FirstOrDefault(p => p.IdKH == IdKHInPT).TenKH;
                    listItems2[count2].TTDonDep = "Phòng đang có khách";
                    listItems2[count2].IdPTCT = _iqlCTPTService.GetAll().FirstOrDefault(p => p.IdPhong == item.Id && p.NgayBatDau - DateTime.Now <= oneHour).ID;
                }
                else if (item.TinhTrang == 2) // dang don dep
                {
                    listItems2[count2].BackColor = Color.Yellow;
                    listItems2[count2].TenKH = "Phòng trống";
                    listItems2[count2].TTDonDep = "Phòng đang dọn dẹp";
                    listItems2[count2].IdPTCT = Guid.Empty;
                }
                else if (item.TinhTrang == 3) // Phong sap co khach thue trong vong 1 tieng
                {
                    listItems2[count2].BackColor = Color.LightGray;
                    IdKHInPT = _iqlCTPTService.GetAll().FirstOrDefault(p => p.IdPhong == item.Id).IdKH;
                    listItems2[count2].TenKH = _iqlPTService.GetAll().FirstOrDefault(p => p.IdKH == IdKHInPT).TenKH;
                    listItems2[count2].TTDonDep = "Phòng đã dọn dẹp";
                    listItems2[count2].IdPTCT = _iqlCTPTService.GetAll().FirstOrDefault(p => p.IdPhong == item.Id && p.NgayBatDau - DateTime.Now <= oneHour).ID;
                }
                else // phong trong
                {
                    listItems2[count2].BackColor = Color.Green;
                    listItems2[count2].TenKH = "Phòng trống";
                    listItems2[count2].TTDonDep = "Phòng đã dọn dẹp";
                    listItems2[count2].IdPTCT = Guid.Empty;

                }

                if (flp_PhongTang2.Controls.Count < 0)
                {
                    flp_PhongTang2.Controls.Clear();
                }
                else
                {
                    flp_PhongTang2.Controls.Add(listItems2[count2]);
                }
                count2++;
                if (count2 == lstPhongTang2.Count)
                {
                    count2 = 0;
                }
            }
            #endregion

            #region Tang3
            var lstPhongTang3 = _iqlPhongService.GetAll().Where(p => p.MaPhong.Substring(1, 1) == "3").ToList();
            ListItemRooms[] listItems3 = new ListItemRooms[lstPhongTang1.Count];
            int count3 = 0;
            foreach (var item in lstPhongTang3)
            {
                listItems3[count3] = new ListItemRooms();
                listItems3[count3].MaPhong = item.MaPhong;
                listItems3[count3].TenLoaiPhong = item.TenLoaiPhong;
                listItems3[count3].IdPhong = Convert.ToString(item.Id);

                if (item.TinhTrang == 1)    // co khach su dung
                {
                    listItems3[count3].BackColor = Color.Red;
                    IdKHInPT = _iqlCTPTService.GetAll().FirstOrDefault(p => p.IdPhong == item.Id).IdKH;
                    listItems3[count3].TenKH = _iqlPTService.GetAll().FirstOrDefault(p => p.IdKH == IdKHInPT).TenKH;
                    listItems3[count3].TTDonDep = "Phòng đang có khách";
                    listItems3[count3].IdPTCT = _iqlCTPTService.GetAll().FirstOrDefault(p => p.IdPhong == item.Id && p.NgayBatDau - DateTime.Now <= oneHour).ID;
                }
                else if (item.TinhTrang == 2) // dang don dep
                {
                    listItems3[count3].BackColor = Color.Yellow;
                    listItems3[count3].TenKH = "Phòng trống";
                    listItems3[count3].TTDonDep = "Phòng đang dọn dẹp";
                    listItems3[count3].IdPTCT = Guid.Empty;
                }
                else if (item.TinhTrang == 3) // Phong sap co khach thue trong vong 1 tieng
                {
                    listItems3[count3].BackColor = Color.LightGray;
                    IdKHInPT = _iqlCTPTService.GetAll().FirstOrDefault(p => p.IdPhong == item.Id).IdKH;
                    listItems3[count3].TenKH = _iqlPTService.GetAll().FirstOrDefault(p => p.IdKH == IdKHInPT).TenKH;
                    listItems3[count3].TTDonDep = "Phòng đã dọn dẹp";
                    listItems3[count3].IdPTCT = _iqlCTPTService.GetAll().FirstOrDefault(p => p.IdPhong == item.Id && p.NgayBatDau - DateTime.Now <= oneHour).ID;
                }
                else // phong trong
                {
                    listItems3[count3].BackColor = Color.Green;
                    listItems3[count3].TenKH = "Phòng trống";
                    listItems3[count3].TTDonDep = "Phòng đã dọn dẹp";
                    listItems3[count3].IdPTCT = Guid.Empty;

                }

                if (flp_PhongTang3.Controls.Count < 0)
                {
                    flp_PhongTang3.Controls.Clear();
                }
                else
                {
                    flp_PhongTang3.Controls.Add(listItems3[count3]);
                }
                count3++;
                if (count3 == lstPhongTang3.Count)
                {
                    count3 = 0;
                }
            }
            #endregion
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            var lstPhongTT0 = _iqlPhongService.GetAll().Where(p => p.TinhTrang == 0);
            foreach (var item in lstPhongTT0)
            {              
                var lstCTPT = _iqlCTPTService.GetAll().FirstOrDefault(p => p.IdPhong == item.Id);
                if (lstCTPT == null)
                {
                    
                }
                else if (lstCTPT.NgayBatDau - now <= oneHour && lstCTPT.NgayBatDau - now > zeroHour)
                {
                    PhongView pv = new PhongView();
                    pv.Id = item.Id;
                    pv.MaPhong = item.MaPhong;
                    pv.IDLoaiPhong = item.IDLoaiPhong;
                    pv.TinhTrang = 3;
                    _iqlPhongService.Update(pv);
                }
                
            }

            //foreach (var item in lstCTPT)
            //{
               // DateTime now = DateTime.Now;
                // Dat phong
                
                //  gio hien tai < gio bat dau
                //if (item.NgayBatDau - now <= oneHour && item.NgayBatDau - now > zeroHour)
                //{                
                //    PhongView pv = new PhongView();
                //    pv.Id = item.IdPhong;
                //    pv.MaPhong = item.MaPhong;
                //    pv.IDLoaiPhong = _iqlPhongService.GetAll().FirstOrDefault(p => p.Id == item.IdPhong).IDLoaiPhong;
                //    pv.TinhTrang = 3;
                //    _iqlPhongService.Update(pv);
                //}

                // Gio hien tai > gio bat dau
                //if ( item.NgayBatDau - now < zeroHour)
                //{
                //    PhongView pv = new PhongView();
                //    pv.Id = item.IdPhong;
                //    pv.MaPhong = item.MaPhong;
                //    pv.IDLoaiPhong = _iqlPhongService.GetAll().FirstOrDefault(p => p.Id == item.IdPhong).IDLoaiPhong;
                //    pv.TinhTrang = 3;
                //    _iqlPhongService.Update(pv);
                //}
                // Nhan phong
                // Tra phong
            //}
            LoadItemRooms();
        }
    }
}
