namespace View.CadastroRemedios
{
    partial class CadastroProdutoRemedios
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.ckbGenerico = new System.Windows.Forms.CheckBox();
            this.ckbSolido = new System.Windows.Forms.CheckBox();
            this.ckbReceita = new System.Windows.Forms.CheckBox();
            this.lblFaixa = new System.Windows.Forms.Label();
            this.cbFaixa = new System.Windows.Forms.ComboBox();
            this.rtbBula = new System.Windows.Forms.RichTextBox();
            this.lblContraIndicacao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(23, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(26, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(131, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(23, 132);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Analgésico",
            "Anfetamina",
            "Antiácido",
            "Antibiótico",
            "Antídoto",
            "Aspirina",
            "Barbitúrico"});
            this.cbCategoria.Location = new System.Drawing.Point(26, 148);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(131, 21);
            this.cbCategoria.TabIndex = 5;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(23, 77);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(26, 94);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(131, 20);
            this.txtPreco.TabIndex = 3;
            // 
            // ckbGenerico
            // 
            this.ckbGenerico.AutoSize = true;
            this.ckbGenerico.Location = new System.Drawing.Point(26, 243);
            this.ckbGenerico.Name = "ckbGenerico";
            this.ckbGenerico.Size = new System.Drawing.Size(69, 17);
            this.ckbGenerico.TabIndex = 8;
            this.ckbGenerico.Text = "Genérico";
            this.ckbGenerico.UseVisualStyleBackColor = true;
            // 
            // ckbSolido
            // 
            this.ckbSolido.AutoSize = true;
            this.ckbSolido.Location = new System.Drawing.Point(26, 277);
            this.ckbSolido.Name = "ckbSolido";
            this.ckbSolido.Size = new System.Drawing.Size(55, 17);
            this.ckbSolido.TabIndex = 9;
            this.ckbSolido.Text = "Sólido";
            this.ckbSolido.UseVisualStyleBackColor = true;
            // 
            // ckbReceita
            // 
            this.ckbReceita.AutoSize = true;
            this.ckbReceita.Location = new System.Drawing.Point(26, 310);
            this.ckbReceita.Name = "ckbReceita";
            this.ckbReceita.Size = new System.Drawing.Size(116, 17);
            this.ckbReceita.TabIndex = 10;
            this.ckbReceita.Text = "Precisa de Receita";
            this.ckbReceita.UseVisualStyleBackColor = true;
            // 
            // lblFaixa
            // 
            this.lblFaixa.AutoSize = true;
            this.lblFaixa.Location = new System.Drawing.Point(23, 184);
            this.lblFaixa.Name = "lblFaixa";
            this.lblFaixa.Size = new System.Drawing.Size(31, 13);
            this.lblFaixa.TabIndex = 6;
            this.lblFaixa.Text = "Tarja";
            // 
            // cbFaixa
            // 
            this.cbFaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFaixa.FormattingEnabled = true;
            this.cbFaixa.Items.AddRange(new object[] {
            "Sem Faixa",
            "Amarela",
            "Vermelha",
            "Preta"});
            this.cbFaixa.Location = new System.Drawing.Point(26, 200);
            this.cbFaixa.Name = "cbFaixa";
            this.cbFaixa.Size = new System.Drawing.Size(131, 21);
            this.cbFaixa.TabIndex = 7;
            // 
            // rtbBula
            // 
            this.rtbBula.Location = new System.Drawing.Point(179, 44);
            this.rtbBula.Name = "rtbBula";
            this.rtbBula.Size = new System.Drawing.Size(166, 177);
            this.rtbBula.TabIndex = 12;
            this.rtbBula.Text = "";
            // 
            // lblContraIndicacao
            // 
            this.lblContraIndicacao.AutoSize = true;
            this.lblContraIndicacao.Location = new System.Drawing.Point(176, 28);
            this.lblContraIndicacao.Name = "lblContraIndicacao";
            this.lblContraIndicacao.Size = new System.Drawing.Size(93, 13);
            this.lblContraIndicacao.TabIndex = 11;
            this.lblContraIndicacao.Text = "Contra Indicações";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightGreen;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(215, 257);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 37);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(23, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Código:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(64, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "0";
            // 
            // CadastroProdutoRemedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 354);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.rtbBula);
            this.Controls.Add(this.ckbReceita);
            this.Controls.Add(this.ckbSolido);
            this.Controls.Add(this.ckbGenerico);
            this.Controls.Add(this.cbFaixa);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblFaixa);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblContraIndicacao);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroProdutoRemedios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroRemedios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.CheckBox ckbGenerico;
        private System.Windows.Forms.CheckBox ckbSolido;
        private System.Windows.Forms.CheckBox ckbReceita;
        private System.Windows.Forms.Label lblFaixa;
        private System.Windows.Forms.ComboBox cbFaixa;
        private System.Windows.Forms.RichTextBox rtbBula;
        private System.Windows.Forms.Label lblContraIndicacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblID;
    }
}