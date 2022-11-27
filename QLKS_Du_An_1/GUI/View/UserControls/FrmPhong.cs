using BUS.IServices;
using BUS.Services;
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
        public FrmPhong()
        {
            InitializeComponent();
            _iqlPhongService = new IPhongService();
            _iqlListRoomService = new QLListItemRoomViewService();
        }

        private void FrmPhong_Load(object sender, EventArgs e)
        {
            LoadItemRooms();
        }

        private void LoadItemRooms()
        {
            var lstPhongTang1 = _iqlPhongService.GetAll().Where(p => p.MaPhong.Substring(1, 1) == "1").ToList();
            ListItemRooms[] listItems1 = new ListItemRooms[lstPhongTang1.Count];
            int count1 = 0;
            foreach (var item in lstPhongTang1)
            {
                listItems1[count1] = new ListItemRooms();
                listItems1[count1].MaPhong = item.MaPhong;
                listItems1[count1].TenLoaiPhong = item.TenLoaiPhong;
                listItems1[count1].IdPhong = Convert.ToString(item.Id);
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
            
            var lstPhongTang2 = _iqlPhongService.GetAll().Where(p => p.MaPhong.Substring(1, 1) == "2").ToList();
            ListItemRooms[] listItems2 = new ListItemRooms[lstPhongTang2.Count];
            int count2 = 0;
            foreach (var item in lstPhongTang2)
            {
                listItems2[count2] = new ListItemRooms();
                listItems2[count2].MaPhong = item.MaPhong;
                listItems2[count2].TenLoaiPhong = item.TenLoaiPhong;
                listItems2[count2].IdPhong = Convert.ToString(item.Id);
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

            var lstPhongTang3 = _iqlPhongService.GetAll().Where(p => p.MaPhong.Substring(1, 1) == "3").ToList();
            ListItemRooms[] listItems3 = new ListItemRooms[lstPhongTang1.Count];
            int count3 = 0;
            foreach (var item in lstPhongTang3)
            {
                listItems3[count3] = new ListItemRooms();
                listItems3[count3].MaPhong = item.MaPhong;
                listItems3[count3].TenLoaiPhong = item.TenLoaiPhong;
                listItems3[count3].IdPhong = Convert.ToString(item.Id);
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
        }
    }
}
