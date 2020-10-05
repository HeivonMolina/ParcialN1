using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidas
{
    public abstract class Producto
    {
        

        public int SKU { get; set; }
        public string Nombre { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
    }
}
