using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carga_y_venta_de_producto
{
    class Carga
    {
        #region Propiedades

        public decimal PrecCompra;
        public decimal PrecVenta;
        public decimal Cantidad;
        public decimal Total;
        public decimal Ganancia;

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



        #endregion
    }
}
