namespace practicaObligatoria
{
    partial class FormCaso4
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
            this.ibiLong = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.btbDiametro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ibiLong
            // 
            this.ibiLong.AutoSize = true;
            this.ibiLong.Location = new System.Drawing.Point(158, 147);
            this.ibiLong.Name = "ibiLong";
            this.ibiLong.Size = new System.Drawing.Size(158, 16);
            this.ibiLong.TabIndex = 1;
            this.ibiLong.Text = "Logitud de Circunferencia";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(344, 147);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(100, 22);
            this.txtLongitud.TabIndex = 2;
            // 
            // btbDiametro
            // 
            this.btbDiametro.Location = new System.Drawing.Point(503, 141);
            this.btbDiametro.Name = "btbDiametro";
            this.btbDiametro.Size = new System.Drawing.Size(225, 34);
            this.btbDiametro.TabIndex = 4;
            this.btbDiametro.Text = "Calcular Diametro";
            this.btbDiametro.UseVisualStyleBackColor = true;
            this.btbDiametro.Click += new System.EventHandler(this.btbDiametro_Click);
            // 
            // FormCaso4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbDiametro);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.ibiLong);
            this.Name = "FormCaso4";
            this.Text = "FormCaso4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ibiLong;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Button btbDiametro;
    }
}