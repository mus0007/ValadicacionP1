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
            Assert.AreEqual(db.getUsuario(1).IdUsuario, 1);
            Assert.AreEqual(db.getUsuario(2).IdUsuario, 2);
            Assert.AreEqual(db.getUsuario(3).IdUsuario, 3);
            Assert.AreEqual(db.getUsuario(1).Cuenta, "Usuario1");
            Assert.AreEqual(db.getUsuario(2).Cuenta, "Usuario2");
            Assert.AreEqual(db.getUsuario(3).Cuenta, "Usuario3");
            Assert.AreEqual(db.getUsuario(1).Contrasena, "usuario1");
            Assert.AreEqual(db.getUsuario(2).Contrasena, "usuario2");
            Assert.AreEqual(db.getUsuario(3).Contrasena, "usuario3");

            //Prueba addEncuestas y getEncuestas
            Assert.AreEqual(db.addEncuesta("EncuestaPrueba", "Prueba"), true);
            Assert.AreEqual(db.getEncuesta(1).Nombre, "EncuestaPrueba");
            Assert.AreEqual(db.getEncuestas().Count, 1);
            
            //Prueba getActivas
            Assert.AreEqual(db.getActivas().Count, 0);
            
            //Prueba modificarEncuesta
            Assert.AreEqual(db.modificarEncuesta(1, "Prueba", "Prueba", true), true);
            Assert.AreEqual(db.getEncuesta(1).Nombre, "Prueba");
            Assert.AreEqual(db.getEncuesta(1).Descripcion, "Prueba");
            Assert.AreEqual(db.getActivas().Count, 1);
            
            //Prueba borrarEncuesta
            Assert.AreEqual(db.addEncuesta("2", "2"), true);
            Assert.AreEqual(db.getEncuesta(1).Nombre, "Prueba");
            Assert.AreEqual(db.getEncuesta(2).Nombre, "2");
            Assert.AreEqual(db.borrarEncuesta(1), true);
            Assert.AreEqual(db.getEncuestas().Count, 1);
            //Prueba a ver si se cambia el id
            Assert.AreEqual(db.getEncuesta(1).Nombre, "2");
            Assert.AreEqual(db.borrarEncuesta(1),true);
            Assert.AreEqual(db.getEncuestas().Count, 0);

            //Prueba sugerirEncuesta
            db.sugerirEncuesta("3", "3");
            Assert.AreEqual(db.getSugeridas().Count, 1);

            //Faltan hacer tests sobre posibles metodos de valoracion, pero no hemos puesto ningun metodo.

        }
    }
}
