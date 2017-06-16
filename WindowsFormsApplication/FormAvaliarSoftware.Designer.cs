namespace WindowsFormsApplication
{
    partial class FormAvaliarSoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvaliarSoftware));
            this.dgSoftware = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxCriterio = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAvaliarSoftware = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoftware)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgSoftware
            // 
            this.dgSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoftware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSoftware.Location = new System.Drawing.Point(0, 29);
            this.dgSoftware.MultiSelect = false;
            this.dgSoftware.Name = "dgSoftware";
            this.dgSoftware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSoftware.Size = new System.Drawing.Size(1079, 584);
            this.dgSoftware.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBoxCriterio,
            this.toolStripButtonFiltrar,
            this.toolStripSeparator2,
            this.toolStripButtonAvaliarSoftware});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1079, 29);
            this.toolStrip1.TabIndex = 12;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButtonFiltrar
            // 
            this.toolStripButtonFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiltrar.Image")));
            this.toolStripButtonFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiltrar.Name = "toolStripButtonFiltrar";
            this.toolStripButtonFiltrar.Size = new System.Drawing.Size(23, 26);
            this.toolStripButtonFiltrar.ToolTipText = "Filtrar";
            this.toolStripButtonFiltrar.Click += new System.EventHandler(this.toolStripButtonFiltrar_Click_1);
            // 
            // toolStripButtonAvaliarSoftware
            // 
            this.toolStripButtonAvaliarSoftware.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAvaliarSoftware.Image = global::WindowsFormsApplication.Properties.Resources.icone5_gd;
            this.toolStripButtonAvaliarSoftware.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAvaliarSoftware.Name = "toolStripButtonAvaliarSoftware";
            this.toolStripButtonAvaliarSoftware.Size = new System.Drawing.Size(23, 26);
            this.toolStripButtonAvaliarSoftware.Text = "Avaliar Software";
            this.toolStripButtonAvaliarSoftware.ToolTipText = "Avaliar Software";
            this.toolStripButtonAvaliarSoftware.Click += new System.EventHandler(this.toolStripButtonAvaliarSoftware_Click);
            // 
            // FormAvaliarSoftware
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1079, 613);
            this.Controls.Add(this.dgSoftware);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormAvaliarSoftware";
            this.Text = "Avaliar Software";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgSoftware)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSoftware;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxCriterio;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiltrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAvaliarSoftware;
    }
}