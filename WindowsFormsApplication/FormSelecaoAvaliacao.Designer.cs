namespace WindowsFormsApplication
{
    partial class FormSelecaoAvaliacao
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
            this.btnComparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(330, 75);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(75, 23);
            this.btnComparar.TabIndex = 3;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // FormSelecaoAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 107);
            this.Controls.Add(this.btnComparar);
            this.Name = "FormSelecaoAvaliacao";
            this.Text = "Selecionar Avalição";
            this.Load += new System.EventHandler(this.FormSelecaoAvaliacao_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnComparar;
    }
}