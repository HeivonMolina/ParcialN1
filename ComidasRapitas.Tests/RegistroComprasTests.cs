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
        public void PuedoRegistrarProductosSimplesTest()
        {
            var ProductoSimple = new ProductoSimple(111,100,"Salchicha",1000,2000);
            var comprar = new Compra();
            var resultado = comprar.Registrar(ProductoSimple);
            Assert.AreEqual("Registrado Correctamente",resultado);
        }
        [Test]
        public void NoPuedoRegistrarProductoRepetidoTest()
        {
            var ProductoSimple = new ProductoSimple(111, 100, "Salchicha", 1000, 2000);
            var comprar = new Compra();
            comprar.Registrar(ProductoSimple);
            var ProductoSimple2 = new ProductoSimple(111, 10, "Salchicha", 1000, 2000);
            var resultado = comprar.Registrar(ProductoSimple2);
            Assert.AreEqual("El Producto Salchicha ya se ha registrado anteriormente", resultado);
        }
        [Test]
        public void PuedoRegistarEntradasDeProductoTest()
        {
            var ProductoSimple = new ProductoSimple(111, 100, "Salchicha", 1000, 2000);
            var comprar = new Compra();
            comprar.Registrar(ProductoSimple);
            
            var resultado = comprar.RegistrarEntrada(111,20);
            Assert.AreEqual("Se ha registrado una entrada para el Producto Salchicha correctamente", resultado);
        }
        [Test]
        public void NoPuedoRegistrarEntradaConCantidad0Test()
        {
            var ProductoSimple = new ProductoSimple(111, 100, "Salchicha", 1000, 2000);
            var comprar = new Compra();
            comprar.Registrar(ProductoSimple);

            var resultado = comprar.RegistrarEntrada(111, 0);
            Assert.AreEqual("La cantidad debe ser mayor a 0", resultado);
        }
        [Test]
        public void NoPuedoRegistrarEntradaDeProductosNoExistenteTest()
        {
            var ProductoSimple = new ProductoSimple(111, 100, "Salchicha", 1000, 2000);
            var comprar = new Compra();
            comprar.Registrar(ProductoSimple);

            var resultado = comprar.RegistrarEntrada(112, 10);
            Assert.AreEqual("No existe el producto", resultado);
        }

    }
}