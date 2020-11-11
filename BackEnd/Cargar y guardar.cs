using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Cargar_y_guardar
    {
        #region Propiedades
        Sumador Arreglo = new Sumador();
        public decimal GananciaObtenida;
        public string residual, residual1 = null;
        public bool vf, vf2 = false;
        public decimal contadorV;
        public decimal PrecCompra, Ganancia, Cantidad;
        #endregion

        #region Metodos

        public void Guardartxt()
        {
            TextWriter txt = new StreamWriter(@"inicio.txt");
            txt.WriteLine(GananciaObtenida);
            txt.Flush();
            txt.Close();
            txt = null;

        }
        public void cargartxt()
        {
            TextReader txt2 = new StreamReader(@"inicio.txt");
            residual = txt2.ReadLine();
        }
        public void ContadorVenta()
        {
            if (residual1 != null && vf2 == false)
            {
                contadorV = System.Convert.ToDecimal(residual1);
                vf2 = true;
            }
            contadorV = contadorV + 1;
            TextWriter contado = new StreamWriter(@"contador.txt");
            contado.WriteLine(contadorV);
            contado.Flush();
            contado.Close();
            contado = null;
        }

        public void CargarContador()
        {
            TextReader txt3 = new StreamReader(@"contador.txt");
            residual1 = txt3.ReadLine();
        }
        //TODO: Guardartxt, cargartxt, contadorventa, cargarcontador, gananciaobt estan en CARGAR Y GUARDAR
        public void GananciaObt()
        {
            if (residual != null)
            {
                if (vf == false)
                {
                    GananciaObtenida = System.Convert.ToDecimal(residual);
                    vf = true;
                }
            }
            GananciaObtenida = ((PrecCompra * Ganancia / 100) * Cantidad) + GananciaObtenida;

            //todo: PrecCompra, Ganancia, Cantidad
        }

        #endregion
    }
}
