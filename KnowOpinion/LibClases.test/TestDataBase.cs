using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibClases;

namespace LibClases.test
{
    /// <summary>
    /// Descripción resumida de TestDataBase
    /// </summary>
    [TestClass]
    public class TestDataBase
    {

        [TestMethod]
        public void TestMethod1()
        {

            DataBase db = new DataBase();
            //Prueba getUsuarios
            Assert.AreEqual(db.getUsuarios().Count, 3);

            //Prueba getUsuario
            Assert.AreEqual(db.getUsuario("Usuario1@gmail.com").IdUsuario, 1);
            Assert.AreEqual(db.getUsuario("Usuario1@gmail.com").Cuenta, "Usuario1@gmail.com");
            Assert.AreEqual(db.getUsuario("Usuario1@gmail.com").comprobarPass("usuario1"),true);
            Assert.AreEqual(db.getUsuario("Usuario2@gmail.com").IdUsuario, 2);
            Assert.AreEqual(db.getUsuario("Usuario2@gmail.com").Cuenta, "Usuario2@gmail.com");
            Assert.AreEqual(db.getUsuario("Usuario2@gmail.com").comprobarPass("usuario2"), true);
            Assert.AreEqual(db.getUsuario("Usuario3@gmail.com").IdUsuario, 3);
            Assert.AreEqual(db.getUsuario("Usuario3@gmail.com").Cuenta, "Usuario3@gmail.com");
            Assert.AreEqual(db.getUsuario("Usuario3@gmail.com").comprobarPass("usuario3"), true);

            //Prueba addEncuestas y getEncuestas
            Assert.AreEqual(db.getEncuestas().Count, 2);
            Assert.AreEqual(db.addEncuesta("EncuestaPrueba", "Prueba"), true);
            Assert.AreEqual(db.getEncuesta("EncuestaPrueba").Nombre, "EncuestaPrueba");
            Assert.AreEqual(db.getEncuestas().Count, 3);

            //Prueba getActivas y getNoActivas
            Assert.AreEqual(db.getActivas().Count, 2);
            Assert.AreEqual(db.getNoActivas().Count, 1);

            //Prueba modificarEncuesta
            Assert.AreEqual(db.modificarEncuesta("EncuestaPrueba", "prueba"), true);
            Assert.AreEqual(db.getEncuesta("EncuestaPrueba").Nombre, "EncuestaPrueba");
            Assert.AreEqual(db.getEncuesta("EncuestaPrueba").Descripcion, "prueba");
            Assert.AreEqual(db.getActivas().Count, 2);

            //Prueba borrarEncuesta
            Assert.AreEqual(db.addEncuesta("Prueba2", "prueba2"), true);
            Assert.AreEqual(db.getEncuesta("Prueba2").Nombre, "Prueba2");
            Assert.AreEqual(db.borrarEncuesta("Prueba2"), true);
            Assert.AreEqual(db.getEncuestas().Count, 3);
            Assert.AreEqual(db.getEncuesta("Encuesta1").Nombre, "Encuesta1");
            Assert.AreEqual(db.borrarEncuesta("Encuesta1"),true);
            Assert.AreEqual(db.getEncuestas().Count, 2);

            //Prueba sugerirEncuesta
            db.sugerirEncuesta("Nombre3", "Descripcion3");
            Assert.AreEqual(db.getSugeridas().Count, 1);
        }
    }
}
