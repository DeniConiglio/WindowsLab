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

        private void btbIngreso_Click(object sender, EventArgs e)
        {
            int Edad= Convert.ToInt32(txtEdad.Text);

            if(Edad==0)
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                if(Edad<18)
                {
                    MessageBox.Show("MENOR DE EDAD");
                }
                else
                {
                    if(Edad<60)
                    {
                        MessageBox.Show("MAYOR DE EDAD");
                    }
                    else
                    {
                        MessageBox.Show("ADULTO MAYOR");
                    }
                }
            }
        }
    }
}
