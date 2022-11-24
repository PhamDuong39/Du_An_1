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
        public FrmPhong()
        {
            InitializeComponent();
            _iqlPhongService = new IPhongService();
        }

        private void FrmPhong_Load(object sender, EventArgs e)
        {
            LoadItemRooms();
        }

        private void LoadItemRooms()
        {

            var lstPhong = _iqlPhongService.GetAll();

            ListItemRooms[] listItems = new ListItemRooms[lstPhong.Count];
            int count = 0;
            foreach (var item in lstPhong)
            {
                listItems[count] = new ListItemRooms();
                listItems[count].MaPhong = item.MaPhong;

                if (flp_DanhSachPhongDon.Controls.Count < 0)
                {
                    flp_DanhSachPhongDon.Controls.Clear();
                }
                else
                {
                    flp_DanhSachPhongDon.Controls.Add(listItems[count]);
                }
                count++;
                if (count == lstPhong.Count - 1)
                {
                    return;
                }
            }
        }
    }
}
