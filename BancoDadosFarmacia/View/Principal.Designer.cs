﻿namespace View
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
            this.btnRemedios = new System.Windows.Forms.Button();
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
            // btnRemedios
            // 
            this.btnRemedios.Location = new System.Drawing.Point(33, 223);
            this.btnRemedios.Name = "btnRemedios";
            this.btnRemedios.Size = new System.Drawing.Size(187, 77);
            this.btnRemedios.TabIndex = 0;
            this.btnRemedios.Text = "Cadastro Remédios";
            this.btnRemedios.UseVisualStyleBackColor = true;
            this.btnRemedios.Click += new System.EventHandler(this.button3_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 368);
            this.Controls.Add(this.btnRemedios);
            this.Controls.Add(this.bntHigiene);
            this.Controls.Add(this.btnComestiveis);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComestiveis;
        private System.Windows.Forms.Button bntHigiene;
        private System.Windows.Forms.Button btnRemedios;
    }
}