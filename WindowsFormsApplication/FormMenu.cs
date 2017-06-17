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
    public partial class FormMenu : FormBase
    {
        protected override bool ValidaInatividade { get; set; }
        public FormMenu()
        {
            InitializeComponent();
            this.ValidaInatividade = false;
        }
        private void ShowUniqueInstance(Form form)
        {
            try
            {

                bool encontrouForm = false;
                FormCollection colecao = Application.OpenForms;
                foreach (Form item in colecao)
                {
                    if (item.Name == form.Name)
                    {
                        form = item as Form;
                        if (form.WindowState == FormWindowState.Minimized)
                            form.WindowState = FormWindowState.Maximized;
                        form.BringToFront();
                        form.Activate();
                        encontrouForm = true;
                        return;
                    }
                }
                if (encontrouForm == false)
                {
                    form = form.FindForm();
                    form.Show();
                    form = null;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao tentar abrir form. Detalhes: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        protected override void timer1_Tick(object sender, EventArgs e)
        {
            this.LbData.Text = string.Concat(DateTime.Now.ToLongDateString(),"  " ,DateTime.Now.ToLongTimeString());
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSoftware form = new FormSoftware();
            form.MdiParent = this;
            ShowUniqueInstance(form);
        }

        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuestoes form = new FormQuestoes();
            form.MdiParent = this;
            ShowUniqueInstance(form);
        }

        private void avaliaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAvaliarSoftware form = new FormAvaliarSoftware();
            form.MdiParent = this;
            ShowUniqueInstance(form);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
