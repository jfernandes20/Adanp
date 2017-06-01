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
        public FormCadastroQuestoes()
        {
            InitializeComponent();
            Caracteristica carc = new Caracteristica();
            carc.ListarCaracteristicas();
        }
    }
}
