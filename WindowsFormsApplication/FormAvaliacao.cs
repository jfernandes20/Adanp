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
        List<NotaAvaliacao> notas = new List<NotaAvaliacao>();

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
        }
        private void CarregaQuestao()
        {
            this.listaQuestoes = Questao.ListarQuestao("", 0, 0);
        }
        private void AtualizaTela()
        {
            try
            {
                NotaAvaliacao nota = new NotaAvaliacao();
                if (radioButton1.Checked)
                    nota.Nota = 1;
                else if (radioButton2.Checked)
                    nota.Nota = 2;
                else if (radioButton3.Checked)
                    nota.Nota = 3;
                else if (radioButton4.Checked)
                    nota.Nota = 4;
                else if (radioButton5.Checked)
                    nota.Nota = 5;
                else
                {
                    MessageBox.Show("Nenhuma Nota selecionada");
                }


                this.questaoAtual = listaQuestoes.Where(d => d.NumeroQuestao == NumeroAtual).First();
                this.lbCaracteristica.Text = questaoAtual.SubCaracteristicaId.CaracteristicaId.CaracteristicaNome.ToString();
                this.lbSubCaracteristica.Text = questaoAtual.SubCaracteristicaId.SubCaracteristicaNome.ToString();
                this.LbNumeroQuestao.Text = (questaoAtual.NumeroQuestao + 1).ToString("000");
                this.LbQuestao.Text = questaoAtual.TextoQuestao.ToString();

                if (NumeroAtual + 1 == listaQuestoes.Count())
                    btnProxima.Enabled = false;
                else
                    btnProxima.Enabled = true;

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
        private void button2_Click(object sender, EventArgs e)
        {
            this.NumeroAtual++;
            this.AtualizaTela();
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.NumeroAtual--;
            this.AtualizaTela();
        }
    }
}
