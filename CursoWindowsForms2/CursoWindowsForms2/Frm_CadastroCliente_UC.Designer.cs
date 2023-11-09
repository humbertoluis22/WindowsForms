namespace CursoWindowsForms2
{
    partial class Frm_CadastroCliente_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Txt_CPF = new System.Windows.Forms.TextBox();
            this.Lbl_NomeCliente = new System.Windows.Forms.Label();
            this.Txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Location = new System.Drawing.Point(12, 14);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(35, 13);
            this.Lbl_CPF.TabIndex = 0;
            this.Lbl_CPF.Text = "label1";
            // 
            // Txt_CPF
            // 
            this.Txt_CPF.Location = new System.Drawing.Point(12, 30);
            this.Txt_CPF.Name = "Txt_CPF";
            this.Txt_CPF.Size = new System.Drawing.Size(268, 20);
            this.Txt_CPF.TabIndex = 1;
            // 
            // Lbl_NomeCliente
            // 
            this.Lbl_NomeCliente.AutoSize = true;
            this.Lbl_NomeCliente.Location = new System.Drawing.Point(12, 54);
            this.Lbl_NomeCliente.Name = "Lbl_NomeCliente";
            this.Lbl_NomeCliente.Size = new System.Drawing.Size(35, 13);
            this.Lbl_NomeCliente.TabIndex = 2;
            this.Lbl_NomeCliente.Text = "label1";
            // 
            // Txt_NomeCliente
            // 
            this.Txt_NomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeCliente.Location = new System.Drawing.Point(12, 70);
            this.Txt_NomeCliente.Name = "Txt_NomeCliente";
            this.Txt_NomeCliente.Size = new System.Drawing.Size(787, 20);
            this.Txt_NomeCliente.TabIndex = 3;
            // 
            // Frm_CadastroCliente_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_NomeCliente);
            this.Controls.Add(this.Lbl_NomeCliente);
            this.Controls.Add(this.Txt_CPF);
            this.Controls.Add(this.Lbl_CPF);
            this.Name = "Frm_CadastroCliente_UC";
            this.Size = new System.Drawing.Size(806, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.TextBox Txt_CPF;
        private System.Windows.Forms.Label Lbl_NomeCliente;
        private System.Windows.Forms.TextBox Txt_NomeCliente;
    }
}
