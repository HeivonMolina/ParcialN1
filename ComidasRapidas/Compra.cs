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
        
        public Compra()
        {
            
        }
        
        public string Registrar(ProductoSimple producto)
        {
            foreach (var item in ListaProductos.ProductoSimples)
            {
                if (producto.Codigo == item.Codigo)
                {
                    return $"El Producto {item.Nombre} ya se ha registrado anteriormente";
                }
            }
            ListaProductos.ProductoSimples.Add(producto);
        
            return "Registrado Correctamente";
        }
        public string RegistrarEntrada(int codigo, int cantidad)
        {
            if (cantidad<=0)
            {
                return "La cantidad debe ser mayor a 0";
            }
            foreach (var item in ListaProductos.ProductoSimples)
            {
                if (item.Codigo==codigo)
                {
                    int SKUSumado = item.SKU + cantidad;
                    //Tal vez deba corregir :v
                    ProductoSimple producto = new ProductoSimple(codigo,SKUSumado, item.Nombre,item.Costo,item.Precio);
                    ListaProductos.ProductoSimples.Remove(item);
                    ListaProductos.ProductoSimples.Add(producto);
                    return $"Se ha registrado una entrada para el Producto {item.Nombre} correctamente";
                }
            }
            return "No existe el producto";
        }
    }
}
