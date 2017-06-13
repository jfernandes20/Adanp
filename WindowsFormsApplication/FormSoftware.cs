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
    public partial class FormSoftware : FormBase
    {
        public FormSoftware()
        {
            InitializeComponent();
        }
        private void CarregaDados()
        {

            this.dgSoftware.DataSource = null;
            this.dgSoftware.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgSoftware.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (this.dgSoftware.Rows.Count == 0)
            {
                toolStripButtonEditar.Enabled = false;
                toolStripButtonExcluir.Enabled = false;
            }
            else
            {
                toolStripButtonEditar.Enabled = true;
                toolStripButtonExcluir.Enabled = true;
            }
        }
    }
}
