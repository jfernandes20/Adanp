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
        private List<Caracteristica> caracteristas = new List<Caracteristica>();
        public FormCadastroQuestoes()
        {
            InitializeComponent();
            Caracteristica carc = new Caracteristica();
            caracteristas = carc.ListarCaracteristicas();
        }

        private void FormCadastroQuestoes_Load(object sender, EventArgs e)
        {
            this.ValidaInatividade = true;
            this.caracteristas.Add(new Caracteristica { Id = 0, CaracteristicaNome = "Selecione", CaracteristicaNumero = 0 });
            this.cbCaracteristica.DisplayMember = "Nome";
            this.cbCaracteristica.ValueMember = "Id";
            this.cbCaracteristica.DataSource = caracteristas.Select(d => new { Nome = d.CaracteristicaNome, Id = d.Id, d.CaracteristicaNumero }).OrderBy(d => d.CaracteristicaNumero).ToList();

        }
        protected override void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.GetLastInputTime() > this.tempoInativo && this.ValidaInatividade)
            {
                this.timer1.Stop();
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
                List<SubCaracteristica> listaSub = this.caracteristas.Where(d => d.Id == Convert.ToInt16(this.cbCaracteristica.SelectedValue)).First().SubCaracteristicas.ToList();
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

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
