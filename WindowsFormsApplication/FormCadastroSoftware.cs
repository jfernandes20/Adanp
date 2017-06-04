using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class FormCadastroSoftware : FormBase
    {
        protected override bool ValidaInatividade { get; set; }
        public FormCadastroSoftware()
        {
            InitializeComponent();
            this.ValidaInatividade = true;
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
