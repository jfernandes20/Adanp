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
    public partial class FormBase : Form
    {
        protected virtual bool ValidaInatividade { get; set; }
        protected int tempoInativo = 10;
        protected String mensagemDesconectado = "Sessão encerrada devido inátividade";
        public FormBase()
        {
            InitializeComponent();
            timer1.Start();
        }

        protected virtual void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
