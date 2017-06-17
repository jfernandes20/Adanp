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

                if (avaliacao.Notas != null)
                {
                    int nota = Convert.ToInt32(this.avaliacao.Notas.Where(d => d.QuestaoId.Id == questaoAtual.Id).Select(d => d.Nota).First().ToString());

                    switch (nota)
                    {
                        case 1:
                            radioButton1.Checked = true;
                            break;
                        case 2:
                            radioButton2.Checked = true;
                            break;
                        case 3:
                            radioButton3.Checked = true;
                            break;
                        case 4:
                            radioButton4.Checked = true;
                            break;
                        case 5:
                            radioButton5.Checked = true;
                            break;
                        default:
                            break;
                    }
                }

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
            this.NumeroAtual--;
            this.AtualizaTela();
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
                            avaliacao.NomeAvaliador = form.NomeAvaliador;
                            avaliacao.Salvar();
                            MessageBox.Show("Avaliação de software finalizada com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao salvar notas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.LimparNota();
            return true;
        }
        private void LimparNota()
        {
            foreach (RadioButton rb in groupBox2.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
        }
    }
}
