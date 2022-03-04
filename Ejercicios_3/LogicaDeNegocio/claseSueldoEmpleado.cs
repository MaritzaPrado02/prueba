using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicaDeNegocio
{
    public class claseSueldoEmpleado
    {
        public int diasTrabajados;
        public double sueldoDiario, sueldoFinal;

        public double calcularSueldo()
        {
            sueldoFinal = sueldoDiario * diasTrabajados;
            return sueldoFinal;
        }
    }
}
