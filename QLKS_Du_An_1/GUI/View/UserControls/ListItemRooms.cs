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
    public partial class ListItemRooms : UserControl
    {
        public ListItemRooms()
        {
            InitializeComponent();
            lb_IdRoom.Visible = false;
        }

        public string IdPhong
        { 
            get { return lb_IdRoom.Text;  }
            set { lb_IdRoom.Text = value; }
        }
 

        public string MaPhong
        {
            get { return lb_MaPhong.Text; }
            set  {   lb_MaPhong.Text = value; }
        }

        public string TenKH
        {
            get { return lb_TenKH.Text; }
            set { lb_TenKH.Text = value; }
        }

        public string TenLoaiPhong
        {
            get { return lb_TenLoaiPhong.Text; }
            set { lb_TenLoaiPhong.Text = value; }
        }
        

        public string TTPhongThue
        {
            get { return lb_TTPhongThue.Text; }
            set { lb_TTPhongThue.Text = value; }
        }

        public string TTDonDep
        {
            get { return lb_DonDep.Text; }
            set { lb_DonDep.Text = value; }
        }
    }
}
