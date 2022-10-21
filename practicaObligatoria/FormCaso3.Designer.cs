namespace practicaObligatoria
{
    partial class FormCaso3
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
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.ibiIngresoNro = new System.Windows.Forms.Label();
            this.btbEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(259, 123);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 22);
            this.txtvalor.TabIndex = 0;
            // 
            // ibiIngresoNro
            // 
            this.ibiIngresoNro.AutoSize = true;
            this.ibiIngresoNro.Location = new System.Drawing.Point(151, 129);
            this.ibiIngresoNro.Name = "ibiIngresoNro";
            this.ibiIngresoNro.Size = new System.Drawing.Size(102, 16);
            this.ibiIngresoNro.TabIndex = 1;
            this.ibiIngresoNro.Text = "Ingrese un valor";
            // 
            // btbEnviar
            // 
            this.btbEnviar.Location = new System.Drawing.Point(525, 122);
            this.btbEnviar.Name = "btbEnviar";
            this.btbEnviar.Size = new System.Drawing.Size(75, 23);
            this.btbEnviar.TabIndex = 2;
            this.btbEnviar.Text = "Enviar";
            this.btbEnviar.UseVisualStyleBackColor = true;
            this.btbEnviar.Click += new System.EventHandler(this.btbEnviar_Click);
            // 
            // FormCaso2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbEnviar);
            this.Controls.Add(this.ibiIngresoNro);
            this.Controls.Add(this.txtvalor);
            this.Name = "FormCaso2";
            this.Text = "FormCaso2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label ibiIngresoNro;
        private System.Windows.Forms.Button btbEnviar;
    }
}