using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocio; //proyecto referenciado


namespace Interfaces
{
    public partial class frmSumatoria : Form
    {

        claseSumatoria objSumatoria = new claseSumatoria();
        public frmSumatoria()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

            //VALIDACIONES 

            //Verificar que no este vacío (txtNumero1)
            if (txtNumero1.Text == "")
            {
                errorProvider1.SetError(txtNumero1, "Debe ingresar un número");
                txtNumero1.Focus();
                return;
            }
            errorProvider1.SetError(txtNumero1, "");
            //Verificar que sea un número
            double numero1;
            if (!Double.TryParse(txtNumero1.Text, out numero1))
            {
                errorProvider1.SetError(txtNumero1, "Debe ingresar solo números en el campo de número 1");
                txtNumero1.Focus();
                return;
            }
            errorProvider1.SetError(txtNumero1, "");
            //Verificar que no este vacío (txtNumero2)
            if (txtNumero2.Text == "")
            {
                errorProvider1.SetError(txtNumero2, "Debe ingresar un número");
                txtNumero2.Focus();
                return;
            }
            errorProvider1.SetError(txtNumero2, "");
            //Vericar que sea un número
            double numero2;
            if (!Double.TryParse(txtNumero2.Text, out numero2))
            {
                errorProvider1.SetError(txtNumero2, "Debe ingresar solo números en el campo de número 2");
                txtNumero2.Focus();
                return;
            }
            errorProvider1.SetError(txtNumero2, "");


            objSumatoria.numero1 = Convert.ToDouble(txtNumero1.Text);
            objSumatoria.numero2 = Convert.ToDouble(txtNumero2.Text);

            //Muestra de resultado

            lblResultado.Text = "La suma es: " + objSumatoria.sumar();


        }
    }
}
