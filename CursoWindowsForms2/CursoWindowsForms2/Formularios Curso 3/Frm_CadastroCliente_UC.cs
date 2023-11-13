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
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();
            Grp_Codigo.Text = "Codigo";
            Grp_DadosPessoais.Text = "Dados Pessoais";
            Grp_Endereco.Text = "Endereço";
            Grp_Outros.Text = "Outros";
            Grp_Genero.Text = "Genero";
            Lbl_Cidade.Text = "Cidade";
            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Estado.Text = "Estado";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone.Text = "Telefone";
            Chk_TemPai.Text = "Pai desconhecido";
            Rdb_Masculino.Text = "Masculino";
            Rdb_Feminino.Text = "Feminino";
            Rdb_Indefinido.Text = "Indefinido";

            Cmb_Estados.Items.Clear();
            Cmb_Estados.Items.Add("Acre (AC)");
            Cmb_Estados.Items.Add("Alagoas(AL)");
            Cmb_Estados.Items.Add("Amapá(AP)");
            Cmb_Estados.Items.Add("Amazonas(AM)");
            Cmb_Estados.Items.Add("Bahia(BA)");
            Cmb_Estados.Items.Add("Ceará(CE)");
            Cmb_Estados.Items.Add("Distrito Federal(DF)");
            Cmb_Estados.Items.Add("Espírito Santo(ES)");
            Cmb_Estados.Items.Add("Goiás(GO)");
            Cmb_Estados.Items.Add("Maranhão(MA)");
            Cmb_Estados.Items.Add("Mato Grosso(MT)");
            Cmb_Estados.Items.Add("Mato Grosso do Sul(MS)");
            Cmb_Estados.Items.Add("Minas Gerais(MG)");
            Cmb_Estados.Items.Add("Pará(PA)");
            Cmb_Estados.Items.Add("Paraíba(PB)");
            Cmb_Estados.Items.Add("Paraná(PR)");
            Cmb_Estados.Items.Add("Pernambuco(PE)");
            Cmb_Estados.Items.Add("Piauí(PI)");
            Cmb_Estados.Items.Add("Rio de Janeiro(RJ)");
            Cmb_Estados.Items.Add("Rio Grande do Norte(RN)");
            Cmb_Estados.Items.Add("Rio Grande do Sul(RS)");
            Cmb_Estados.Items.Add("Rondônia(RO)");
            Cmb_Estados.Items.Add("Roraima(RR)");
            Cmb_Estados.Items.Add("Santa Catarina(SC)");
            Cmb_Estados.Items.Add("São Paulo(SP)");
            Cmb_Estados.Items.Add("Sergipe(SE)");
            Cmb_Estados.Items.Add("Tocantins(TO)");



            Tls_Principal.Items[0].ToolTipText = "Incluir na base de dados um novo cliente";
            Tls_Principal.Items[1].ToolTipText = "capturar um cliente ja cadastrada na base";
            Tls_Principal.Items[2].ToolTipText = "Atualize o cliente já existente";
            Tls_Principal.Items[3].ToolTipText = "Apaga o cliente selecionado";
            Tls_Principal.Items[4].ToolTipText = "Limpa dados da tela de entrada de  dados";
        }

        private void Lbl_CPF_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Lbl_NomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Profissao_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Profissao_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TemPai.Checked)
            {
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Txt_NomePai.Enabled=true;
            }
        }

        private void Rdb_Feminino_CheckedChanged(object sender, EventArgs e)
        {
     
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botao Novo ");
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botao ABRIR ");
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botao SALVAR ");
        }

        private void ApagatoolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botao EXCLUIR ");
        }

        private void LimpartoolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botao LIMPAR ");
        }
    }
}
