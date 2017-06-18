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
    public partial class FormObterNomeAvaliador : FormBase
    {
        public string NomeAvaliador
        {
            get { return txtNomeAvaliador.Text; }
        }

        public FormObterNomeAvaliador()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.confimar();
        }

        private void FormObterNomeAvaliador_Load(object sender, EventArgs e)
        {
            this.txtNomeAvaliador.Focus();
        }

        private void txtNomeAvaliador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) this.confimar();
        }
        private void confimar()
        {
            if (string.IsNullOrWhiteSpace(txtNomeAvaliador.Text))
            {
                MessageBox.Show("O nome do avalidador é obrigatório", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
