﻿namespace WindowsFormsApplication
{
    partial class FormCadastroQuestoes
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
            this.cbCaracteristica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSubCategoria = new System.Windows.Forms.Label();
            this.cbSubCararcteristica = new System.Windows.Forms.ComboBox();
            this.txtQuestao = new System.Windows.Forms.RichTextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.lbQuestao = new System.Windows.Forms.Label();
            this.lbTextoCaractereres = new System.Windows.Forms.Label();
            this.lbCaracteres = new System.Windows.Forms.Label();
            this.lbErroCaracteristica = new System.Windows.Forms.Label();
            this.lbErroSubCaracteristica = new System.Windows.Forms.Label();
            this.lbErroQuestao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCaracteristica
            // 
            this.cbCaracteristica.BackColor = System.Drawing.SystemColors.Window;
            this.cbCaracteristica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaracteristica.FormattingEnabled = true;
            this.cbCaracteristica.Location = new System.Drawing.Point(50, 53);
            this.cbCaracteristica.Name = "cbCaracteristica";
            this.cbCaracteristica.Size = new System.Drawing.Size(227, 21);
            this.cbCaracteristica.TabIndex = 0;
            this.cbCaracteristica.SelectedIndexChanged += new System.EventHandler(this.cbCaracteristica_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Característica";
            // 
            // lbSubCategoria
            // 
            this.lbSubCategoria.AutoSize = true;
            this.lbSubCategoria.Location = new System.Drawing.Point(47, 87);
            this.lbSubCategoria.Name = "lbSubCategoria";
            this.lbSubCategoria.Size = new System.Drawing.Size(95, 13);
            this.lbSubCategoria.TabIndex = 3;
            this.lbSubCategoria.Text = "Sub-Característica";
            this.lbSubCategoria.Visible = false;
            // 
            // cbSubCararcteristica
            // 
            this.cbSubCararcteristica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubCararcteristica.FormattingEnabled = true;
            this.cbSubCararcteristica.Location = new System.Drawing.Point(50, 103);
            this.cbSubCararcteristica.Name = "cbSubCararcteristica";
            this.cbSubCararcteristica.Size = new System.Drawing.Size(227, 21);
            this.cbSubCararcteristica.TabIndex = 2;
            this.cbSubCararcteristica.Visible = false;
            this.cbSubCararcteristica.SelectedIndexChanged += new System.EventHandler(this.cbSubCararcteristica_SelectedIndexChanged);
            // 
            // txtQuestao
            // 
            this.txtQuestao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQuestao.Location = new System.Drawing.Point(50, 160);
            this.txtQuestao.Name = "txtQuestao";
            this.txtQuestao.Size = new System.Drawing.Size(401, 115);
            this.txtQuestao.TabIndex = 4;
            this.txtQuestao.Text = "";
            this.txtQuestao.Visible = false;
            this.txtQuestao.TextChanged += new System.EventHandler(this.txtQuestao_TextChanged);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(376, 307);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // lbQuestao
            // 
            this.lbQuestao.AutoSize = true;
            this.lbQuestao.Location = new System.Drawing.Point(47, 144);
            this.lbQuestao.Name = "lbQuestao";
            this.lbQuestao.Size = new System.Drawing.Size(47, 13);
            this.lbQuestao.TabIndex = 6;
            this.lbQuestao.Text = "Questão";
            this.lbQuestao.Visible = false;
            // 
            // lbTextoCaractereres
            // 
            this.lbTextoCaractereres.AutoSize = true;
            this.lbTextoCaractereres.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTextoCaractereres.Location = new System.Drawing.Point(373, 278);
            this.lbTextoCaractereres.Name = "lbTextoCaractereres";
            this.lbTextoCaractereres.Size = new System.Drawing.Size(61, 13);
            this.lbTextoCaractereres.TabIndex = 7;
            this.lbTextoCaractereres.Text = "Caracteres:";
            this.lbTextoCaractereres.Visible = false;
            // 
            // lbCaracteres
            // 
            this.lbCaracteres.AutoSize = true;
            this.lbCaracteres.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCaracteres.Location = new System.Drawing.Point(440, 278);
            this.lbCaracteres.Name = "lbCaracteres";
            this.lbCaracteres.Size = new System.Drawing.Size(13, 13);
            this.lbCaracteres.TabIndex = 8;
            this.lbCaracteres.Text = "0";
            this.lbCaracteres.Visible = false;
            // 
            // lbErroCaracteristica
            // 
            this.lbErroCaracteristica.AutoSize = true;
            this.lbErroCaracteristica.ForeColor = System.Drawing.Color.Red;
            this.lbErroCaracteristica.Location = new System.Drawing.Point(283, 56);
            this.lbErroCaracteristica.Name = "lbErroCaracteristica";
            this.lbErroCaracteristica.Size = new System.Drawing.Size(92, 13);
            this.lbErroCaracteristica.TabIndex = 9;
            this.lbErroCaracteristica.Text = "Campo obrigatório";
            this.lbErroCaracteristica.Visible = false;
            // 
            // lbErroSubCaracteristica
            // 
            this.lbErroSubCaracteristica.AutoSize = true;
            this.lbErroSubCaracteristica.ForeColor = System.Drawing.Color.Red;
            this.lbErroSubCaracteristica.Location = new System.Drawing.Point(283, 106);
            this.lbErroSubCaracteristica.Name = "lbErroSubCaracteristica";
            this.lbErroSubCaracteristica.Size = new System.Drawing.Size(92, 13);
            this.lbErroSubCaracteristica.TabIndex = 9;
            this.lbErroSubCaracteristica.Text = "Campo obrigatório";
            this.lbErroSubCaracteristica.Visible = false;
            // 
            // lbErroQuestao
            // 
            this.lbErroQuestao.AutoSize = true;
            this.lbErroQuestao.ForeColor = System.Drawing.Color.Red;
            this.lbErroQuestao.Location = new System.Drawing.Point(47, 278);
            this.lbErroQuestao.Name = "lbErroQuestao";
            this.lbErroQuestao.Size = new System.Drawing.Size(92, 13);
            this.lbErroQuestao.TabIndex = 10;
            this.lbErroQuestao.Text = "Campo obrigatório";
            this.lbErroQuestao.Visible = false;
            // 
            // FormCadastroQuestoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 342);
            this.Controls.Add(this.lbErroQuestao);
            this.Controls.Add(this.lbErroSubCaracteristica);
            this.Controls.Add(this.lbErroCaracteristica);
            this.Controls.Add(this.lbCaracteres);
            this.Controls.Add(this.lbTextoCaractereres);
            this.Controls.Add(this.lbQuestao);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.txtQuestao);
            this.Controls.Add(this.lbSubCategoria);
            this.Controls.Add(this.cbSubCararcteristica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCaracteristica);
            this.Name = "FormCadastroQuestoes";
            this.Text = "Cadastro de Questões";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadastroQuestoes_FormClosing);
            this.Load += new System.EventHandler(this.FormCadastroQuestoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCaracteristica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSubCategoria;
        private System.Windows.Forms.ComboBox cbSubCararcteristica;
        private System.Windows.Forms.RichTextBox txtQuestao;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label lbQuestao;
        private System.Windows.Forms.Label lbTextoCaractereres;
        private System.Windows.Forms.Label lbCaracteres;
        private System.Windows.Forms.Label lbErroCaracteristica;
        private System.Windows.Forms.Label lbErroSubCaracteristica;
        private System.Windows.Forms.Label lbErroQuestao;
    }
}