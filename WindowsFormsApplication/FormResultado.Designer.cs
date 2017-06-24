namespace WindowsFormsApplication
{
    partial class FormResultado
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
            this.dgResultado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSoftware5 = new System.Windows.Forms.Label();
            this.lbSoftware4 = new System.Windows.Forms.Label();
            this.lbSoftware3 = new System.Windows.Forms.Label();
            this.lbSoftware2 = new System.Windows.Forms.Label();
            this.lbSoftware1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgResultado
            // 
            this.dgResultado.AllowUserToAddRows = false;
            this.dgResultado.AllowUserToDeleteRows = false;
            this.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultado.Location = new System.Drawing.Point(12, 12);
            this.dgResultado.Name = "dgResultado";
            this.dgResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgResultado.Size = new System.Drawing.Size(1071, 405);
            this.dgResultado.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSoftware5);
            this.groupBox1.Controls.Add(this.lbSoftware4);
            this.groupBox1.Controls.Add(this.lbSoftware3);
            this.groupBox1.Controls.Add(this.lbSoftware2);
            this.groupBox1.Controls.Add(this.lbSoftware1);
            this.groupBox1.Location = new System.Drawing.Point(12, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 107);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Legenda";
            // 
            // lbSoftware5
            // 
            this.lbSoftware5.AutoSize = true;
            this.lbSoftware5.Location = new System.Drawing.Point(725, 26);
            this.lbSoftware5.Name = "lbSoftware5";
            this.lbSoftware5.Size = new System.Drawing.Size(0, 13);
            this.lbSoftware5.TabIndex = 0;
            // 
            // lbSoftware4
            // 
            this.lbSoftware4.AutoSize = true;
            this.lbSoftware4.Location = new System.Drawing.Point(370, 65);
            this.lbSoftware4.Name = "lbSoftware4";
            this.lbSoftware4.Size = new System.Drawing.Size(0, 13);
            this.lbSoftware4.TabIndex = 0;
            // 
            // lbSoftware3
            // 
            this.lbSoftware3.AutoSize = true;
            this.lbSoftware3.Location = new System.Drawing.Point(370, 26);
            this.lbSoftware3.Name = "lbSoftware3";
            this.lbSoftware3.Size = new System.Drawing.Size(0, 13);
            this.lbSoftware3.TabIndex = 0;
            // 
            // lbSoftware2
            // 
            this.lbSoftware2.AutoSize = true;
            this.lbSoftware2.Location = new System.Drawing.Point(15, 65);
            this.lbSoftware2.Name = "lbSoftware2";
            this.lbSoftware2.Size = new System.Drawing.Size(0, 13);
            this.lbSoftware2.TabIndex = 0;
            // 
            // lbSoftware1
            // 
            this.lbSoftware1.AutoSize = true;
            this.lbSoftware1.Location = new System.Drawing.Point(15, 26);
            this.lbSoftware1.Name = "lbSoftware1";
            this.lbSoftware1.Size = new System.Drawing.Size(0, 13);
            this.lbSoftware1.TabIndex = 0;
            // 
            // FormResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 536);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgResultado);
            this.Name = "FormResultado";
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.FormResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResultado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSoftware5;
        private System.Windows.Forms.Label lbSoftware4;
        private System.Windows.Forms.Label lbSoftware3;
        private System.Windows.Forms.Label lbSoftware2;
        private System.Windows.Forms.Label lbSoftware1;
    }
}