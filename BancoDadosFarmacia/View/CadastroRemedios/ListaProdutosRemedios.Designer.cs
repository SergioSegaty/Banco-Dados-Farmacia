namespace View.CadastroRemedios
{
    partial class ListaProdutosRemedios
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
            this.dgvRemedios = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReceita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntCadastrar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemedios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRemedios
            // 
            this.dgvRemedios.AllowUserToAddRows = false;
            this.dgvRemedios.AllowUserToDeleteRows = false;
            this.dgvRemedios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemedios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnPreco,
            this.ColumnFaixa,
            this.ColumnReceita});
            this.dgvRemedios.Location = new System.Drawing.Point(12, 66);
            this.dgvRemedios.MultiSelect = false;
            this.dgvRemedios.Name = "dgvRemedios";
            this.dgvRemedios.ReadOnly = true;
            this.dgvRemedios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemedios.Size = new System.Drawing.Size(497, 268);
            this.dgvRemedios.TabIndex = 0;
            this.dgvRemedios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRemedios_CellDoubleClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Código";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 45;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.HeaderText = "Preço";
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.ReadOnly = true;
            // 
            // ColumnFaixa
            // 
            this.ColumnFaixa.HeaderText = "Tarja";
            this.ColumnFaixa.Name = "ColumnFaixa";
            this.ColumnFaixa.ReadOnly = true;
            // 
            // ColumnReceita
            // 
            this.ColumnReceita.HeaderText = "Necessario Receita?";
            this.ColumnReceita.Name = "ColumnReceita";
            this.ColumnReceita.ReadOnly = true;
            // 
            // bntCadastrar
            // 
            this.bntCadastrar.BackColor = System.Drawing.Color.LightGreen;
            this.bntCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCadastrar.Location = new System.Drawing.Point(12, 27);
            this.bntCadastrar.Name = "bntCadastrar";
            this.bntCadastrar.Size = new System.Drawing.Size(77, 33);
            this.bntCadastrar.TabIndex = 1;
            this.bntCadastrar.Text = "Cadastrar";
            this.bntCadastrar.UseVisualStyleBackColor = false;
            this.bntCadastrar.Click += new System.EventHandler(this.bntCadastrar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Salmon;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Location = new System.Drawing.Point(432, 27);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(77, 33);
            this.btnDeletar.TabIndex = 1;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // ListaProdutosRemedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 346);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.bntCadastrar);
            this.Controls.Add(this.dgvRemedios);
            this.Name = "ListaProdutosRemedios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaProdutosRemedios";
            this.Activated += new System.EventHandler(this.ListaProdutosRemedios_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemedios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRemedios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReceita;
        private System.Windows.Forms.Button bntCadastrar;
        private System.Windows.Forms.Button btnDeletar;
    }
}