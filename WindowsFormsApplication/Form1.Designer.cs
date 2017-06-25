namespace WindowsFormsApplication
{
    partial class Form1
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
            this.dgTeste = new System.Windows.Forms.DataGridView();
            this.labelHora = new System.Windows.Forms.Label();
            this.Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTeste
            // 
            this.dgTeste.AllowUserToAddRows = false;
            this.dgTeste.AllowUserToDeleteRows = false;
            this.dgTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTeste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tempo});
            this.dgTeste.Location = new System.Drawing.Point(12, 34);
            this.dgTeste.Name = "dgTeste";
            this.dgTeste.ReadOnly = true;
            this.dgTeste.Size = new System.Drawing.Size(709, 341);
            this.dgTeste.TabIndex = 5;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(652, 460);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(0, 13);
            this.labelHora.TabIndex = 6;
            // 
            // Tempo
            // 
            this.Tempo.HeaderText = "Tempo";
            this.Tempo.Name = "Tempo";
            this.Tempo.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 491);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.dgTeste);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTeste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTeste;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempo;
    }
}

