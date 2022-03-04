using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicaDeNegocio
{
    public class claseAreaCirculo
    {
        public double radio, area;

        public double calcularArea()
        {
            area = 3.1416 * (radio * radio);
            return area;
        }
    }
}
