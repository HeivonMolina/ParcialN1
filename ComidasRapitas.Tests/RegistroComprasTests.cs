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
    }
}