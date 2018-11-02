using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibClases;

namespace LibClases.test
{
    [TestClass]
    public class TestUsuario
    {
        [TestMethod]
        public void TestConstructorSetyGet()
        {
            //Prueba Get Correcto

            Usuario u = new Usuario(1, "cuenta","pass");

            Assert.AreEqual(u.IdUsuario, 1);

            Assert.AreEqual(u.Cuenta, "cuenta");

            Assert.AreEqual(u.comprobarPass("pass"), true);

            //Prueba Get incorrecto

            Usuario x = new Usuario(3, "acc", "hola");

            Assert.AreNotEqual(x.IdUsuario, 1);

            Assert.AreNotEqual(x.Cuenta, "cuenta");

            Assert.AreNotEqual(x.comprobarPass("adios"), true);

            //Prueba Set Correcto

            Assert.AreEqual(u.IdUsuario = 2, 2);

            Assert.AreEqual(u.Cuenta = "cuenta", "cuenta");
        }

    }
}

