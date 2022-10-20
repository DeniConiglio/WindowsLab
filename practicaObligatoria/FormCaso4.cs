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

        private void btbDiametro_Click(object sender, EventArgs e)
        {
            decimal Longitud = Convert.ToDecimal(txtLongitud.Text);
            decimal pi=2,14;
            decimal Diametro = Longitud * pi;

            MessageBox.Show("Diametro: " + Diametro);
        }
    }
}
