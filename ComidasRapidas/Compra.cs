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
                if (producto.Nombre.Equals(item.Nombre))
                {
                    return $"El Producto {item.Nombre} ya se ha registrado anteriormente";
                }
            }
            productosSimples.Add(producto);
        
            return "Registrado Correctamente";
        }
        public string RegistrarEntrada(string nombre, int cantidad)
        {
            foreach (var item in productosSimples)
            {
                if (item.Nombre.Equals(nombre))
                {
                    int SKUSumado = item.SKU + cantidad;
                    //Tal vez deba corregir :v
                    ProductoSimple producto = new ProductoSimple(SKUSumado,item.Nombre,item.Costo,item.Precio);
                    productosSimples.Remove(item);
                    productosSimples.Add(producto);
                    return "Se añadio Correctamente";
                }
            }
            return "No existe el producto";
        }
    }
}
