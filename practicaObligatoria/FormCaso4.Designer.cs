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
            this.ibiFormas = new System.Windows.Forms.Label();
            this.btbCirculo = new System.Windows.Forms.Button();
            this.btbTrapecio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ibiFormas
            // 
            this.ibiFormas.AutoSize = true;
            this.ibiFormas.Location = new System.Drawing.Point(177, 151);
            this.ibiFormas.Name = "ibiFormas";
            this.ibiFormas.Size = new System.Drawing.Size(202, 16);
            this.ibiFormas.TabIndex = 0;
            this.ibiFormas.Text = "Elija la forma que desea calcular";
            // 
            // btbCirculo
            // 
            this.btbCirculo.Location = new System.Drawing.Point(447, 115);
            this.btbCirculo.Name = "btbCirculo";
            this.btbCirculo.Size = new System.Drawing.Size(120, 35);
            this.btbCirculo.TabIndex = 1;
            this.btbCirculo.Text = "Circulo";
            this.btbCirculo.UseVisualStyleBackColor = true;
            this.btbCirculo.Click += new System.EventHandler(this.btbCirculo_Click);
            // 
            // btbTrapecio
            // 
            this.btbTrapecio.Location = new System.Drawing.Point(447, 169);
            this.btbTrapecio.Name = "btbTrapecio";
            this.btbTrapecio.Size = new System.Drawing.Size(120, 34);
            this.btbTrapecio.TabIndex = 2;
            this.btbTrapecio.Text = "Trapecio";
            this.btbTrapecio.UseVisualStyleBackColor = true;
            this.btbTrapecio.Click += new System.EventHandler(this.btbTrapecio_Click);
            // 
            // FormCaso4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbTrapecio);
            this.Controls.Add(this.btbCirculo);
            this.Controls.Add(this.ibiFormas);
            this.Name = "FormCaso4";
            this.Text = "FormCaso4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ibiFormas;
        private System.Windows.Forms.Button btbCirculo;
        private System.Windows.Forms.Button btbTrapecio;
    }
}