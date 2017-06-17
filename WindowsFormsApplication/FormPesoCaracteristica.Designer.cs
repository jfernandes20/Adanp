namespace WindowsFormsApplication
{
    partial class FormPesoCaracteristica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesoCaracteristica));
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCaracteristica = new System.Windows.Forms.ComboBox();
            this.dgCaracteristica = new System.Windows.Forms.DataGridView();
            this.RemoverCaracteristica = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCaracteristica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCaracteristica = new System.Windows.Forms.GroupBox();
            this.gbSoftware = new System.Windows.Forms.GroupBox();
            this.dgSoftware = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxCriterio = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonComparar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgCaracteristica)).BeginInit();
            this.gbCaracteristica.SuspendLayout();
            this.gbSoftware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoftware)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::WindowsFormsApplication.Properties.Resources.Remover_red;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(388, 38);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(249, 40);
            this.txtPeso.MaxLength = 1;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 3;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Característica";
            // 
            // cbCaracteristica
            // 
            this.cbCaracteristica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaracteristica.FormattingEnabled = true;
            this.cbCaracteristica.Location = new System.Drawing.Point(15, 39);
            this.cbCaracteristica.Name = "cbCaracteristica";
            this.cbCaracteristica.Size = new System.Drawing.Size(193, 21);
            this.cbCaracteristica.TabIndex = 1;
            // 
            // dgCaracteristica
            // 
            this.dgCaracteristica.AllowUserToAddRows = false;
            this.dgCaracteristica.AllowUserToDeleteRows = false;
            this.dgCaracteristica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCaracteristica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RemoverCaracteristica,
            this.Id,
            this.DCaracteristica,
            this.DgPeso});
            this.dgCaracteristica.Location = new System.Drawing.Point(5, 71);
            this.dgCaracteristica.Name = "dgCaracteristica";
            this.dgCaracteristica.ReadOnly = true;
            this.dgCaracteristica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCaracteristica.Size = new System.Drawing.Size(1030, 155);
            this.dgCaracteristica.TabIndex = 5;
            this.dgCaracteristica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCaracteristica_CellContentClick);
            // 
            // RemoverCaracteristica
            // 
            this.RemoverCaracteristica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RemoverCaracteristica.HeaderText = "";
            this.RemoverCaracteristica.Image = global::WindowsFormsApplication.Properties.Resources.Remover_red;
            this.RemoverCaracteristica.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.RemoverCaracteristica.Name = "RemoverCaracteristica";
            this.RemoverCaracteristica.ReadOnly = true;
            this.RemoverCaracteristica.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RemoverCaracteristica.Width = 5;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DCaracteristica
            // 
            this.DCaracteristica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DCaracteristica.HeaderText = "Característica";
            this.DCaracteristica.Name = "DCaracteristica";
            this.DCaracteristica.ReadOnly = true;
            // 
            // DgPeso
            // 
            this.DgPeso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DgPeso.HeaderText = "Peso";
            this.DgPeso.Name = "DgPeso";
            this.DgPeso.ReadOnly = true;
            // 
            // gbCaracteristica
            // 
            this.gbCaracteristica.Controls.Add(this.dgCaracteristica);
            this.gbCaracteristica.Controls.Add(this.cbCaracteristica);
            this.gbCaracteristica.Controls.Add(this.label1);
            this.gbCaracteristica.Controls.Add(this.btnSalvar);
            this.gbCaracteristica.Controls.Add(this.label2);
            this.gbCaracteristica.Controls.Add(this.txtPeso);
            this.gbCaracteristica.Location = new System.Drawing.Point(7, 8);
            this.gbCaracteristica.Name = "gbCaracteristica";
            this.gbCaracteristica.Size = new System.Drawing.Size(1038, 231);
            this.gbCaracteristica.TabIndex = 7;
            this.gbCaracteristica.TabStop = false;
            this.gbCaracteristica.Text = "Configuração de características";
            // 
            // gbSoftware
            // 
            this.gbSoftware.Controls.Add(this.dgSoftware);
            this.gbSoftware.Controls.Add(this.toolStrip1);
            this.gbSoftware.Location = new System.Drawing.Point(7, 246);
            this.gbSoftware.Name = "gbSoftware";
            this.gbSoftware.Size = new System.Drawing.Size(1038, 354);
            this.gbSoftware.TabIndex = 7;
            this.gbSoftware.TabStop = false;
            this.gbSoftware.Text = "Softwares avaliados";
            // 
            // dgSoftware
            // 
            this.dgSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoftware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSoftware.Location = new System.Drawing.Point(3, 45);
            this.dgSoftware.MultiSelect = false;
            this.dgSoftware.Name = "dgSoftware";
            this.dgSoftware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSoftware.Size = new System.Drawing.Size(1032, 306);
            this.dgSoftware.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBoxCriterio,
            this.toolStripButtonFiltrar,
            this.toolStripSeparator2,
            this.toolStripButtonComparar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1032, 29);
            this.toolStrip1.TabIndex = 15;
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
            // toolStripButtonComparar
            // 
            this.toolStripButtonComparar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonComparar.Image = global::WindowsFormsApplication.Properties.Resources.icone5_gd;
            this.toolStripButtonComparar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonComparar.Name = "toolStripButtonComparar";
            this.toolStripButtonComparar.Size = new System.Drawing.Size(23, 26);
            this.toolStripButtonComparar.Text = "Comparar";
            // 
            // FormPesoCaracteristica
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1054, 612);
            this.Controls.Add(this.gbSoftware);
            this.Controls.Add(this.gbCaracteristica);
            this.Name = "FormPesoCaracteristica";
            this.Text = "Comparação de Softwares";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPesoCaracteristica_FormClosing);
            this.Load += new System.EventHandler(this.FormPesoCaracteristica_Load);
            this.Resize += new System.EventHandler(this.FormPesoCaracteristica_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgCaracteristica)).EndInit();
            this.gbCaracteristica.ResumeLayout(false);
            this.gbCaracteristica.PerformLayout();
            this.gbSoftware.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSoftware)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCaracteristica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dgCaracteristica;
        private System.Windows.Forms.GroupBox gbCaracteristica;
        private System.Windows.Forms.GroupBox gbSoftware;
        private System.Windows.Forms.DataGridViewImageColumn RemoverCaracteristica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCaracteristica;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgPeso;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxCriterio;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonComparar;
        private System.Windows.Forms.DataGridView dgSoftware;
    }
}