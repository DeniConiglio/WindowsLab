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
    public partial class FormCaso5 : Form
    {
        public FormCaso5()
        {
            InitializeComponent();
        }

        private void btbIngresar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Sexo= txtSexo.Text;
            string Tusuario= txtUsuario.Text;

            if(Tusuario=="administrador" || Tusuario=="estandar" || Tusuario=="invitado")
            {
                if(Sexo=="F" || Sexo=="M")
                {
                    MessageBox.Show("Nombre: " + Nombre + "\n" + "Sexo: " + Sexo + "\n" + "Tipo de usuario: " + Tusuario + "\n");
                }
                else
                {
                    MessageBox.Show("sexo incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }

        }
    }
}
