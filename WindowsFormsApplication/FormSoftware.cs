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
    public partial class FormSoftware : FormBase
    {
        List<Software> listaSoftware = new List<Software>();
        public FormSoftware()
        {
            InitializeComponent();
        }
        private void CarregaDados()
        {
            this.listaSoftware = Software.ListarSoftware(this.toolStripTextBoxCriterio.Text);
            this.dgSoftware.DataSource = this.listaSoftware.Select(d => new { CodigoIdentificacao = d.Id, Nome = d.NomeSoftware, Fornecedor = d.FornecedorSoftware, Tecnologia = d.TecnologiaSoftware, DataCadastro = d.DataInsercao.ToString("dd/MM/yyyy") }).OrderBy(d => d.CodigoIdentificacao).AsEnumerable().ToList();
            this.dgSoftware.Columns["CodigoIdentificacao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgSoftware.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dgSoftware.Columns["CodigoIdentificacao"].HeaderText = "Código de Identificação";
            this.dgSoftware.Columns["DataCadastro"].HeaderText = "Data de Inserção";

            if (this.dgSoftware.Rows.Count == 0)
            {
                toolStripButtonEditar.Enabled = false;
                toolStripButtonExcluir.Enabled = false;
            }
            else
            {
                toolStripButtonEditar.Enabled = true;
                toolStripButtonExcluir.Enabled = true;
            }
        }

        private void toolStripButtonFiltrar_Click(object sender, EventArgs e)
        {
            this.CarregaDados();
        }

        private void toolStripButtonIncluir_Click(object sender, EventArgs e)
        {
            FormCadastroSoftware form = new FormCadastroSoftware(new Software());
            form.ShowDialog();
            this.CarregaDados();
        }

        private void toolStripButtonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Software software = listaSoftware.Where(d => d.Id == Convert.ToInt32(this.dgSoftware.CurrentRow.Cells["CodigoIdentificacao"].Value)).First();
                DialogResult result = MessageBox.Show("Realmente deseja excluir software?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    software.Excluir();
                    MessageBox.Show("Software excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CarregaDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar excluir Software.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Software software = listaSoftware.Where(d => d.Id == Convert.ToInt32(this.dgSoftware.CurrentRow.Cells["CodigoIdentificacao"].Value)).First();
                FormCadastroSoftware fc = new FormCadastroSoftware(software);
                fc.ShowDialog();
                this.CarregaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar editar Software.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripTextBoxCriterio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) this.CarregaDados();
        }
    }
}
