using Microsoft.VisualBasic;
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
    public partial class FormCaso4 : Form
    {
        public FormCaso4()
        {
            InitializeComponent();
        }

        private void btbCirculo_Click(object sender, EventArgs e)
        {
            int Longitud = Convert.ToInt32(Interaction.InputBox("Ingrese longitud"));
            decimal pi = (decimal)3.14;
            decimal Diametro = (Longitud * pi)* (Longitud * pi);

            MessageBox.Show("Diametro: " + Diametro);
        }

        private void btbTrapecio_Click(object sender, EventArgs e)
        {
            int Base1 = Convert.ToInt32(Interaction.InputBox("Ingrese Base 1"));
            int Base2 = Convert.ToInt32(Interaction.InputBox("Ingrese Base 2"));
            int Altura = Convert.ToInt32(Interaction.InputBox("Ingrese Altura"));
            int sumasBases = Base1 + Base2;
            int Area = (sumasBases/2)*Altura;

            MessageBox.Show("El area del trapecio es: "+Area);
        }
    }
}
