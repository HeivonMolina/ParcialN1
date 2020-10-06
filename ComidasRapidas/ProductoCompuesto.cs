using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidas
{
    public class ProductoCompuesto
    {
        public ProductoCompuesto(string nombre, List<ProductoSimple> productosSimples, int cantidad, decimal costo, decimal precio)
        {
            Nombre = nombre;
            ProductosSimples = productosSimples;
            Cantidad = cantidad;
            Costo = costo;
            Precio = precio;
        }

        public string Nombre { get; set; }
        public List<ProductoSimple> ProductosSimples { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
    }
}
