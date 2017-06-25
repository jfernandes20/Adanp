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
    public partial class FormResultado : FormBase
    {
        DataTable resultados = new DataTable();
        List<Caracteristica> caracteristica = new List<Caracteristica>();
        List<Software> ganhadores = new List<Software>();
        public FormResultado(DataTable resultado, List<Caracteristica> carac)
        {
            InitializeComponent();
            this.resultados = resultado;
            this.caracteristica = carac;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }
        private void preencheGrid()
        {
            int softwares = this.resultados.AsEnumerable().Select(d => Convert.ToInt32(d["SoftwareId"])).Distinct().Count();
            this.dgResultado.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Característica",
                DisplayIndex = 0,
                Name = "Característica",
                Width = 30,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            this.dgResultado.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Peso",
                DisplayIndex = 1,
                Name = "Peso",
                Width = 30,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            int linGrid = 0;
            foreach (var x in caracteristica.OrderBy(d => d.CaracteristicaNumero).Select(d => new { Caracteristica = d.CaracteristicaNome, Peso = d.Peso }).AsEnumerable())
            {
                this.dgResultado.Rows.Add(x.Caracteristica, x.Peso);
                dgResultado.Rows[linGrid].Cells["Característica"].Style.BackColor = Color.FromArgb(46, 218, 166); ;
                dgResultado.Rows[linGrid].Cells["Peso"].Style.BackColor = Color.FromArgb(46, 218, 166); ;
                linGrid++;
            }

            for (int i = 0; i <= softwares - 1; i++)
            {
                this.dgResultado.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Soft" + (i + 1),
                    Name = "Soft" + (i + 1),
                    Width = 30,
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
                this.dgResultado.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Total de Pontos",
                    Name = "TotalPontos" + (i + 1),
                    Width = 30,
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
            }
            int soft = -1;
            foreach (var r in this.resultados.AsEnumerable().Select(d => new { Id = Convert.ToInt32(d["SoftwareId"]), Nome = d["NomeSoftware"].ToString(), DataAvaliacao = Convert.ToDateTime(d["DataAvaliacao"]).ToShortDateString() }).Distinct())
            {
                soft++;
                int linha = 0;

                Label labels = (Label)groupBox1.Controls.Find("lbSoftware" + (soft + 1), true).First();
                if (labels != null)
                {
                    labels.Text = string.Format("Soft{0} – {1}\nData de Avaliação: {2}", (soft + 1).ToString(), r.Nome.ToString(), r.DataAvaliacao);
                    if (this.ganhadores.Where(d => d.Id == r.Id).Any())
                    {
                        Label lbvencedor = new Label()
                        {
                            Name = "lbVencedor" + soft,
                            Location = new Point(labels.Location.X + labels.Width+3, labels.Location.Y),
                            TextAlign = ContentAlignment.MiddleLeft,
                            Text = "← Vencedor",
                            ForeColor = Color.Green,
                            Size = labels.Size
                        };
                        this.groupBox1.Controls.Add(lbvencedor);
                    }
                }

                foreach (DataRow exibicao in this.resultados.AsEnumerable().Where(d => Convert.ToInt32(d["SoftwareId"]) == r.Id))
                {
                    this.dgResultado.Rows[linha].Cells["Soft" + (soft + 1)].Value = exibicao["NotaTotal"].ToString();
                    this.dgResultado.Rows[linha].Cells["TotalPontos" + (soft + 1)].Value = Convert.ToInt32(exibicao["NotaTotal"].ToString()) * caracteristica.Where(d => d.Id == Convert.ToInt32(exibicao["CaracteristicaId"])).Select(d => d.Peso).First();
                    linha++;
                }
            }
        }

        private void FormResultado_Load(object sender, EventArgs e)
        {
            this.ganhadores = Software.ObterMelhorSoftware(this.resultados, this.caracteristica);
            this.preencheGrid();
        }
    }
}
