using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Sumador
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
        public decimal Subtotal;
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
        public void ArregloGanancia()
        {
            PrecVenta = (PrecCompra * Ganancia / 100) + PrecCompra;
            Subtotal = PrecVenta * Cantidad;
        }
        #endregion

    }
}
