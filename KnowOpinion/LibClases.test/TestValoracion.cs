using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibClases;

namespace LibClases.test
{
    [TestClass]
    public class TestValoracion
    {
        [TestMethod]
        public void TestConstructorSetyGet()
        {
            // Prueba Valor correcto
            Valoracion valoracion = new Valoracion(4, "muy buena");
            Assert.AreEqual(valoracion.Valor, 4);
            Assert.AreEqual(valoracion.Opinion, "muy buena");

            // Prueba Valor mayor que 4
            Valoracion valoracion1 = new Valoracion(10, "la mejor");
            Assert.AreEqual(valoracion1.Valor, 0);
            Assert.AreEqual(valoracion1.Opinion, "la mejor");

            // Prueba Valor menor que 1
            Valoracion valoracion2 = new Valoracion(-1, "la peor");
            Assert.AreEqual(valoracion2.Valor, 0);
            Assert.AreEqual(valoracion2.Opinion, "la peor");

            // Prueba metodo set valor
            valoracion2.Valor = 4;
            Assert.AreEqual(valoracion2.Valor, 4);

            // Prueba metodo set opinion
            valoracion2.Opinion = "la mejor";
            Assert.AreEqual(valoracion2.Opinion, "la mejor");



        }

    }
}

