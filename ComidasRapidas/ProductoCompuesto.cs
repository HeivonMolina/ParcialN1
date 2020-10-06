using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidas
{
    public class ProductoCompuesto
    {
        public string Nombre { get; set; }
        public List<ProductoSimple> ProductosSimples { get; set; }
        public int Cantidad { get; set; }
    }
}
