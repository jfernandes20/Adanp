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
    public partial class FormQuestoes : FormBase
    {
        public FormQuestoes()
        {
            InitializeComponent();
        }
        private List<Caracteristica> caracteristicas = new List<Caracteristica>();
        private List<Questao> listaQuestoes = new List<Questao>();
        private void toolStripButtonIncluir_Click(object sender, EventArgs e)
        {
            FormCadastroQuestoes form = new FormCadastroQuestoes(new Questao());
            form.ShowDialog();
            this.CarregaDados();
        }

        private void FormQuestoes_Load(object sender, EventArgs e)
        {
            CarregaCombos();
        }
        private void CarregaDados()
        {
            int caracteristicaId = this.toolStripComboBoxCaracteristica.ComboBox.SelectedValue != null ? (int)this.toolStripComboBoxCaracteristica.ComboBox.SelectedValue : 0;
            int subCaracteristicaId = this.toolStripComboBoxSubCaracteristica.ComboBox.SelectedValue != null ? (int)this.toolStripComboBoxSubCaracteristica.ComboBox.SelectedValue : 0;
            this.listaQuestoes = Questao.ListarQuestao(this.toolStripTextBoxCriterio.Text, caracteristicaId, subCaracteristicaId);
            this.dgQuestoes.DataSource = listaQuestoes.Select(d => new { d.Id, Caracteristica = d.SubCaracteristicaId.CaracteristicaId.CaracteristicaNome, SubCaracteristica = d.SubCaracteristicaId.SubCaracteristicaNome, Questão = d.TextoQuestao }).OrderBy(d => d.Id).AsEnumerable().ToList();
            this.dgQuestoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgQuestoes.Columns["Caracteristica"].HeaderText = "Característica";
            this.dgQuestoes.Columns["SubCaracteristica"].HeaderText = "Sub-Característica";

            if (this.dgQuestoes.Rows.Count == 0)
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
        private void CarregaCombos()
        {
            this.caracteristicas = Caracteristica.ListarCaracteristicas();
            this.caracteristicas.Add(new Caracteristica { Id = 0, CaracteristicaNome = "Selecione", CaracteristicaNumero = 0 });
            this.toolStripComboBoxCaracteristica.ComboBox.DisplayMember = "Nome";
            this.toolStripComboBoxCaracteristica.ComboBox.ValueMember = "Id";
            this.toolStripComboBoxCaracteristica.ComboBox.DataSource = caracteristicas.Select(d => new { Nome = d.CaracteristicaNome, Id = d.Id, d.CaracteristicaNumero }).OrderBy(d => d.CaracteristicaNumero).ToList();

        }

        private void toolStripComboBoxCaracteristica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(this.toolStripComboBoxCaracteristica.ComboBox.SelectedValue) > 0)
            {
                List<SubCaracteristica> listaSub = this.caracteristicas.Where(d => d.Id == Convert.ToInt16(this.toolStripComboBoxCaracteristica.ComboBox.SelectedValue)).First().SubCaracteristicas.ToList();
                listaSub.Add(new SubCaracteristica { Id = 0, SubCaracteristicaNome = "Selecione" });
                this.toolStripComboBoxSubCaracteristica.ComboBox.DisplayMember = "SubCaracteristicaNome";
                this.toolStripComboBoxSubCaracteristica.ComboBox.ValueMember = "Id";
                this.toolStripComboBoxSubCaracteristica.ComboBox.DataSource = listaSub.OrderBy(d => d.Id).ToList();

            }
            else
            {
                this.toolStripComboBoxSubCaracteristica.ComboBox.DataSource = null;
            }
        }

        private void toolStripButtonFiltrar_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void toolStripTextBoxCriterio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) CarregaDados();
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Questao questaoSelecionada = listaQuestoes.Where(d => d.Id == Convert.ToInt32(this.dgQuestoes.CurrentRow.Cells["Id"].Value)).First();
                FormCadastroQuestoes fc = new FormCadastroQuestoes(questaoSelecionada);
                fc.ShowDialog();
                this.CarregaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar editar questão de avaliação.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripButtonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Questao questaoSelecionada = listaQuestoes.Where(d => d.Id == Convert.ToInt32(this.dgQuestoes.CurrentRow.Cells["Id"].Value)).First();
                DialogResult result = MessageBox.Show("Realmente deseja excluir essa questão de avaliação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    questaoSelecionada.Excluir();
                    MessageBox.Show("Questão de avaliação excluída com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CarregaDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar excluir questão de avaliação.\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
