namespace practicaObligatoria
{
    partial class FormCaso5
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
            this.btbIngresar = new System.Windows.Forms.Button();
            this.ibiNombre = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.ibiUsuario = new System.Windows.Forms.Label();
            this.ibiSexo = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btbIngresar
            // 
            this.btbIngresar.Location = new System.Drawing.Point(543, 152);
            this.btbIngresar.Name = "btbIngresar";
            this.btbIngresar.Size = new System.Drawing.Size(108, 33);
            this.btbIngresar.TabIndex = 0;
            this.btbIngresar.Text = "Ingresar";
            this.btbIngresar.UseVisualStyleBackColor = true;
            this.btbIngresar.Click += new System.EventHandler(this.btbIngresar_Click);
            // 
            // ibiNombre
            // 
            this.ibiNombre.AutoSize = true;
            this.ibiNombre.Location = new System.Drawing.Point(189, 76);
            this.ibiNombre.Name = "ibiNombre";
            this.ibiNombre.Size = new System.Drawing.Size(122, 16);
            this.ibiNombre.TabIndex = 1;
            this.ibiNombre.Text = "Nombre de usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(317, 233);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(136, 22);
            this.txtUsuario.TabIndex = 2;
            // 
            // ibiUsuario
            // 
            this.ibiUsuario.AutoSize = true;
            this.ibiUsuario.Location = new System.Drawing.Point(189, 239);
            this.ibiUsuario.Name = "ibiUsuario";
            this.ibiUsuario.Size = new System.Drawing.Size(101, 16);
            this.ibiUsuario.TabIndex = 3;
            this.ibiUsuario.Text = "Tipo de usuario";
            // 
            // ibiSexo
            // 
            this.ibiSexo.AutoSize = true;
            this.ibiSexo.Location = new System.Drawing.Point(189, 160);
            this.ibiSexo.Name = "ibiSexo";
            this.ibiSexo.Size = new System.Drawing.Size(38, 16);
            this.ibiSexo.TabIndex = 4;
            this.ibiSexo.Text = "Sexo";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(317, 157);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(136, 22);
            this.txtSexo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(317, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // FormCaso5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.ibiSexo);
            this.Controls.Add(this.ibiUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.ibiNombre);
            this.Controls.Add(this.btbIngresar);
            this.Name = "FormCaso5";
            this.Text = "FormCaso5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbIngresar;
        private System.Windows.Forms.Label ibiNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label ibiUsuario;
        private System.Windows.Forms.Label ibiSexo;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtNombre;
    }
}