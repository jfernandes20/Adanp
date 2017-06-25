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
    public partial class Form1 : FormBase
    {
        protected override bool ValidaInatividade { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.ValidaInatividade = true;
        }
        private void carregaDados()
        {
            this.dgTeste.DataSource = Class1.teste();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.timer1.Start();
            this.dgTeste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        protected override void timer1_Tick(object sender, EventArgs e)
        {
            this.dgTeste.Rows.Insert(0, Program.GetLastInputTime().ToString());


        }

    }
}
