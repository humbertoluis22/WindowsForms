﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms2
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_DemostracaoKey_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey f = new Frm_DemonstracaoKey();
            f.ShowDialog();
        }
    }
}
