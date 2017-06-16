namespace WindowsFormsApplication
{
    partial class FormCadastroSoftware
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
            this.lbErroFornecedor = new System.Windows.Forms.Label();
            this.lbErroTecnologia = new System.Windows.Forms.Label();
            this.lbErroNome = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataInsercao = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtTecnologia = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigoSoftware = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbErroFornecedor
            // 
            this.lbErroFornecedor.AutoSize = true;
            this.lbErroFornecedor.ForeColor = System.Drawing.Color.Red;
            this.lbErroFornecedor.Location = new System.Drawing.Point(242, 181);
            this.lbErroFornecedor.Name = "lbErroFornecedor";
            this.lbErroFornecedor.Size = new System.Drawing.Size(92, 13);
            this.lbErroFornecedor.TabIndex = 12;
            this.lbErroFornecedor.Text = "Campo obrigatório";
            this.lbErroFornecedor.Visible = false;
            // 
            // lbErroTecnologia
            // 
            this.lbErroTecnologia.AutoSize = true;
            this.lbErroTecnologia.ForeColor = System.Drawing.Color.Red;
            this.lbErroTecnologia.Location = new System.Drawing.Point(242, 128);
            this.lbErroTecnologia.Name = "lbErroTecnologia";
            this.lbErroTecnologia.Size = new System.Drawing.Size(92, 13);
            this.lbErroTecnologia.TabIndex = 11;
            this.lbErroTecnologia.Text = "Campo obrigatório";
            this.lbErroTecnologia.Visible = false;
            // 
            // lbErroNome
            // 
            this.lbErroNome.AutoSize = true;
            this.lbErroNome.ForeColor = System.Drawing.Color.Red;
            this.lbErroNome.Location = new System.Drawing.Point(242, 77);
            this.lbErroNome.Name = "lbErroNome";
            this.lbErroNome.Size = new System.Drawing.Size(92, 13);
            this.lbErroNome.TabIndex = 10;
            this.lbErroNome.Text = "Campo obrigatório";
            this.lbErroNome.Visible = false;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(259, 248);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tecnlogia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fornecedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Software";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Data de Inclusão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código do Software";
            // 
            // txtDataInsercao
            // 
            this.txtDataInsercao.Enabled = false;
            this.txtDataInsercao.Location = new System.Drawing.Point(127, 42);
            this.txtDataInsercao.Name = "txtDataInsercao";
            this.txtDataInsercao.Size = new System.Drawing.Size(123, 20);
            this.txtDataInsercao.TabIndex = 1;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(12, 197);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(322, 20);
            this.txtFornecedor.TabIndex = 4;
            this.txtFornecedor.TextChanged += new System.EventHandler(this.txtFornecedor_TextChanged);
            // 
            // txtTecnologia
            // 
            this.txtTecnologia.Location = new System.Drawing.Point(12, 144);
            this.txtTecnologia.Name = "txtTecnologia";
            this.txtTecnologia.Size = new System.Drawing.Size(319, 20);
            this.txtTecnologia.TabIndex = 3;
            this.txtTecnologia.TextChanged += new System.EventHandler(this.txtTecnologia_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(322, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtCodigoSoftware
            // 
            this.txtCodigoSoftware.Enabled = false;
            this.txtCodigoSoftware.Location = new System.Drawing.Point(12, 42);
            this.txtCodigoSoftware.Name = "txtCodigoSoftware";
            this.txtCodigoSoftware.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoSoftware.TabIndex = 0;
            // 
            // FormCadastroSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 296);
            this.Controls.Add(this.lbErroFornecedor);
            this.Controls.Add(this.lbErroTecnologia);
            this.Controls.Add(this.lbErroNome);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataInsercao);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtTecnologia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigoSoftware);
            this.Name = "FormCadastroSoftware";
            this.Text = "Cadastro de Software";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadastroSoftware_FormClosing);
            this.Load += new System.EventHandler(this.FormCadastroSoftware_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoSoftware;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTecnologia;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtDataInsercao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label lbErroNome;
        private System.Windows.Forms.Label lbErroTecnologia;
        private System.Windows.Forms.Label lbErroFornecedor;
    }
}