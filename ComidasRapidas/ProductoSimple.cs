using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidas
{
    public class ProductoSimple: Producto
    {
        public ProductoSimple(int sku, string nombre, decimal costo, decimal precio)
        {
            SKU = sku;
            Nombre = nombre;
            Costo = costo;
            Precio = precio;
        }
    }
}
