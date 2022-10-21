namespace practicaObligatoria
{
    partial class FormCaso6
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
            this.btbEnviarDatos = new System.Windows.Forms.Button();
            this.ibiNombre = new System.Windows.Forms.Label();
            this.ibiApellido = new System.Windows.Forms.Label();
            this.ibiNacimiento = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btbEnviarDatos
            // 
            this.btbEnviarDatos.Location = new System.Drawing.Point(473, 203);
            this.btbEnviarDatos.Name = "btbEnviarDatos";
            this.btbEnviarDatos.Size = new System.Drawing.Size(106, 45);
            this.btbEnviarDatos.TabIndex = 0;
            this.btbEnviarDatos.Text = "Enviar Datos";
            this.btbEnviarDatos.UseVisualStyleBackColor = true;
            this.btbEnviarDatos.Click += new System.EventHandler(this.btbEnviarDatos_Click);
            // 
            // ibiNombre
            // 
            this.ibiNombre.AutoSize = true;
            this.ibiNombre.Location = new System.Drawing.Point(73, 121);
            this.ibiNombre.Name = "ibiNombre";
            this.ibiNombre.Size = new System.Drawing.Size(59, 16);
            this.ibiNombre.TabIndex = 1;
            this.ibiNombre.Text = "Nombre:";
            // 
            // ibiApellido
            // 
            this.ibiApellido.AutoSize = true;
            this.ibiApellido.Location = new System.Drawing.Point(72, 214);
            this.ibiApellido.Name = "ibiApellido";
            this.ibiApellido.Size = new System.Drawing.Size(60, 16);
            this.ibiApellido.TabIndex = 2;
            this.ibiApellido.Text = "Apellido:";
            // 
            // ibiNacimiento
            // 
            this.ibiNacimiento.AutoSize = true;
            this.ibiNacimiento.Location = new System.Drawing.Point(72, 304);
            this.ibiNacimiento.Name = "ibiNacimiento";
            this.ibiNacimiento.Size = new System.Drawing.Size(157, 16);
            this.ibiNacimiento.TabIndex = 3;
            this.ibiNacimiento.Text = "Nacimiento: dia/mes/año";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(268, 208);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(126, 22);
            this.txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(268, 121);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(126, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(268, 301);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(38, 22);
            this.txtDia.TabIndex = 7;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(312, 301);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(38, 22);
            this.txtMes.TabIndex = 8;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(356, 301);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(38, 22);
            this.txtAnio.TabIndex = 9;
            // 
            // FormCaso6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.ibiNacimiento);
            this.Controls.Add(this.ibiApellido);
            this.Controls.Add(this.ibiNombre);
            this.Controls.Add(this.btbEnviarDatos);
            this.Name = "FormCaso6";
            this.Text = "FormCaso6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbEnviarDatos;
        private System.Windows.Forms.Label ibiNombre;
        private System.Windows.Forms.Label ibiApellido;
        private System.Windows.Forms.Label ibiNacimiento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAnio;
    }
}