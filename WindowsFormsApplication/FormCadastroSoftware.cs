using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary;

namespace WindowsFormsApplication
{
    public partial class FormCadastroSoftware : FormBase
    {
        protected override bool ValidaInatividade { get; set; }
        private Software softwareAtual = new Software();
        public FormCadastroSoftware(Software software)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.softwareAtual = software;
        }
        protected override void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.GetLastInputTime() >= this.tempoInativo && this.ValidaInatividade)
            {
                this.timer1.Stop();
                MessageBox.Show(this.mensagemDesconectado, "Inatividade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.timer1.Start();
                this.LimparCampos();
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {
                    this.softwareAtual.NomeSoftware = this.txtNome.Text.Trim();
                    this.softwareAtual.TecnologiaSoftware = this.txtTecnologia.Text.Trim();
                    this.softwareAtual.FornecedorSoftware = this.txtFornecedor.Text.Trim();
                    this.softwareAtual.Salvar();
                    MessageBox.Show("Software salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (this.softwareAtual.Id == 0)
                        this.LimparCampos();
                    else
                        this.Close();
                }
                else
                    MessageBox.Show("Campos obrigatórios não informados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um problema. Inclusão não realizada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LimparCampos();
            }
        }
        private void LimparCampos()
        {
            if (this.softwareAtual.Id == 0)
            {
                this.txtNome.Text = String.Empty;
                this.txtTecnologia.Text = String.Empty;
                this.txtFornecedor.Text = String.Empty;
                this.lbErroFornecedor.Visible = false;
                this.lbErroNome.Visible = false;
                this.lbErroTecnologia.Visible = false;
                this.txtNome.Focus();
            }
            else
                this.Close();
        }
        private bool validarCampos()
        {
            int camposEmBranco = 0;

            if (string.IsNullOrWhiteSpace(this.txtNome.Text))
            {
                this.lbErroNome.Visible = true;
                camposEmBranco++;
            }
            if (string.IsNullOrWhiteSpace(this.txtTecnologia.Text))
            {
                this.lbErroTecnologia.Visible = true;
                camposEmBranco++;
            }
            if (string.IsNullOrWhiteSpace(this.txtFornecedor.Text))
            {
                this.lbErroFornecedor.Visible = true;
                camposEmBranco++;
            }
            return camposEmBranco == 0;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            this.lbErroNome.Visible = false;
        }

        private void txtTecnologia_TextChanged(object sender, EventArgs e)
        {
            this.lbErroTecnologia.Visible = false;
        }

        private void txtFornecedor_TextChanged(object sender, EventArgs e)
        {
            this.lbErroFornecedor.Visible = false;
        }

        private void FormCadastroSoftware_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timer1.Dispose();
        }

        private void FormCadastroSoftware_Load(object sender, EventArgs e)
        {
            if (this.softwareAtual.Id != 0)
            {
                this.txtCodigoSoftware.Text = this.softwareAtual.Id.ToString();
                this.txtDataInsercao.Text = this.softwareAtual.DataInsercao.ToString("dd/MM/yyyy");
                this.txtNome.Text = this.softwareAtual.NomeSoftware;
                this.txtTecnologia.Text = this.softwareAtual.TecnologiaSoftware;
                this.txtFornecedor.Text = this.softwareAtual.FornecedorSoftware;
            }
            this.ValidaInatividade = true;
        }
    }
}
