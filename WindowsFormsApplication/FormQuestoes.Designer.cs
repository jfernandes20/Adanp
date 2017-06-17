namespace WindowsFormsApplication
{
    partial class FormQuestoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuestoes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxCriterio = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxCaracteristica = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxSubCaracteristica = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonIncluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExcluir = new System.Windows.Forms.ToolStripButton();
            this.dgQuestoes = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuestoes)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBoxCriterio,
            this.toolStripLabel2,
            this.toolStripComboBoxCaracteristica,
            this.toolStripLabel3,
            this.toolStripComboBoxSubCaracteristica,
            this.toolStripButtonFiltrar,
            this.toolStripSeparator2,
            this.toolStripButtonIncluir,
            this.toolStripButtonEditar,
            this.toolStripButtonExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1079, 29);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 26);
            this.toolStripLabel1.Text = "Pesquisar:";
            // 
            // toolStripTextBoxCriterio
            // 
            this.toolStripTextBoxCriterio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxCriterio.MaxLength = 200;
            this.toolStripTextBoxCriterio.Name = "toolStripTextBoxCriterio";
            this.toolStripTextBoxCriterio.Size = new System.Drawing.Size(150, 29);
            this.toolStripTextBoxCriterio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxCriterio_KeyPress);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(81, 26);
            this.toolStripLabel2.Text = "Característica:";
            // 
            // toolStripComboBoxCaracteristica
            // 
            this.toolStripComboBoxCaracteristica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxCaracteristica.Name = "toolStripComboBoxCaracteristica";
            this.toolStripComboBoxCaracteristica.Size = new System.Drawing.Size(145, 29);
            this.toolStripComboBoxCaracteristica.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxCaracteristica_SelectedIndexChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(106, 26);
            this.toolStripLabel3.Text = "Sub-Característica:";
            // 
            // toolStripComboBoxSubCaracteristica
            // 
            this.toolStripComboBoxSubCaracteristica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxSubCaracteristica.Name = "toolStripComboBoxSubCaracteristica";
            this.toolStripComboBoxSubCaracteristica.Size = new System.Drawing.Size(170, 29);
            // 
            // toolStripButtonFiltrar
            // 
            this.toolStripButtonFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiltrar.Image")));
            this.toolStripButtonFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiltrar.Name = "toolStripButtonFiltrar";
            this.toolStripButtonFiltrar.Size = new System.Drawing.Size(23, 26);
            this.toolStripButtonFiltrar.ToolTipText = "Filtrar";
            this.toolStripButtonFiltrar.Click += new System.EventHandler(this.toolStripButtonFiltrar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButtonIncluir
            // 
            this.toolStripButtonIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonIncluir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIncluir.Image")));
            this.toolStripButtonIncluir.Name = "toolStripButtonIncluir";
            this.toolStripButtonIncluir.RightToLeftAutoMirrorImage = true;
            this.toolStripButtonIncluir.Size = new System.Drawing.Size(23, 26);
            this.toolStripButtonIncluir.Text = "Incluir";
            this.toolStripButtonIncluir.Click += new System.EventHandler(this.toolStripButtonIncluir_Click);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditar.Enabled = false;
            this.toolStripButtonEditar.Image = global::WindowsFormsApplication.Properties.Resources.EditarRelatorio;
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(23, 26);
            this.toolStripButtonEditar.Text = "Editar";
            this.toolStripButtonEditar.Click += new System.EventHandler(this.toolStripButtonEditar_Click);
            // 
            // toolStripButtonExcluir
            // 
            this.toolStripButtonExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExcluir.Enabled = false;
            this.toolStripButtonExcluir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExcluir.Image")));
            this.toolStripButtonExcluir.Name = "toolStripButtonExcluir";
            this.toolStripButtonExcluir.RightToLeftAutoMirrorImage = true;
            this.toolStripButtonExcluir.Size = new System.Drawing.Size(23, 26);
            this.toolStripButtonExcluir.Text = "Excluir";
            this.toolStripButtonExcluir.Click += new System.EventHandler(this.toolStripButtonExcluir_Click);
            // 
            // dgQuestoes
            // 
            this.dgQuestoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQuestoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgQuestoes.Location = new System.Drawing.Point(0, 29);
            this.dgQuestoes.MultiSelect = false;
            this.dgQuestoes.Name = "dgQuestoes";
            this.dgQuestoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgQuestoes.Size = new System.Drawing.Size(1079, 584);
            this.dgQuestoes.TabIndex = 0;
            // 
            // FormQuestoes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1079, 613);
            this.Controls.Add(this.dgQuestoes);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormQuestoes";
            this.Text = "Cadastro de Questões";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQuestoes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuestoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgQuestoes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxCriterio;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonIncluir;
        private System.Windows.Forms.ToolStripButton toolStripButtonExcluir;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxCaracteristica;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSubCaracteristica;
    }
}