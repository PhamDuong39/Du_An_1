﻿using GUI.View.AddControls;
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
    public partial class FrmDatPhong : Form
    {
        public FrmDatPhong()
        {
            InitializeComponent();
        }

        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            FrmBtnDatPhong btnDatphong = new FrmBtnDatPhong();
            btnDatphong.ShowDialog();
        }
    }
}
