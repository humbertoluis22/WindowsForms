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
    public partial class Frm_HelloWorld_UC : UserControl
    {
        public Frm_HelloWorld_UC()
        {
            InitializeComponent();
        }

        private void Btn_MoficaLabel_Click(object sender, EventArgs e)
        {
            Lbl_Titulo.Text = Txt_ConteudoLabel.Text;
        }
    }
}
