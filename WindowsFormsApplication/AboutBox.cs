using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();

            Version version = Assembly.GetEntryAssembly().GetName().Version;

            this.Text = String.Format("Sobre {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelProductName.UseMnemonic = false;
            this.labelVersion.UseMnemonic = false;
            this.labelCopyright.UseMnemonic = false;

            this.labelVersion.Text = String.Format("Versão: {0}.{1}.{2}.{3}", version.Major, version.Minor, version.Build, version.Revision);
            this.labelCopyright.Text = AssemblyCopyright;
            this.lbIntegrantes.UseMnemonic = false;
            this.lbMatricula.UseMnemonic = false;
            this.lbIntegrantes.Text = "CAMILA GOMES DE OLIVEIRA\r\nCAMILA TOLEDO DE OLIVEIRA\r\nGUILHERME RODRIGUES MORELLI\r\nJEFERSON GOMES FERNANDES\r\nWESLEY REGES DA SILVA";
            this.lbMatricula.Text = "MAT: 719450\r\nMAT: 719421\r\nMAT: 719432\r\nMAT: 719436\r\nMAT: 719442";
            //this.textBoxDescription.Text = AssemblyDescription + "\r\nSistema desenvolvido para atender  Faculdade de Filosofia, Ciências e Letras do Centro Universitário Fundação Santo André.\r\n";
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }


        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void AboutBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
