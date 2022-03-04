using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class claseCombos
    {
        #region VARIABLES
        public string[] nombres = new string[1];
        public double[] costoCombos = new double[1];

        //Método de arreglo Jagged Array
        public string[][] productosCombos = new string[1][];
        public int[][] cantidadProductos = new int[1][];

        public int nNombres;
        public int nCostos;
        public int nCombo;
        public int nProductos;

        public int n;
        #endregion

        #region Registrar Nuevo Combo
        public void almacenarNombre()
        {
            nNombres++;
            Array.Resize(ref nombres, nombres.Length + 1);
            productosCombos[nCombo] = new string[1];
            cantidadProductos[nCombo] = new int[1];
        }
        #endregion

        #region Capturar Productos Combo
        public void capturarProdCombo()
        {
            Array.Resize(ref productosCombos[nCombo], productosCombos[nCombo].Length + 1);
            Array.Resize(ref cantidadProductos[nCombo], cantidadProductos[nCombo].Length + 1);
            nProductos++;
        }
        #endregion

        #region Finalizar Combo
        public void crearCombo()
        {
            nProductos = 0;
            Array.Resize(ref productosCombos[nCombo], productosCombos[nCombo].Length - 1);
            Array.Resize(ref cantidadProductos[nCombo], cantidadProductos[nCombo].Length - 1);
            Array.Resize(ref productosCombos, productosCombos.Length + 1);
            Array.Resize(ref cantidadProductos, cantidadProductos.Length + 1);
            nCombo++;
        }
        #endregion

        #region Registrar Costo Combo
        public void almacenarCostosCombos()
        {
            Array.Resize(ref costoCombos, costoCombos.Length + 1);
            nCostos++;
        }

        #endregion

        #region Ver Combos Creados
        public void redimensionarArreglos()
        {
            if (n == 0)
            {
                Array.Resize(ref nombres, nombres.Length - 1);
                Array.Resize(ref costoCombos, costoCombos.Length - 1);
                //redimensionar jagger array ( # columns)
                Array.Resize(ref productosCombos, productosCombos.Length - 1);
                Array.Resize(ref cantidadProductos, cantidadProductos.Length - 1);
            }
        }
        public string imprimirCombos()
        {
            var cadena = "";
            for (int i = 0; i < productosCombos.Length; i++)
            {
                cadena += "Combo: " + nombres[i] + "\nProductos que incluye: " + "\n";

                for (int j = 0; j < productosCombos[i].Length; j++)
                {
                    cadena += cantidadProductos[i][j] + " " + productosCombos[i][j] + "\n";
                }
                cadena += "Costo combo: $" + costoCombos[i] + "\n" + "\n";
            }
            return cadena;
        }
        #endregion
    }
}
