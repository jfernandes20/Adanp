﻿using System;
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
