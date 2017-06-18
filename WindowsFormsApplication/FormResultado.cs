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
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            this.dgResultado.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Peso",
                DisplayIndex = 1,
                Name = "Peso",
                Width = 30,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            foreach (var x in caracteristica.OrderBy(d => d.CaracteristicaNumero).Select(d => new { Caracteristica = d.CaracteristicaNome, Peso = d.Peso }).AsEnumerable())
                this.dgResultado.Rows.Add(x.Caracteristica,x.Peso);

            for (int i = 0; i <= softwares-1; i++)
            {
                this.dgResultado.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Soft"+(i+1),
                    Name = "Soft"+(i+1),
                    Width = 30,
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
                this.dgResultado.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Total de Pontos",
                    Name = "TotalPontos"+(i+1),
                    Width = 30,
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
            }
            int soft = -1;
            foreach (int r in this.resultados.AsEnumerable().Select(d => Convert.ToInt32(d["SoftwareId"])).Distinct())
            {
                soft++;
                int linha = 0;
                foreach (DataRow exibicao in this.resultados.AsEnumerable().Where(d => Convert.ToInt32(d["SoftwareId"]) == r))
                {
                    this.dgResultado.Rows[linha].Cells["Soft" + (soft + 1)].Value = exibicao["NomeSoftware"].ToString();
                    this.dgResultado.Rows[linha].Cells["TotalPontos" + (soft + 1)].Value = Convert.ToInt32(exibicao["NotaTotal"].ToString()) * Convert.ToInt32(this.dgResultado.Rows[linha].Cells["Peso"].Value);
                    linha++;
                }
            }
        }

        private void FormResultado_Load(object sender, EventArgs e)
        {
            this.preencheGrid();
        }
    }
}
