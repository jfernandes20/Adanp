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
            this.cbCaracteristica.DataSource = caracteristas.Select(d => new { Nome = d.CaracteristicaNome, Id = d.Id, d.CaracteristicaNumero }).OrderBy(d => d.CaracteristicaNumero).ToList();
            this.cbCaracteristica.DisplayMember = "Nome";
            this.cbCaracteristica.ValueMember = "CaracteristicaId";
        }
        protected override void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.GetLastInputTime() > 20 && this.ValidaInatividade)
            {
                this.timer1.Stop();
                MessageBox.Show(this.mensagemDesconectado);
                this.timer1.Start();
                this.Close();
            }
        }
    }
}
