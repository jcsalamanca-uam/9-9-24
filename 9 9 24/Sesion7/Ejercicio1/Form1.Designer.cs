namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbGrades = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGrades = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSum);
            this.groupBox1.Controls.Add(this.lblAverage);
            this.groupBox1.Controls.Add(this.tbGrades);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbGrades);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de nota";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbGrades
            // 
            this.lbGrades.FormattingEnabled = true;
            this.lbGrades.Location = new System.Drawing.Point(0, 77);
            this.lbGrades.Name = "lbGrades";
            this.lbGrades.Size = new System.Drawing.Size(276, 251);
            this.lbGrades.TabIndex = 1;
            this.lbGrades.SelectedIndexChanged += new System.EventHandler(this.LbGrades_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la nota";
            // 
            // tbGrades
            // 
            this.tbGrades.Location = new System.Drawing.Point(104, 52);
            this.tbGrades.Name = "tbGrades";
            this.tbGrades.Size = new System.Drawing.Size(100, 20);
            this.tbGrades.TabIndex = 2;
            this.tbGrades.TextChanged += new System.EventHandler(this.TbGrades_TextChanged);
            this.tbGrades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGrades_KeyPress);
            // 
            // lblAverage
            // 
            this.lblAverage.Location = new System.Drawing.Point(176, 346);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(137, 23);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "Promedio: 0";
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSum
            // 
            this.lblSum.Location = new System.Drawing.Point(-3, 346);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(100, 23);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "Suma: 0";
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Arreglos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbGrades;
        private System.Windows.Forms.TextBox tbGrades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblAverage;
    }
}

