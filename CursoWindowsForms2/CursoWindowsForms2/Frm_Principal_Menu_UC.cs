using System;
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
    public partial class Frm_Principal_Menu_UC : Form
    {
        int ControleHelloWord = 0;
        int ControleDemostracaoKey = 0;
        int ControleMascara = 0;
        int ControleCPF = 0;
        int ControleCPF2 = 0;
        int ControleSenha = 0;
        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
        }
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWord += 1;

            Frm_DemostracaoKey_UC U = new Frm_DemostracaoKey_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "demostração key" + ControleDemostracaoKey;
            TB.Text = "demostração key " + ControleDemostracaoKey;
            TB.ImageIndex = 0;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB); 
            Frm_DemonstracaoKey f = new Frm_DemonstracaoKey();
            f.ShowDialog();
        }

        private void helloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWord += 1;

            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();
            TabPage TB = new TabPage();
            U.Dock = DockStyle.Fill;
            TB.Name = "Hello Word "  + ControleHelloWord;
            TB.Text = "Hello Word "  + ControleHelloWord;
            TB.ImageIndex = 1;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara += 1;

            Frm_Mascara_UC U = new Frm_Mascara_UC();
            TabPage TB = new TabPage();
            U.Dock = DockStyle.Fill;
            TB.Name = "Mascara " + ControleMascara;
            TB.Text = "Mascara " + ControleMascara;
            TB.ImageIndex = 2;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleCPF += 1;

            Frm_ValidaCPF U = new Frm_ValidaCPF();
            TabPage TB = new TabPage();
            U.Dock = DockStyle.Fill;
            TB.Name = "Valida CPF " + ControleCPF;
            TB.Text = "Valida CPF" + ControleCPF;
            TB.ImageIndex = 3;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleCPF2 += 1;

            Frm_ValidaCPF2 U = new Frm_ValidaCPF2();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            
            TB.Name = "Valida CPF " + ControleCPF2;
            TB.Text = "Valida CPF" + ControleCPF2;
            TB.ImageIndex = 4;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha f = new Frm_ValidaSenha();
            f.ShowDialog();

            ControleSenha+= 1;

            Frm_ValidaSenha U = new Frm_ValidaSenha();
            TabPage TB = new TabPage();
            U.Dock = DockStyle.Fill;
            TB.Name = "Valida senha " + ControleSenha;
            TB.Text = "Valida senha" + ControleSenha;
            TB.ImageIndex = 5;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null)) 
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
            
        }
    }
}
