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
            Usuario u = new Usuario(1,"mario","ubierna","cuenta","mario@alu.ubu.es");

            Assert.AreEqual(u.IdUsuario, 1);

            Assert.AreEqual(u.Nombre, "mario");

            Assert.AreEqual(u.Apellido, "ubierna");

            Assert.AreEqual(u.Cuenta, "cuenta");

            Assert.AreEqual(u.EMail, "mario@alu.ubu.es");
        }

    }
}

