using ComidasRapidas;
using NUnit.Framework;

namespace ComidasRapitas.Tests
{
    public class RegistroComprasTests
    {
        [SetUp]
        public void Setup()
        {
        }

        
        [Test]
        public void PuedoRegistrarProductosSimples()
        {
            var ProductoSimple = new ProductoSimple(100,"Salchicha",1000,2000);
            var comprar = new Compra();
            var resultado = comprar.Registrar(ProductoSimple);
            Assert.Pass("Registrado Correctamente",resultado);
        }
        [Test]
        public void NoPuedoRegistrarProductoRepetido()
        {
            var ProductoSimple = new ProductoSimple(100, "Salchicha", 1000, 2000);
            var comprar = new Compra();
            comprar.Registrar(ProductoSimple);
            var ProductoSimple2 = new ProductoSimple(10, "Salchicha", 1000, 2000);
            var resultado = comprar.Registrar(ProductoSimple2);

            Assert.Pass("El Producto Salchicha ya se ha registrado anteriormente", resultado);
        }
    }
}