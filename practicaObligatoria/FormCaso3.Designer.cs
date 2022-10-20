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
            this.btbIngreso = new System.Windows.Forms.Button();
            this.ibiEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btbIngreso
            // 
            this.btbIngreso.Location = new System.Drawing.Point(430, 160);
            this.btbIngreso.Name = "btbIngreso";
            this.btbIngreso.Size = new System.Drawing.Size(75, 23);
            this.btbIngreso.TabIndex = 0;
            this.btbIngreso.Text = "Ingresar";
            this.btbIngreso.UseVisualStyleBackColor = true;
            this.btbIngreso.Click += new System.EventHandler(this.btbIngreso_Click);
            // 
            // ibiEdad
            // 
            this.ibiEdad.AutoSize = true;
            this.ibiEdad.Location = new System.Drawing.Point(106, 167);
            this.ibiEdad.Name = "ibiEdad";
            this.ibiEdad.Size = new System.Drawing.Size(88, 16);
            this.ibiEdad.TabIndex = 1;
            this.ibiEdad.Text = "Ingrese Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(216, 161);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 22);
            this.txtEdad.TabIndex = 2;
            // 
            // FormCaso3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.ibiEdad);
            this.Controls.Add(this.btbIngreso);
            this.Name = "FormCaso3";
            this.Text = "FormCaso3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbIngreso;
        private System.Windows.Forms.Label ibiEdad;
        private System.Windows.Forms.TextBox txtEdad;
    }
}