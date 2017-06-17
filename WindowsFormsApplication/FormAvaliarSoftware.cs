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
    public partial class FormAvaliarSoftware : FormBase
    {
        public FormAvaliarSoftware()
        {
            InitializeComponent();
        }
        List<Software> listaSoftware = new List<Software>();

        private void CarregaDados()
        {
            this.listaSoftware = Software.ListarSoftware(this.toolStripTextBoxCriterio.Text);
            this.dgSoftware.DataSource = this.listaSoftware.Select(d => new { CodigoIdentificacao = d.Id, Nome = d.NomeSoftware, Fornecedor = d.FornecedorSoftware, Tecnologia = d.TecnologiaSoftware, DataCadastro = d.DataInsercao.ToString("dd/MM/yyyy"),d.PossuiAvaliacao }).OrderBy(d => d.CodigoIdentificacao).AsEnumerable().ToList();
            this.dgSoftware.Columns["PossuiAvaliacao"].Visible = false;
            this.dgSoftware.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSoftware.Columns["CodigoIdentificacao"].HeaderText = "Código de Identificação";
            this.dgSoftware.Columns["DataCadastro"].HeaderText = "Data de Cadastro";

            if (this.dgSoftware.Rows.Count == 0)
            {
                toolStripButtonAvaliarSoftware.Enabled = false;
            }
            else
            {
                toolStripButtonAvaliarSoftware.Enabled = true;
            }
        }

        private void toolStripButtonFiltrar_Click_1(object sender, EventArgs e)
        {
            this.CarregaDados();
        }

        private void toolStripTextBoxCriterio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) this.CarregaDados();
        }

        private void toolStripButtonAvaliarSoftware_Click(object sender, EventArgs e)
        {
            Software softwareAtual = new Software();
            softwareAtual = listaSoftware.Where(d => d.Id == Convert.ToInt32(this.dgSoftware.CurrentRow.Cells["CodigoIdentificacao"].Value)).First();

            if (Avaliacao.SoftwareJaPossuiAvaliacao(softwareAtual))
            {
                MessageBox.Show("Não é possível avaliar este software, pois o mesmo já foi avaliado!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            FormAvaliacao form = new FormAvaliacao(softwareAtual);
            form.ShowDialog();
        }

        private void dgSoftware_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.dgSoftware.Rows)
                row.DefaultCellStyle.BackColor = (Convert.ToBoolean(row.Cells["PossuiAvaliacao"].Value.ToString())) ? Color.FromArgb(46,218,166) : Color.White;
        }
    }
}
