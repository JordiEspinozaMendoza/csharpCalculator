
namespace TestCalculator
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
            this.userControl11 = new Calculadora.UserControl1();
            this.Calcuadora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(12, 59);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(423, 281);
            this.userControl11.TabIndex = 0;
            // 
            // Calcuadora
            // 
            this.Calcuadora.AutoSize = true;
            this.Calcuadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcuadora.Location = new System.Drawing.Point(12, 18);
            this.Calcuadora.Name = "Calcuadora";
            this.Calcuadora.Size = new System.Drawing.Size(142, 29);
            this.Calcuadora.TabIndex = 1;
            this.Calcuadora.Text = "Calculadora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calcuadora);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Calculadora.UserControl1 userControl11;
        private System.Windows.Forms.Label Calcuadora;
    }
}

