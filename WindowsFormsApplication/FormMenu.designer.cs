namespace WindowsFormsApplication
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            this.menusStrip = new System.Windows.Forms.MenuStrip();
            this.softwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaliaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeQuestõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelRodape = new System.Windows.Forms.Panel();
            this.labelHora = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUsuarioCorrente = new System.Windows.Forms.Label();
            this.menusStrip.SuspendLayout();
            this.panelRodape.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menusStrip
            // 
            this.menusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareToolStripMenuItem,
            this.configuraçãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menusStrip.Location = new System.Drawing.Point(0, 0);
            this.menusStrip.Name = "menusStrip";
            this.menusStrip.Size = new System.Drawing.Size(1013, 24);
            this.menusStrip.TabIndex = 0;
            this.menusStrip.Text = "MenuStrip";
            // 
            // softwareToolStripMenuItem
            // 
            this.softwareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.avaliaçãoToolStripMenuItem});
            this.softwareToolStripMenuItem.Name = "softwareToolStripMenuItem";
            this.softwareToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.softwareToolStripMenuItem.Text = "Software";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // avaliaçãoToolStripMenuItem
            // 
            this.avaliaçãoToolStripMenuItem.Name = "avaliaçãoToolStripMenuItem";
            this.avaliaçãoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.avaliaçãoToolStripMenuItem.Text = "Avaliação";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeQuestõesToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // cadastroDeQuestõesToolStripMenuItem
            // 
            this.cadastroDeQuestõesToolStripMenuItem.Name = "cadastroDeQuestõesToolStripMenuItem";
            this.cadastroDeQuestõesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cadastroDeQuestõesToolStripMenuItem.Text = "Cadastro de Questões";
            this.cadastroDeQuestõesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeQuestõesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelRodape
            // 
            this.panelRodape.Controls.Add(this.labelHora);
            this.panelRodape.Controls.Add(this.panel1);
            this.panelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRodape.Location = new System.Drawing.Point(0, 554);
            this.panelRodape.Name = "panelRodape";
            this.panelRodape.Size = new System.Drawing.Size(1013, 34);
            this.panelRodape.TabIndex = 4;
            // 
            // labelHora
            // 
            this.labelHora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(956, 11);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(49, 13);
            this.labelHora.TabIndex = 5;
            this.labelHora.Text = "99:99:99";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelUsuarioCorrente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 34);
            this.panel1.TabIndex = 12;
            // 
            // labelUsuarioCorrente
            // 
            this.labelUsuarioCorrente.AutoSize = true;
            this.labelUsuarioCorrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioCorrente.Location = new System.Drawing.Point(3, 11);
            this.labelUsuarioCorrente.Name = "labelUsuarioCorrente";
            this.labelUsuarioCorrente.Size = new System.Drawing.Size(49, 13);
            this.labelUsuarioCorrente.TabIndex = 4;
            this.labelUsuarioCorrente.Text = "ADANP";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 588);
            this.Controls.Add(this.panelRodape);
            this.Controls.Add(this.menusStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menusStrip;
            this.Name = "FormMenu";
            this.Text = "Adanp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menusStrip.ResumeLayout(false);
            this.menusStrip.PerformLayout();
            this.panelRodape.ResumeLayout(false);
            this.panelRodape.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menusStrip;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem softwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaliaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeQuestõesToolStripMenuItem;
        private System.Windows.Forms.Panel panelRodape;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUsuarioCorrente;
    }
}



