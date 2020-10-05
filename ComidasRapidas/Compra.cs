﻿using System;
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
            foreach (var item in productoSimples)
            {
                if (producto.Nombre.Equals(item.Nombre))
                {
                    return $"El Producto {item.Nombre} ya se ha registrado anteriormente";
                }
            }
            productoSimples.Add(producto);
        
            return "Registrado Correctamente";
        }
    }
}
