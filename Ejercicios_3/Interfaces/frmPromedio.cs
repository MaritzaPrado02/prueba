using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocio;

namespace Interfaces
{
    public partial class frmPromedio : Form
    {
        public frmPromedio()
        {
            InitializeComponent();
            btnCalcularPromedio.Enabled = false; //Inhabilita el control
        }

        clasePromedio objPromedio = new clasePromedio();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (txtCalificacion.Text == "")
            {
                errorProvider1.SetError(txtCalificacion, "Debe ingresar una calificación");
                txtCalificacion.Focus();
                return;
            }
            errorProvider1.SetError(txtCalificacion, "");

            double calificacion;
            if (!Double.TryParse(txtCalificacion.Text, out calificacion))
            {
                errorProvider1.SetError(txtCalificacion, "Debe ingresar solo números en el campo de radio");
                txtCalificacion.Focus();
                return;
            }
            errorProvider1.SetError(txtCalificacion, "");


            calificacion = Convert.ToDouble(txtCalificacion.Text);
            if (calificacion < 0)
            {
                errorProvider1.SetError(txtCalificacion, "Debe ingresar un valor positivo");
                txtCalificacion.Focus();
                return;
            }
            errorProvider1.SetError(txtCalificacion, "");

            objPromedio.calificacion = Convert.ToDouble(txtCalificacion.Text);
            objPromedio.sumarCalificaciones();
            MessageBox.Show("Calificación capturada");
            txtCalificacion.Text = ""; // LIMPIAR CONTROL (txtCalificacion)
            btnCalcularPromedio.Enabled = true; //Habilita el boton para calcular promedio.
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            lblResultadoPromedio.Text = "El promedio es: " + objPromedio.calcularPromedio();
        }
    }
}
