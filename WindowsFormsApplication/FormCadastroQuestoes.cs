﻿using System;
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
        private Questao quest = new Questao();

        public FormCadastroQuestoes(Questao questao)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            caracteristicas = Caracteristica.ListarCaracteristicas();
            this.quest = questao;
        }

        private void FormCadastroQuestoes_Load(object sender, EventArgs e)
        {
            this.ValidaInatividade = true;
            this.carregaCombo();
            if (quest.Id != 0)
            {
                this.cbCaracteristica.Text = quest.SubCaracteristicaId.CaracteristicaId.CaracteristicaNome;
                this.cbSubCararcteristica.Text = quest.SubCaracteristicaId.SubCaracteristicaNome;
                this.txtQuestao.Text = quest.TextoQuestao;
            }
        }
        private void carregaCombo()
        {
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
                MessageBox.Show(this.mensagemDesconectado, "Inatividade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                this.lbErroCaracteristica.Visible = false;
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
                this.lbErroSubCaracteristica.Visible = false;
                this.txtQuestao.Focus();
            }
            else
            {
                this.txtQuestao.Visible = false;
                this.lbQuestao.Visible = false;
                this.lbCaracteres.Visible = false;
                this.lbTextoCaractereres.Visible = false;
            }
            this.txtQuestao.Text = quest.TextoQuestao;
        }
        private void txtQuestao_TextChanged(object sender, EventArgs e)
        {
            this.lbCaracteres.Text = this.txtQuestao.Text.Length.ToString();
            this.lbErroQuestao.Visible = false;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                quest.SubCaracteristicaId = new SubCaracteristica() { Id = Convert.ToInt32(this.cbSubCararcteristica.SelectedValue), CaracteristicaId = new Caracteristica(), SubCaracteristicaNome = this.cbSubCararcteristica.SelectedText.ToString() };
                quest.TextoQuestao = this.txtQuestao.Text.Replace('\n', ' ');
                if (this.validarQuestoes())
                    quest.Salvar();
                else
                    MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um  erro ao tentar realizar o cadastro da questão.\nDetalhes: "+ ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private bool validarQuestoes()
        {
            int camposEmBranco = 0;

            if (cbCaracteristica.SelectedIndex == 0)
            {
                this.lbErroCaracteristica.Visible = true;
                camposEmBranco++;
            }
            if (cbSubCararcteristica.SelectedIndex == 0 && cbSubCararcteristica.Visible == true)
            {
                this.lbErroSubCaracteristica.Visible = true;
                camposEmBranco++;
            }
            if (string.IsNullOrWhiteSpace(txtQuestao.Text) && txtQuestao.Visible == true)
            {
                this.lbErroQuestao.Visible = true;
                camposEmBranco++;
            }
            return camposEmBranco == 0;
        }
    }
}