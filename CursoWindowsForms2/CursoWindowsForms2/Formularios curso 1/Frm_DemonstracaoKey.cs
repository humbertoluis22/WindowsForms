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
    public partial class Frm_DemonstracaoKey : Form
    {
        public Frm_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_msg.AppendText("\r\n"+ "pressionei uma tecla: " + e.KeyCode +"\r\n");
            Txt_msg.AppendText("\t" + "codigo da telca: " + ((int)e.KeyCode) + "\r\n" );
            Txt_msg.AppendText("\t" + "nome da tecla: " + e.KeyData + "\r\n");
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
        }

        private void Txt_Input_Click(object sender, EventArgs e)
        {
            Txt_msg.Text = "";
            Txt_Input.Text = "";
            Lbl_Upper.Text = "";
            Lbl_Minus.Text = "";
        }

        private void Frm_DemonstracaoKey_Load(object sender, EventArgs e)
        {

        }
    }
}
