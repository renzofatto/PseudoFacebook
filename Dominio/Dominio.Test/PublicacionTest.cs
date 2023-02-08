using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;
using System;

namespace Dominio.Test
{
    [TestClass]
    public class PublicacionTest
    {
        private Publicacion publicacion1;
        private Usuario sebastianFernandez;

        [TestInitialize]
        public void Initialize()
        {
            sebastianFernandez = new Usuario()
            {
                Nombre = "Sebastian",
                Apellido = "Fernandez",
                NombreUsuario = "Papelito",
                FechaNacimiento = new DateTime(1997, 5, 4),
                DireccionPersona = new Direccion()
                {
                    Pais = "Uruguay",
                    Ciudad = "Montevideo",
                    Calle = "Cuareim",
                }
            };
            publicacion1 = new Publicacion(sebastianFernandez);
        }

        [TestMethod]
        public void CrearPublicacion()
        {
            Assert.AreEqual(publicacion1.CreadoPor.Nombre, sebastianFernandez.Nombre);
        }

        [TestMethod]
        public void FechaCreacion()
        {
            Assert.IsTrue(publicacion1.FechaCreacion.Day == DateTime.Now.Day);
        }

        [TestMethod]
        public void Id()
        {
            publicacion1.Id = 1;
            Assert.IsTrue(publicacion1.Id == 1);
        }
    }
}
