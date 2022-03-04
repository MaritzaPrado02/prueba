using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocio; //referencia

namespace Interfaces
{
    public partial class frmSueldoEmpleado : Form
    {
        public frmSueldoEmpleado()
        {
            InitializeComponent();
        }

        claseSueldoEmpleado objSueldo = new claseSueldoEmpleado();

        private void btnCalcularSueldo_Click(object sender, EventArgs e)
        {
            //Validación para verificar que la caja de texto no este vacia (txtSueldoDiario)
            if (txtSueldoDiario.Text == "")
            {
                errorProvider1.SetError(txtSueldoDiario, "Debe ingresar un número");
                txtSueldoDiario.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldoDiario, "");


            //Validación para verificar que el control NumericUpDown NO este vacio(nudDiasTrabajados)
            if (nudDiasTrabajados.Text == "")
            {
                errorProvider1.SetError(nudDiasTrabajados, "Debe seleccionar/ingresar la cantidad de días trajabados");
                nudDiasTrabajados.Focus();
                return;
            }
            errorProvider1.SetError(nudDiasTrabajados, "");

            /*Validación para verificar que lo que se ingrese en la cantidad de dias no sea 
             * un valor numerico o un numero mayor a 7*/

            int diasTrabajados;
            diasTrabajados = Convert.ToInt32(nudDiasTrabajados.Text);
            if (diasTrabajados <= 0 || diasTrabajados > 7)
            {
                errorProvider1.SetError(nudDiasTrabajados, "Debe ingresar un número positivo y menor a 7");
                nudDiasTrabajados.Focus();
                return;
            }
            errorProvider1.SetError(nudDiasTrabajados, "");

            //Validación del Textbox de sueldo (que unicamente ingrese valores númericos).
            double sueldo;
            if (!Double.TryParse(txtSueldoDiario.Text, out sueldo))
            {
                errorProvider1.SetError(txtSueldoDiario, "Debe ingresar solo números en el campo de radio");
                txtSueldoDiario.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldoDiario, "");

            double sueldoDiario;
            sueldoDiario = Convert.ToDouble(txtSueldoDiario.Text);
            if (sueldoDiario < 0)
            {
                errorProvider1.SetError(txtSueldoDiario, "Debe ingresar un cantidad positiva");
                txtSueldoDiario.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldoDiario, "");


            objSueldo.diasTrabajados = Convert.ToInt32(nudDiasTrabajados.Text);
            objSueldo.sueldoDiario = Convert.ToDouble(txtSueldoDiario.Text);
            lblResultadoSueldo.Text = "El sueldo del empleado es: $" + objSueldo.calcularSueldo();
        }
    }
}
