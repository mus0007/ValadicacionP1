using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibClases;

namespace LibClases.test
{
    [TestClass]
    public class TestEncuesta
    {
        [TestMethod]
        public void TestConstructorSetyGet()
        {
            //Prueba Get Correcto

            Encuesta e1 = new Encuesta(1, "Encuesta1", "Encuesta1", true);

            Assert.AreEqual(e1.Id, 1);

            Assert.AreEqual(e1.Nombre, "Encuesta1");

            Assert.AreEqual(e1.Descripcion, "Encuesta1");

            Assert.AreEqual(e1.Activa, true);

            //Prueba Get incorrecto

            Encuesta e2 = new Encuesta(2, "Encuesta2", "Encuesta2", false);

            Assert.AreNotEqual(e2.Id, 1);

            Assert.AreNotEqual(e2.Nombre, "Encuesta1");

            Assert.AreNotEqual(e2.Descripcion, "Encuesta1");

            Assert.AreNotEqual(e2.Activa, true);

            //Prueba Set Correcto

            Assert.AreEqual(e1.Id = 3, 3);

            Assert.AreEqual(e1.Nombre = "Encuesta3", "Encuesta3");

            Assert.AreEqual(e1.Descripcion = "Encuesta3", "Encuesta3");

            Assert.AreEqual(e1.Activa = false, false);

            //Prueba valor por defecto

            Encuesta eP = new Encuesta(4, "Encuesta4", "Encuesta4");

            Assert.AreEqual(eP.Activa, false);

            //Prueba getOpiniones y setOpiniones
            Assert.AreEqual(e1.getOpiniones().Count, 0);

            e1.setOpinion(4, "Muy bien");

            Assert.AreEqual(e1.getOpiniones().Count, 1);

            e1.setOpinion(3);

            Assert.AreEqual(e1.getOpiniones().Count, 2);

        }

    }
}

