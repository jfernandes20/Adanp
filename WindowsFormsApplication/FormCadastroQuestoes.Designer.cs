namespace WindowsFormsApplication
{
    partial class FormCadastroQuestoes
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
            this.cbCaracteristica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCaracteristica
            // 
            this.cbCaracteristica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaracteristica.FormattingEnabled = true;
            this.cbCaracteristica.Location = new System.Drawing.Point(50, 53);
            this.cbCaracteristica.Name = "cbCaracteristica";
            this.cbCaracteristica.Size = new System.Drawing.Size(158, 21);
            this.cbCaracteristica.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caracteristicas";
            // 
            // FormCadastroQuestoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCaracteristica);
            this.Name = "FormCadastroQuestoes";
            this.Text = "FormCadastroQuestoes";
            this.Load += new System.EventHandler(this.FormCadastroQuestoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCaracteristica;
        private System.Windows.Forms.Label label1;
    }
}