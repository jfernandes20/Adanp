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
    public partial class Form1 : Form
    {
        public bool ValidaInatividade { get; set; }

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
            Class1.inserirRegistro(this.textBox1.Text, this.maskedTextBox1.Text);
            MessageBox.Show("Registro inserido","Confirmação",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.textBox1.Text = string.Empty;
            this.maskedTextBox1.Text = string.Empty;
            this.carregaDados();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.carregaDados();
            this.textBox1.Focus();
            this.timer1.Start();
            this.dgTeste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelHora.Text = DateTime.Now.ToLongTimeString();
            if (Program.GetLastInputTime() > 20 && ValidaInatividade)
            {
                this.timer1.Stop();
                MessageBox.Show("Desconectado por inativade (20 sec) teste");
                Application.Exit();

            }
        }
    }
}
