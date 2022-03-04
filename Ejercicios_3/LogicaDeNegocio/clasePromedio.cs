using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class clasePromedio
    {
        public int calificacionCap = 0;
        public double sumaCalificacion, calificacion, promedio;

        public void sumarCalificaciones()
        {
            sumaCalificacion += calificacion;
            calificacionCap++;
        }

        public double calcularPromedio()
        {
            promedio = sumaCalificacion / calificacionCap;
            return promedio;
        }
    }
}
