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
    public partial class frmAreaCirculo : Form
    {
        public frmAreaCirculo()
        {
            InitializeComponent();
        }

        claseAreaCirculo objArea = new claseAreaCirculo();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (txtRadio.Text == "")
            {
                errorProvider1.SetError(txtRadio, "Debe ingresar un número");
                txtRadio.Focus();
                return;
            }
            errorProvider1.SetError(txtRadio, "");

            double radio;
            if (!Double.TryParse(txtRadio.Text, out radio))
            {
                errorProvider1.SetError(txtRadio, "Debe ingresar solo números en el campo de radio");
                txtRadio.Focus();
                return;
            }
            errorProvider1.SetError(txtRadio, "");

            objArea.radio = Convert.ToDouble(txtRadio.Text);
            lblResultado.Text = "El área es: " +  objArea.calcularArea() + " cm2" ;
        }
    }
}
