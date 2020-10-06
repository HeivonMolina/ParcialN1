using ComidasRapidas;
using NUnit.Framework;

namespace ComidasRapitas.Tests
{
    public class VentaDeProductoTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void PuedoVenderProductoSimpleTest()
        {
            var ProductoSimple = new ProductoSimple(111, 100, "Coca-Cola", 1000, 2000);
            var comprar = new Compra();
            comprar.Registrar(ProductoSimple);
            var venta = new Venta();
            var resultado = venta.VenderProductoSimple(111, 10);
            Assert.AreEqual("Se realizo la venta de Coca-Cola correctamente", resultado);
        }
        [Test]
        public void NoPuedoVenderUnProductoSimplesSiNoHayLosSuficientesTest()
        {
            var ProductoSimple = new ProductoSimple(111, 100, "Coca-Cola", 1000, 2000);
            var comprar = new Compra();
            comprar.Registrar(ProductoSimple);
            var venta = new Venta();
            var resultado = venta.VenderProductoSimple(111, 200);
            Assert.AreEqual("No hay la cantidad solicitada para la venta de este producto", resultado);
        }
        [Test]
        public void NoPuedoVenderUnProductosSimplesConCantidad0Test()
        {
            var ProductoSimple = new ProductoSimple(111, 100, "Coca-Cola", 1000, 2000);
            var comprar = new Compra();
            comprar.Registrar(ProductoSimple);
            var venta = new Venta();
            var resultado = venta.VenderProductoSimple(111, 0);
            Assert.AreEqual("La cantidad debe ser mayor a 0", resultado);
        }
        [Test]
        public void NoPuedoVenderUnProductoSimpleSiNoExisteTest()
        {
            var ProductoSimple = new ProductoSimple(111, 100, "Coca-Cola", 1000, 2000);
            var comprar = new Compra();
            comprar.Registrar(ProductoSimple);
            var venta = new Venta();
            var resultado = venta.VenderProductoSimple(101, 90);
            Assert.AreEqual("No existe producto", resultado);
        }
        public void PuedoVenderProductoCompuestoTest()
        {
            var ProductoSimple = new ProductoSimple(111, 100, "Salchicha", 1000, 2000);
            var ProductoSimple2 = new ProductoSimple(114, 100, "Papas ripio", 10000, 15000);
            var ProductoSimple3 = new ProductoSimple(111, 100, "Pan para perro", 1000, 2000);
            var ProductoSimple4 = new ProductoSimple(116, 100, "Queso", 2000, 3000);
            var comprar = new Compra();
            comprar.Registrar(ProductoSimple);
            comprar.Registrar(ProductoSimple2);
            comprar.Registrar(ProductoSimple3);
            comprar.Registrar(ProductoSimple4);
            var venta = new Venta();
            var resultado = venta.VenderProductoCompuesto(509, 4);
            Assert.AreEqual("No existe producto", resultado);
        }
    }
}