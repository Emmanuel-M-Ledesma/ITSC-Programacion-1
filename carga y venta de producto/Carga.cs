using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carga_y_venta_de_producto
{
    
    public class Carga
    {
        #region Propiedades
        
        
        public decimal PrecCompra;
        public decimal PrecVenta;
        public decimal Cantidad;
        public string URL;
        public decimal Ganancia;        
        public decimal IVA;
        public decimal Bruto;
        public decimal Total;
        public decimal Contador;
        public decimal VentaRealizada;
        public decimal GananciaObtenida;
        public string residual, residual1 = null;
        public bool vf, vf2 = false;
        public decimal contadorV;

        #endregion

        #region Constructor



        #endregion

        #region Metodos

        public void GananciaStock()
        {
            
            Ganancia = (PrecCompra * PrecVenta / 100) * Cantidad;
            PrecVenta = (PrecCompra * PrecVenta / 100) + PrecCompra;
        }
        public void TotalStock()
        {
            Total = PrecCompra * Cantidad;
        }
        public void TotalIndividual()
        {
            Total = (PrecCompra * Ganancia / 100) * Cantidad;
            PrecVenta = (PrecCompra * Cantidad) + Total; 

        }
        public void IvaBruto()
        {
            IVA = Total / 100 * 21;
            Bruto = Total - IVA;
        }

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
            

        }

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
            contadorV = contadorV + 1 ;
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
        

        #endregion
    }
}
