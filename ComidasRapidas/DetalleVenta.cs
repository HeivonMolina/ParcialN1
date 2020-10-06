using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidas
{
    class DetalleVenta
    {
        public DetalleVenta(int cantidad, decimal costo, decimal precio, ProductoSimple productoSimple, ProductoCompuesto productoCompuesto)
        {
            Cantidad = cantidad;
            Costo = costo;
            Precio = precio;
            this.productoSimple = productoSimple;
            this.productoCompuesto = productoCompuesto;
        }
        public DetalleVenta()
        {

        }

        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public ProductoSimple productoSimple { get; set; }
        public ProductoCompuesto productoCompuesto { get; set; }
    }
}
