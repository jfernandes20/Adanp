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
            this.panelRodape = new System.Windows.Forms.Panel();
            this.LbData = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUsuarioCorrente = new System.Windows.Forms.Label();
            this.menusStrip = new System.Windows.Forms.MenuStrip();
            this.softwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaliaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRodape.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRodape
            // 
            this.panelRodape.Controls.Add(this.LbData);
            this.panelRodape.Controls.Add(this.panel1);
            this.panelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRodape.Location = new System.Drawing.Point(0, 554);
            this.panelRodape.Name = "panelRodape";
            this.panelRodape.Size = new System.Drawing.Size(1013, 34);
            this.panelRodape.TabIndex = 4;
            // 
            // LbData
            // 
            this.LbData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LbData.Location = new System.Drawing.Point(748, 11);
            this.LbData.Name = "LbData";
            this.LbData.Size = new System.Drawing.Size(253, 14);
            this.LbData.TabIndex = 13;
            this.LbData.Text = "sexta-feira, 28 de Fevereiro de 2017";
            this.LbData.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelUsuarioCorrente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 34);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication.Properties.Resources.Ícone_ES_Trasp;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelUsuarioCorrente
            // 
            this.labelUsuarioCorrente.AutoSize = true;
            this.labelUsuarioCorrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioCorrente.Location = new System.Drawing.Point(47, 11);
            this.labelUsuarioCorrente.Name = "labelUsuarioCorrente";
            this.labelUsuarioCorrente.Size = new System.Drawing.Size(49, 13);
            this.labelUsuarioCorrente.TabIndex = 4;
            this.labelUsuarioCorrente.Text = "ADANP";
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
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // avaliaçãoToolStripMenuItem
            // 
            this.avaliaçãoToolStripMenuItem.Name = "avaliaçãoToolStripMenuItem";
            this.avaliaçãoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.avaliaçãoToolStripMenuItem.Text = "Avaliação";
            this.avaliaçãoToolStripMenuItem.Click += new System.EventHandler(this.avaliaçãoToolStripMenuItem_Click);
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastrarToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.configuraçãoToolStripMenuItem.Text = "Questões";
            // 
            // CadastrarToolStripMenuItem
            // 
            this.CadastrarToolStripMenuItem.Name = "CadastrarToolStripMenuItem";
            this.CadastrarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.CadastrarToolStripMenuItem.Text = "Cadastro";
            this.CadastrarToolStripMenuItem.Click += new System.EventHandler(this.CadastrarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.BackGround;
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
            this.panelRodape.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menusStrip.ResumeLayout(false);
            this.menusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menusStrip;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaliaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CadastrarToolStripMenuItem;
        private System.Windows.Forms.Panel panelRodape;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUsuarioCorrente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbData;
    }
}



