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
    public partial class FormCadastroQuestoes : FormBase
    {
        protected override bool ValidaInatividade { get; set; }
        private List<Caracteristica> caracteristicas = new List<Caracteristica>();
        
        public FormCadastroQuestoes()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            caracteristicas = Caracteristica.ListarCaracteristicas();
        }

        private void FormCadastroQuestoes_Load(object sender, EventArgs e)
        {
            this.ValidaInatividade = true;
            this.caracteristicas.Add(new Caracteristica { Id = 0, CaracteristicaNome = "Selecione", CaracteristicaNumero = 0 });
            this.cbCaracteristica.DisplayMember = "Nome";
            this.cbCaracteristica.ValueMember = "Id";
            this.cbCaracteristica.DataSource = caracteristicas.Select(d => new { Nome = d.CaracteristicaNome, Id = d.Id, d.CaracteristicaNumero }).OrderBy(d => d.CaracteristicaNumero).ToList();

        }
        protected override void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.GetLastInputTime() > this.tempoInativo && this.ValidaInatividade)
            {
                this.timer1.Stop();
                MessageBox.Show(this.mensagemDesconectado,"Inatividade",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.cbCaracteristica.SelectedIndex = 0;
                this.cbCaracteristica.Focus();
                this.timer1.Start();
            }
        }

        private void cbCaracteristica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(this.cbCaracteristica.SelectedValue) > 0)
            {
                this.cbSubCararcteristica.Visible = true;
                this.lbSubCategoria.Visible = true;
                List<SubCaracteristica> listaSub = this.caracteristicas.Where(d => d.Id == Convert.ToInt16(this.cbCaracteristica.SelectedValue)).First().SubCaracteristicas.ToList();
                listaSub.Add(new SubCaracteristica { Id = 0, SubCaracteristicaNome = "Selecione" });
                this.cbSubCararcteristica.DisplayMember = "SubCaracteristicaNome";
                this.cbSubCararcteristica.ValueMember = "Id";
                this.cbSubCararcteristica.DataSource = listaSub.OrderBy(d => d.Id).ToList();
                this.cbSubCararcteristica.Focus();
            }
            else
            {
                this.cbSubCararcteristica.Visible = false;
                this.cbSubCararcteristica.DataSource = null;
                this.lbSubCategoria.Visible = false;
            }

        }

        private void cbSubCararcteristica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(this.cbSubCararcteristica.SelectedValue) > 0)
            {
                this.txtQuestao.Visible = true;
                this.lbQuestao.Visible = true;
                this.lbCaracteres.Visible = true;
                this.lbTextoCaractereres.Visible = true;
                this.txtQuestao.Focus();
            }
            else
            {
                this.txtQuestao.Visible = false;
                this.lbQuestao.Visible = false;
                this.lbCaracteres.Visible = false;
                this.lbTextoCaractereres.Visible = false;
            }
            this.txtQuestao.Text = string.Empty;
        }
        private void txtQuestao_TextChanged(object sender, EventArgs e)
        {
            this.lbCaracteres.Text = this.txtQuestao.Text.Length.ToString();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Questao quest = new Questao();
            quest.Id = 0;
            quest.SubCaracteristicaId = new SubCaracteristica() { Id = Convert.ToInt32(this.cbSubCararcteristica.SelectedValue), CaracteristicaId = new Caracteristica(), SubCaracteristicaNome = this.cbSubCararcteristica.SelectedText.ToString() };
            quest.TextoQuestao = this.txtQuestao.Text.Replace('\n',' ');
            quest.Salvar(quest);
        }
    }
}
