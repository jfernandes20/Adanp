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
        public Form1()
        {
            InitializeComponent();
        }
        private void carregaDados()
        {
            this.dgTeste.DataSource = Class1.teste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.inserirRegistro(this.textBox1.Text, this.maskedTextBox1.Text);
            this.carregaDados();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.carregaDados();
        }
    }
}
