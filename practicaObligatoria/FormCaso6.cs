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
    public partial class FormCaso6 : Form
    {
        public FormCaso6()
        {
            InitializeComponent();
        }

        


    private void btbEnviarDatos_Click(object sender, EventArgs e)
        {
            int hoy = (int)DateTime.Today.Year;
            int anio = Convert.ToInt32(txtAnio.Text);
            int edad = hoy - anio;

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            Imprimir( nombre, apellido,edad);
        }
        #region mis metodos
        
        private void Imprimir(string nombre,string apellido)
        {
            //b
            MessageBox.Show(nombre + ", " + apellido);
        }
        private void Imprimir(string nombre, string apellido, int edad)
        {
            //c
            MessageBox.Show(nombre + " " + apellido + " tiene " + edad + " años");
        }
        #endregion

      
    }
}
