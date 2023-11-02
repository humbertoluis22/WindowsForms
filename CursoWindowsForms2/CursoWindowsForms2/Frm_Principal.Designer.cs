namespace CursoWindowsForms2
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_DemostracaoKey = new System.Windows.Forms.Button();
            this.Btn_HelloWord = new System.Windows.Forms.Button();
            this.Btn_Mascara = new System.Windows.Forms.Button();
            this.Btn_ValidaCPF = new System.Windows.Forms.Button();
            this.Btn_ValidaCPF2 = new System.Windows.Forms.Button();
            this.Btn_ValidaSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_DemostracaoKey
            // 
            this.Btn_DemostracaoKey.Location = new System.Drawing.Point(12, 12);
            this.Btn_DemostracaoKey.Name = "Btn_DemostracaoKey";
            this.Btn_DemostracaoKey.Size = new System.Drawing.Size(114, 48);
            this.Btn_DemostracaoKey.TabIndex = 0;
            this.Btn_DemostracaoKey.Text = "Demonstração Key";
            this.Btn_DemostracaoKey.UseVisualStyleBackColor = true;
            this.Btn_DemostracaoKey.Click += new System.EventHandler(this.Btn_DemostracaoKey_Click);
            // 
            // Btn_HelloWord
            // 
            this.Btn_HelloWord.Location = new System.Drawing.Point(132, 12);
            this.Btn_HelloWord.Name = "Btn_HelloWord";
            this.Btn_HelloWord.Size = new System.Drawing.Size(114, 48);
            this.Btn_HelloWord.TabIndex = 1;
            this.Btn_HelloWord.Text = "Hello Word";
            this.Btn_HelloWord.UseVisualStyleBackColor = true;
            // 
            // Btn_Mascara
            // 
            this.Btn_Mascara.Location = new System.Drawing.Point(252, 12);
            this.Btn_Mascara.Name = "Btn_Mascara";
            this.Btn_Mascara.Size = new System.Drawing.Size(114, 48);
            this.Btn_Mascara.TabIndex = 2;
            this.Btn_Mascara.Text = "Mascara";
            this.Btn_Mascara.UseVisualStyleBackColor = true;
            // 
            // Btn_ValidaCPF
            // 
            this.Btn_ValidaCPF.Location = new System.Drawing.Point(12, 66);
            this.Btn_ValidaCPF.Name = "Btn_ValidaCPF";
            this.Btn_ValidaCPF.Size = new System.Drawing.Size(114, 48);
            this.Btn_ValidaCPF.TabIndex = 3;
            this.Btn_ValidaCPF.Text = "Valida CPF";
            this.Btn_ValidaCPF.UseVisualStyleBackColor = true;
            // 
            // Btn_ValidaCPF2
            // 
            this.Btn_ValidaCPF2.Location = new System.Drawing.Point(132, 66);
            this.Btn_ValidaCPF2.Name = "Btn_ValidaCPF2";
            this.Btn_ValidaCPF2.Size = new System.Drawing.Size(114, 48);
            this.Btn_ValidaCPF2.TabIndex = 4;
            this.Btn_ValidaCPF2.Text = "Valida CPF2";
            this.Btn_ValidaCPF2.UseVisualStyleBackColor = true;
            // 
            // Btn_ValidaSenha
            // 
            this.Btn_ValidaSenha.Location = new System.Drawing.Point(252, 66);
            this.Btn_ValidaSenha.Name = "Btn_ValidaSenha";
            this.Btn_ValidaSenha.Size = new System.Drawing.Size(114, 48);
            this.Btn_ValidaSenha.TabIndex = 5;
            this.Btn_ValidaSenha.Text = "Valida Senha";
            this.Btn_ValidaSenha.UseVisualStyleBackColor = true;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 126);
            this.Controls.Add(this.Btn_ValidaSenha);
            this.Controls.Add(this.Btn_ValidaCPF2);
            this.Controls.Add(this.Btn_ValidaCPF);
            this.Controls.Add(this.Btn_Mascara);
            this.Controls.Add(this.Btn_HelloWord);
            this.Controls.Add(this.Btn_DemostracaoKey);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_DemostracaoKey;
        private System.Windows.Forms.Button Btn_HelloWord;
        private System.Windows.Forms.Button Btn_Mascara;
        private System.Windows.Forms.Button Btn_ValidaCPF;
        private System.Windows.Forms.Button Btn_ValidaCPF2;
        private System.Windows.Forms.Button Btn_ValidaSenha;
    }
}