using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidas
{
    public class ProductoCompuesto: Producto
    {
        public List<ProductoSimple> ProductosSimples { get; set; }
        public List<ProductoCompuesto> ProductosCompuestos { get; set; }
    }
}
