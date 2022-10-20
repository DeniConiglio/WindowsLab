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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbIngresar_Click(object sender, EventArgs e)
        {
            calcArea();
        }
        #region
        private void calcArea()
        {

            int Altura = Convert.ToInt32(txtAltura.Text);
            int Base = Convert.ToInt32(txtBase.Text);
            int Area;

            Area = Altura* Base;

            MessageBox.Show("El area del rectangulo es: " + Area);
        }
        #endregion
    }
}
