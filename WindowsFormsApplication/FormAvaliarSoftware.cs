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
        List<Avaliacao> listaSoftware = new List<Avaliacao>();

        private void CarregaDados()
        {
            try
            {
                this.listaSoftware = Avaliacao.ListarSoftwareAvaliacao(this.toolStripTextBoxCriterio.Text, true);
                this.dgSoftware.DataSource = this.listaSoftware.Select(d => new { CodigoIdentificacao = d.SoftwareId.Id, Nome = d.SoftwareId.NomeSoftware, Fornecedor = d.SoftwareId.FornecedorSoftware, Tecnologia = d.SoftwareId.TecnologiaSoftware, DataCadastro = d.SoftwareId.DataInsercao.ToString("dd/MM/yyyy"), DataAvaliacao = (d.DataAvaliacao == DateTime.MinValue ? string.Empty : d.DataAvaliacao.ToString("dd/MM/yyyy")), Avaliador = d.NomeAvaliador }).OrderBy(d => d.CodigoIdentificacao).AsEnumerable().ToList();
                this.dgSoftware.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dgSoftware.Columns["CodigoIdentificacao"].HeaderText = "Código de Identificação";
                this.dgSoftware.Columns["DataCadastro"].HeaderText = "Data de Cadastro";
                this.dgSoftware.Columns["DataAvaliacao"].HeaderText = "Data da Última Avaliação";

                if (this.dgSoftware.Rows.Count == 0)
                {
                    toolStripButtonAvaliarSoftware.Enabled = false;
                }
                else
                {
                    toolStripButtonAvaliarSoftware.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro ao carregar a lista de software!\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Avaliacao avaliacaoAtual = new Avaliacao();
            avaliacaoAtual = listaSoftware.Where(d => d.SoftwareId.Id == Convert.ToInt32(this.dgSoftware.CurrentRow.Cells["CodigoIdentificacao"].Value)).First();

            if (avaliacaoAtual.Id > 0 && avaliacaoAtual.DataAvaliacao.ToShortDateString() == DateTime.Now.ToShortDateString())
            {
                MessageBox.Show("Não é possível avaliar este software, pois o mesmo já foi avaliado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormAvaliacao form = new FormAvaliacao(avaliacaoAtual.SoftwareId);
            form.ShowDialog();
            this.CarregaDados();
        }

        private void dgSoftware_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.dgSoftware.Rows)
                row.DefaultCellStyle.BackColor = row.Cells["DataAvaliacao"].Value.ToString() != DateTime.Now.ToString("dd/MM/yyyy") ? Color.White : Color.FromArgb(46, 218, 166);
        }
    }
}
