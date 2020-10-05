using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidas
{
    public class Compra
    {
        public int NumeroCompra { get; set; }
        List<ProductoSimple> productoSimples;
        public Compra()
        {
            productoSimples = new List<ProductoSimple>();
        }
        
        public string Registrar(ProductoSimple producto)
        {
            
            productoSimples.Add(producto);
        
            return "Registrado Correctamente";
        }
    }
}
