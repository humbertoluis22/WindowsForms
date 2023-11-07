using CursoWindowsFormsBiblioteca;
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
        int ControleArquivoImagem = 0;


        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
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
            TB.Name = "Hello Word " + ControleHelloWord;
            TB.Text = "Hello Word " + ControleHelloWord;
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

            Frm_ValidaCPF_UC U = new Frm_ValidaCPF_UC();
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

            Frm_ValidaCpf2_UC U = new Frm_ValidaCpf2_UC();
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

            ControleSenha += 1;

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

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog Db = new OpenFileDialog();
            Db.InitialDirectory = "C:\\Users\\Humberto\\Desktop\\WindowsForms\\WindowsForms\\WindowsForms\\CursoWindowsForms2\\imagens\\icons8-folder.png\"";
            Db.Filter = "PNG|*.PNG";
            Db.Title = "Escolha a Imagem";

            if (Db.ShowDialog() == DialogResult.OK)
            {

                string nomeArquivoImagem = Db.FileName;


                ControleArquivoImagem += 1;
                Frm_ArquivoImagem_UC U = new Frm_ArquivoImagem_UC(nomeArquivoImagem);
                TabPage TB = new TabPage();
                U.Dock = DockStyle.Fill;
                TB.Name = "Arquivo Imagem" + ControleArquivoImagem;
                TB.Text = "Arquivo Imagem" + ControleArquivoImagem;
                TB.ImageIndex = 6;
                TB.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }


        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login f = new Frm_Login();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {

                string senha = f.senha;
                string login = f.login;

                if (CursoWindowsFormsBiblioteca.Cls_Uteis.validaSenhaLogin(senha) == true)
                {
                    novoToolStripMenuItem.Enabled = true;
                    apagarAbaToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;

                    MessageBox.Show("bem vindo " + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha invalida !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }

        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao Db = new Frm_Questao("question1", "voce deseja se desconectar?");
            Db.ShowDialog();
            // if (MessageBox.Show("Você deseja validar o CPF? ", "mensagem de validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)


            if (Db.DialogResult == DialogResult.Yes)
            {

                //Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);

                for(int i = Tbc_Aplicacoes.TabPages.Count -1 ; i >= 0; i+=-1)
                {
                    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
                }
                

                novoToolStripMenuItem.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = false;

            }

        }
    }
}
