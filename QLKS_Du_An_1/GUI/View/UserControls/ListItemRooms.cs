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
        }

        public string MaPhong
        {
            get
            {
                return lb_MaPhong.Text;
            }
            set
            {
                lb_MaPhong.Text = value;
            }
        }
    }
}
