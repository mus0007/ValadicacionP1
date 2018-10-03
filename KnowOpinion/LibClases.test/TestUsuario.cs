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

            Usuario u = new Usuario(1,"mario","ubierna","cuenta","mario@alu.ubu.es");

            Assert.AreEqual(u.IdUsuario, 1);

            Assert.AreEqual(u.Nombre, "mario");

            Assert.AreEqual(u.Apellido, "ubierna");

            Assert.AreEqual(u.Cuenta, "cuenta");

            Assert.AreEqual(u.EMail, "mario@alu.ubu.es");

            //Prueba Get incorrecto

            Usuario x = new Usuario(3, "pepe", "suarez", "acc", "pepe@alu.ubu.es");

            Assert.AreNotEqual(x.IdUsuario, 1);

            Assert.AreNotEqual(x.Nombre, "mario");

            Assert.AreNotEqual(x.Apellido, "ubierna");

            Assert.AreNotEqual(x.Cuenta, "cuenta");

            Assert.AreNotEqual(x.EMail, "mario@alu.ubu.es");

            //Prueba Set Correcto

            Assert.AreEqual(u.IdUsuario = 2, 2);
            
            Assert.AreEqual(u.Nombre = "jorge", "jorge");

            Assert.AreEqual(u.Apellido = "navarro", "navarro");

            Assert.AreEqual(u.Cuenta = "cuenta", "cuenta");

            Assert.AreEqual(x.EMail = "jorge@alu.ubu.es", "jorge@alu.ubu.es");

            //Prueba Asignar Pass

            u.asignarPass("hola");

            Assert.AreEqual(u.comprobarPass("hola"), true);

        }

    }
}

