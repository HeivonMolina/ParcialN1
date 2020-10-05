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
        List<ProductoSimple> productosSimples;
        public Compra()
        {
            productosSimples = new List<ProductoSimple>();
        }
        
        public string Registrar(ProductoSimple producto)
        {
            foreach (var item in productosSimples)
            {
                if (producto.Codigo == item.Codigo)
                {
                    return $"El Producto {item.Nombre} ya se ha registrado anteriormente";
                }
            }
            productosSimples.Add(producto);
        
            return "Registrado Correctamente";
        }
        public string RegistrarEntrada(int codigo, int cantidad)
        {
            if (cantidad<=0)
            {
                return "La cantidad debe ser mayor a 0";
            }
            foreach (var item in productosSimples)
            {
                if (item.Codigo==codigo)
                {
                    int SKUSumado = item.SKU + cantidad;
                    //Tal vez deba corregir :v
                    ProductoSimple producto = new ProductoSimple(codigo,SKUSumado, item.Nombre,item.Costo,item.Precio);
                    productosSimples.Remove(item);
                    productosSimples.Add(producto);
                    return "Se añadio Correctamente";
                }
            }
            return "No existe el producto";
        }
    }
}
