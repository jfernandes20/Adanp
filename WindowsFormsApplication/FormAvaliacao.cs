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
    public partial class FormAvaliacao : FormBase
    {
        List<Questao> listaQuestoes = new List<Questao>();
        Questao questaoAtual = new Questao();
        Software softwareAvaliado = new Software();
        Avaliacao avaliacao = new Avaliacao();

        int NumeroAtual = 0;
        public FormAvaliacao(Software soft)
        {
            InitializeComponent();
            softwareAvaliado = soft;
        }
        private void FormAvaliacao_Load(object sender, EventArgs e)
        {
            this.CarregaQuestao();
            this.AtualizaTela();
            this.lbSoftware.Text = softwareAvaliado.NomeSoftware.ToString();
            this.avaliacao.SoftwareId = softwareAvaliado;
            this.PreencheListaNotas();
        }
        private void CarregaQuestao()
        {
            this.listaQuestoes = Questao.ListarQuestao("", 0, 0);
        }
        private void AtualizaTela()
        {
            try
            {
                this.questaoAtual = listaQuestoes.Where(d => d.NumeroQuestao == NumeroAtual).First();
                this.lbCaracteristica.Text = questaoAtual.SubCaracteristicaId.CaracteristicaId.CaracteristicaNome.ToString();
                this.lbSubCaracteristica.Text = questaoAtual.SubCaracteristicaId.SubCaracteristicaNome.ToString();
                this.LbNumeroQuestao.Text = (questaoAtual.NumeroQuestao + 1).ToString("000");
                this.LbQuestao.Text = questaoAtual.TextoQuestao.ToString();

                if (NumeroAtual + 1 == listaQuestoes.Count())
                {
                    btnProxima.Enabled = false;
                    btnSalvar.Enabled = true;
                }
                else
                {
                    btnProxima.Enabled = true;
                    btnSalvar.Enabled = false;
                }
                if (NumeroAtual == 0)
                    btnAnterior.Enabled = false;
                else
                    btnAnterior.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar alterar a questão de avaliação");
            }
        }
        private void PreencheListaNotas()
        {
            avaliacao.Notas = new List<NotaAvaliacao>();
            foreach (Questao q in listaQuestoes.AsEnumerable())
            {
                NotaAvaliacao nota = new NotaAvaliacao();
                nota.QuestaoId = q;
                avaliacao.Notas.Add(nota);
            }
        }
        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (this.SalvarNotas())
            {
                this.NumeroAtual++;
                this.AtualizaTela();
            }

        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (this.SalvarNotas())
            {
                this.NumeroAtual--;
                this.AtualizaTela();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SalvarNotas())
                {
                    using (FormObterNomeAvaliador form = new FormObterNomeAvaliador())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            avaliacao.NomePessoa = form.NomeAvaliador;
                            avaliacao.Salvar();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao salvar notas","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private bool SalvarNotas()
        {
            int nota;
            if (radioButton1.Checked)
                nota = 1;
            else if (radioButton2.Checked)
                nota = 2;
            else if (radioButton3.Checked)
                nota = 3;
            else if (radioButton4.Checked)
                nota = 4;
            else if (radioButton5.Checked)
                nota = 5;
            else
            {
                MessageBox.Show("Nenhuma Nota selecionada");
                return false;
            }
            avaliacao.Notas.Where(n => n.QuestaoId.Id == questaoAtual.Id).ToList().ForEach(n => n.Nota = nota);
            return true;
        }
    }
}
