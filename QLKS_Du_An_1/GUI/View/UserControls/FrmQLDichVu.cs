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
    public partial class FrmQLDichVu : Form
    {
        public FrmQLDichVu()
        {
            InitializeComponent();
        }

        private void btn_ThemDichVu_Click(object sender, EventArgs e)
        {
            FrmBtnThemDichVu dv = new FrmBtnThemDichVu();
            dv.ShowDialog();
        }
    }
}
