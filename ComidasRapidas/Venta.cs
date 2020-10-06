using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidasRapidas
{
    public class Venta
    {
        List<DetalleVenta> detalleVentas;
        public Venta()
        {
            detalleVentas = new List<DetalleVenta>();
        }
        public int NumeroVenta { get; set; }
        public string VenderProductoSimple(int codigo, int cantidad)
        {
            if (cantidad <=0)
            {
                return "La cantidad debe ser mayor a 0";
            }
            foreach (var item in ListaProductos.ProductoSimples)
            {
                if (item.Codigo == codigo)
                {
                    if (cantidad>item.SKU)
                    {
                        return "No hay la cantidad solicitada para la venta de este producto";
                    }
                    int SKURestado = item.SKU - cantidad;
                    decimal costos=0m, precios=0m;
                    ProductoSimple producto = new ProductoSimple(codigo, SKURestado, item.Nombre, item.Costo, item.Precio);
                    ListaProductos.ProductoSimples.Remove(item);
                    ListaProductos.ProductoSimples.Add(producto);
                    costos = item.Costo * cantidad;
                    precios = item.Precio * cantidad;
                    DetalleVenta detalleVenta = new DetalleVenta(cantidad, costos, precios,producto,null);
                    detalleVentas.Add(detalleVenta);
                    return $"Se realizo la venta de {item.Nombre} correctamente";
                }
            }
            return "No existe producto";
        }
        public string VenderProductoCompuesto(int codigo, int cantidad)
        {

            return "";
        }
    }
}
