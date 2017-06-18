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
    public partial class FormCompararSoftware : FormBase
    {
        protected override bool ValidaInatividade { get; set; }
        private List<Caracteristica> caracteristicas = new List<Caracteristica>();
        private List<Avaliacao> listaSoftware = new List<Avaliacao>();
        public FormCompararSoftware()
        {
            InitializeComponent();
        }

        private void FormPesoCaracteristica_Load(object sender, EventArgs e)
        {
            try
            {
                this.caracteristicas = Caracteristica.ListarCaracteristicas();
                this.carregaCombo();
                this.ValidaInatividade = true;
                this.txtPeso.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar listar características!\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void carregaCombo()
        {
            this.cbCaracteristica.DisplayMember = "Nome";
            this.cbCaracteristica.ValueMember = "Id";
            this.cbCaracteristica.DataSource = this.caracteristicas.Where(d => d.Peso == 0).Select(d => new { Id = d.Id, Nome = d.CaracteristicaNome }).ToList();
            if (this.cbCaracteristica.Items.Count == 0)
            {
                this.cbCaracteristica.Enabled = false;
                this.txtPeso.Enabled = false;
            }
            else
            {
                this.cbCaracteristica.Enabled = true;
                this.txtPeso.Enabled = true;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.salvarPeso();
        }
        private void salvarPeso()
        {
            if (string.IsNullOrWhiteSpace(this.txtPeso.Text)) return;
            if (Convert.ToInt32(this.txtPeso.Text) >= 1 && Convert.ToInt32(this.txtPeso.Text) <= 5)
            {
                this.caracteristicas.Where(d => d.Id == Convert.ToInt16(this.cbCaracteristica.SelectedValue)).ToList().ForEach(d => d.Peso = Convert.ToInt32(txtPeso.Text));
                this.dgCaracteristica.Rows.Add(null, this.cbCaracteristica.SelectedValue.ToString(), this.cbCaracteristica.Text.ToString(), this.txtPeso.Text);
                this.carregaCombo();
                this.txtPeso.Text = string.Empty;
            }
            else
                MessageBox.Show("O peso é um valor entre 1 e 5 e é obrigatória sua informação!", "Peso Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.txtPeso.Focus();
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) salvarPeso();
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
                e.Handled = true;
        }

        private void dgCaracteristica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgCaracteristica.Columns["RemoverCaracteristica"].Index)
            {
                this.caracteristicas.Where(d => d.Id == Convert.ToUInt32(this.dgCaracteristica.Rows[e.RowIndex].Cells["Id"].Value.ToString())).ToList().ForEach(d => d.Peso = 0);
                this.dgCaracteristica.Rows.RemoveAt(e.RowIndex);
                this.carregaCombo();
                if (this.dgSoftware.Columns["ClSelecao"] != null) this.dgSoftware.Columns.Remove(this.dgSoftware.Columns["ClSelecao"]);
                this.dgSoftware.DataSource = null;
            }
        }
        protected override void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.GetLastInputTime() > this.tempoInativo && this.ValidaInatividade)
            {
                this.timer1.Stop();
                MessageBox.Show(this.mensagemDesconectado, "Inatividade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.limpartela();
                this.timer1.Start();
            }
        }
        private void limpartela()
        {
            this.caracteristicas.ForEach(d => d.Peso = 0);
            this.carregaCombo();
            this.dgCaracteristica.Rows.Clear();
            if (this.dgSoftware.Columns["ClSelecao"] != null) this.dgSoftware.Columns.Remove(this.dgSoftware.Columns["ClSelecao"]);
            this.dgSoftware.DataSource = null;
            this.txtPeso.Focus();
        }

        private void FormPesoCaracteristica_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timer1.Dispose();
        }

        private void toolStripButtonFiltrar_Click(object sender, EventArgs e)
        {
            this.ListarSoftware();
        }

        private void toolStripTextBoxCriterio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) this.ListarSoftware();
        }
        private void ListarSoftware()
        {
            if (this.caracteristicas.Where(d => d.Peso == 0).ToList().Count > 0)
            {
                MessageBox.Show("Não é possível carregar softwares pois ainda existem características sem peso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.listaSoftware = Avaliacao.ListarSoftwareAvaliacao(this.toolStripTextBoxCriterio.Text);
            this.dgSoftware.DataSource = this.listaSoftware.Where(d => d.Id != 0).Select(d => new { CodigoIdentificacao = d.SoftwareId.Id, Nome = d.SoftwareId.NomeSoftware, Fornecedor = d.SoftwareId.FornecedorSoftware, Tecnologia = d.SoftwareId.TecnologiaSoftware, DataCadastro = d.SoftwareId.DataInsercao.ToString("dd/MM/yyyy"), DataAvaliacao = (d.DataAvaliacao == DateTime.MinValue ? string.Empty : d.DataAvaliacao.ToString("dd/MM/yyyy")), Avaliador = d.NomeAvaliador }).OrderBy(d => d.CodigoIdentificacao).AsEnumerable().ToList();
            this.dgSoftware.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSoftware.Columns["CodigoIdentificacao"].HeaderText = "Código de Identificação";
            this.dgSoftware.Columns["DataCadastro"].HeaderText = "Data de Cadastro";
            this.dgSoftware.Columns["DataAvaliacao"].HeaderText = "Data de Avaliação";


            if (this.dgSoftware.Columns["ClSelecao"] != null) this.dgSoftware.Columns.Remove(this.dgSoftware.Columns["ClSelecao"]);
            this.dgSoftware.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                HeaderText = String.Empty,
                DisplayIndex = 0,
                Name = "clSelecao",
                Width = 30,
                ReadOnly = false,
                TrueValue = true,
                FalseValue = false,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

        }

        private void FormPesoCaracteristica_Resize(object sender, EventArgs e)
        {
            gbCaracteristica.Width = this.Width - 30;
            dgCaracteristica.Width = gbCaracteristica.Width - 10;
            gbSoftware.Width = this.Width - 30;
            dgSoftware.Width = gbSoftware.Width - 10;
            gbSoftware.Top = gbCaracteristica.Height + 15;
            gbSoftware.Height = this.Height - (gbCaracteristica.Height + 65);
        }

        private void toolStripButtonComparar_Click(object sender, EventArgs e)
        {

            List<Software> softwareComparar = new List<Software>();
            foreach (DataGridViewRow row in this.dgSoftware.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ClSelecao"].Value))
                {
                    softwareComparar.Add(this.listaSoftware.Select(d => d.SoftwareId).Where(d => d.Id == Convert.ToInt32(row.Cells["CodigoIdentificacao"].Value)).First());
                }
            }
            if (softwareComparar.Count >= 2 && softwareComparar.Count <= 5)
            {
                this.ValidaInatividade = false;
                FormResultado resultado = new FormResultado(Avaliacao.ObterNotasPorSoftware(softwareComparar), this.caracteristicas);
                resultado.ShowDialog();
                this.ValidaInatividade = true;
            }
            else
            {
                MessageBox.Show("Para comprar software é necessario selecionar pelo menos 2 e no máximo 5 softwares!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgSoftware_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && this.dgSoftware.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewCheckBoxCell)
                {
                    this.dgSoftware.BeginEdit(true);

                    if ((this.dgSoftware.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell).Value != null)
                        (this.dgSoftware.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell).Value = !Convert.ToBoolean(this.dgSoftware.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    else
                        (this.dgSoftware.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell).Value = true;

                    this.dgSoftware.EndEdit();
                    this.dgSoftware.InvalidateCell(e.ColumnIndex, e.RowIndex);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ocorreu um erro ao selecionar a célula do grid.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
