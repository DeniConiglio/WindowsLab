namespace practicaObligatoria
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
            this.btbIngresar = new System.Windows.Forms.Button();
            this.ibiAltura = new System.Windows.Forms.Label();
            this.ibiBase = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btbIngresar
            // 
            this.btbIngresar.Location = new System.Drawing.Point(381, 155);
            this.btbIngresar.Name = "btbIngresar";
            this.btbIngresar.Size = new System.Drawing.Size(75, 39);
            this.btbIngresar.TabIndex = 0;
            this.btbIngresar.Text = "Ingresar ";
            this.btbIngresar.UseVisualStyleBackColor = true;
            this.btbIngresar.Click += new System.EventHandler(this.btbIngresar_Click);
            // 
            // ibiAltura
            // 
            this.ibiAltura.AutoSize = true;
            this.ibiAltura.Location = new System.Drawing.Point(90, 117);
            this.ibiAltura.Name = "ibiAltura";
            this.ibiAltura.Size = new System.Drawing.Size(89, 16);
            this.ibiAltura.TabIndex = 1;
            this.ibiAltura.Text = "Ingrese Altura";
            // 
            // ibiBase
            // 
            this.ibiBase.AutoSize = true;
            this.ibiBase.Location = new System.Drawing.Point(92, 214);
            this.ibiBase.Name = "ibiBase";
            this.ibiBase.Size = new System.Drawing.Size(87, 16);
            this.ibiBase.TabIndex = 2;
            this.ibiBase.Text = "Ingrese Base";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(183, 117);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 3;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(183, 214);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 22);
            this.txtBase.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.ibiBase);
            this.Controls.Add(this.ibiAltura);
            this.Controls.Add(this.btbIngresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbIngresar;
        private System.Windows.Forms.Label ibiAltura;
        private System.Windows.Forms.Label ibiBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
    }
}

