using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Interfaces
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSumatoria_Click(object sender, EventArgs e)
        {
            //Se crea un objeto para invocar el form y posteriormente darle la instrucción para mostrarse.
            frmSumatoria frmSumatoria_1 = new frmSumatoria();
            frmSumatoria_1.Show();
        }

        private void btnAreaCirculo_Click(object sender, EventArgs e)
        {
            frmAreaCirculo frmAreaCirculo_2 = new frmAreaCirculo();
            frmAreaCirculo_2.Show();
        }

        private void btnSueldoEmpleado_Click(object sender, EventArgs e)
        {
            frmSueldoEmpleado frmSueldoEmpleado_3 = new frmSueldoEmpleado();
            frmSueldoEmpleado_3.Show();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            frmPromedio frmPromedio_4 = new frmPromedio();
            frmPromedio_4.Show();
        }

        private void btnCombos_Click(object sender, EventArgs e)
        {
            frmCombos frmCombos_5 = new frmCombos();
            frmCombos_5.Show();
        }
    }
}
