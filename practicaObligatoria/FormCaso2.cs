using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaObligatoria
{
    public partial class FormCaso2 : Form
    {
        public FormCaso2()
        {
            InitializeComponent();
        }

        private void btbEnviar_Click(object sender, EventArgs e)
        {
            int Valor = Convert.ToInt32(txtvalor.Text);
            string Tabla = "";
            
            for (int i = 0; i <= 12; i++)
            {
                int Multi = Valor * i;
                Tabla += Convert.ToString(Valor) + "x" + Convert.ToString(i) + "=" + Convert.ToString(Multi) + "\n";
                
            }
            MessageBox.Show("Tabla: \n"+Tabla);
        }

        
        
    }
}
