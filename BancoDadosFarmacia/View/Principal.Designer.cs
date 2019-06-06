namespace View
{
    partial class Principal
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
            this.btnComestiveis = new System.Windows.Forms.Button();
            this.bntHigiene = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComestiveis
            // 
            this.btnComestiveis.Location = new System.Drawing.Point(33, 57);
            this.btnComestiveis.Name = "btnComestiveis";
            this.btnComestiveis.Size = new System.Drawing.Size(187, 77);
            this.btnComestiveis.TabIndex = 0;
            this.btnComestiveis.Text = "Cadastro Comestiveis";
            this.btnComestiveis.UseVisualStyleBackColor = true;
            this.btnComestiveis.Click += new System.EventHandler(this.btnComestiveis_Click);
            // 
            // bntHigiene
            // 
            this.bntHigiene.Location = new System.Drawing.Point(33, 140);
            this.bntHigiene.Name = "bntHigiene";
            this.bntHigiene.Size = new System.Drawing.Size(187, 77);
            this.bntHigiene.TabIndex = 0;
            this.bntHigiene.Text = "Cadastro Higiene";
            this.bntHigiene.UseVisualStyleBackColor = true;
            this.bntHigiene.Click += new System.EventHandler(this.bntHigiene_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 77);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 368);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bntHigiene);
            this.Controls.Add(this.btnComestiveis);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComestiveis;
        private System.Windows.Forms.Button bntHigiene;
        private System.Windows.Forms.Button button3;
    }
}