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
    public partial class FormSelecaoAvaliacao : FormBase
    {
        List<Software> listaSoftwares = new List<Software>();
        List<Avaliacao> listaAvaliacoes = new List<Avaliacao>();
        List<Caracteristica> listaCaracteristicas = new List<Caracteristica>();
        public FormSelecaoAvaliacao(List<Software> soft,List<Caracteristica> carac)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.listaSoftwares = soft;
            this.listaCaracteristicas = carac;
        }
        private void ListarAvaliacao()
        {

            int soft = 0;
            foreach (Software s in this.listaSoftwares.AsEnumerable())
            {
                soft++;
                this.Size = new Size(395, 145 + (50 * soft));
                this.btnComparar.Location = new Point(280, 60 + (50 * soft));
                ComboBox cbDatas = new ComboBox()
                {
                    Name = "cbAvaliacaoSoftware" + soft,
                    DisplayMember = "DataAvaliacao",
                    ValueMember = "Id",
                    DataSource = this.listaAvaliacoes.Where(d => d.SoftwareId.Id == s.Id).Select(d => new { d.Id, d.DataAvaliacao }).OrderBy(d => d.DataAvaliacao).ToList(),
                    Location = new Point(119, 5 + (50 * soft)),
                    Size = new Size(180, 21),
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                this.Controls.Add(cbDatas);

                Label lbNomeSoftware = new Label()
                {
                    Name = "lbSoftware" + soft,
                    Location = new Point(12, 5 + (50 * soft)),
                    TextAlign = ContentAlignment.MiddleRight,
                    Text = s.NomeSoftware,
                    Size = new Size(100, 21)
                };
                this.Controls.Add(lbNomeSoftware);

                Label lbTitle = new Label()
                {
                    Location = new Point(116, -10 + (50 * soft)),
                    Text = "Avaliações Disponíveis",
                    AutoSize = true
                };
                this.Controls.Add(lbTitle);
            }
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void FormSelecaoAvaliacao_Load(object sender, EventArgs e)
        {
            this.listaAvaliacoes = Avaliacao.ListarSoftwareAvaliacao(listaSoftwares);
            this.ListarAvaliacao();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            List<Avaliacao> avaliacao = new List<Avaliacao>();
            foreach (ComboBox cbAvaliacaoAtual in this.Controls.OfType<ComboBox>())
                avaliacao.Add(this.listaAvaliacoes.Where(d => d.Id == Convert.ToInt32(cbAvaliacaoAtual.SelectedValue.ToString())).First());
            FormResultado result = new FormResultado(Avaliacao.ObterNotasPorSoftware(avaliacao), this.listaCaracteristicas);
            result.ShowDialog();
        }
    }
}
