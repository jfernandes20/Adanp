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
        List<Caracteristica> caracteristicas = new List<Caracteristica>();
        private void toolStripButtonIncluir_Click(object sender, EventArgs e)
        {
            FormCadastroQuestoes form = new FormCadastroQuestoes();
            form.ShowDialog();
        }

        private void FormQuestoes_Load(object sender, EventArgs e)
        {
            CarregaCombos();
            this.dgQuestoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void CarregaDados()
        {
            int caracteristicaId = this.toolStripComboBoxCaracteristica.ComboBox.SelectedValue != null ? (int)this.toolStripComboBoxCaracteristica.ComboBox.SelectedValue : 0;
            int subCaracteristicaId = this.toolStripComboBoxSubCaracteristica.ComboBox.SelectedValue != null ? (int)this.toolStripComboBoxSubCaracteristica.ComboBox.SelectedValue : 0;

            this.dgQuestoes.DataSource = Questao.ListarQuestao(this.toolStripButtonFiltrar.Text, caracteristicaId, subCaracteristicaId).Select(d => new { d.Id, d.TextoQuestao, d.SubCaracteristicaId.CaracteristicaId.CaracteristicaNome, d.SubCaracteristicaId.SubCaracteristicaNome }).OrderBy(d => d.Id).AsEnumerable().ToList();
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
    }
}
