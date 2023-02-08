using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;
using System;

namespace Dominio.Test
{
    [TestClass]
    public class AlbumTest
    {
        private Album albumDePapelito;
        private string vacaciones = "Vacaciones";
        private Usuario sebastianFernandez;
        private const string sebastian = "Sebastian";
        private const string fernandez = "Fernandez";
        private const string papelito = "Papelito";
        private DateTime fechaNacimientoFulano = new DateTime(1985, 5, 23);

        [TestInitialize]
        public void Initialize()
        {
            sebastianFernandez = new Usuario()
            {
                Nombre = sebastian,
                Apellido = fernandez,
                NombreUsuario = papelito,
                FechaNacimiento = fechaNacimientoFulano,
                DireccionPersona = new Direccion()
                {
                    Pais = "Uruguay",
                    Ciudad = "Montevideo",
                    Calle = "Cuareim",
                }
            };
            albumDePapelito = new Album(sebastianFernandez);
            albumDePapelito.NombreAlbum = vacaciones;
        }

        [TestMethod]
        public void ConstructorDeAlbum()
        {
            Assert.IsTrue(Equals(albumDePapelito.CreadoPor, sebastianFernandez));
        }

        [TestMethod]
        public void GetCantidadElementosInicial()
        {
            Assert.IsTrue(albumDePapelito.TodasLasFotos().Count == 0);
        }

        [TestMethod]
        public void SetCreadoPor()
        {
            albumDePapelito.CreadoPor = sebastianFernandez;
            Assert.IsTrue(Equals(albumDePapelito.CreadoPor, sebastianFernandez));
        }

        [TestMethod]
        public void AgregarUnaImagen()
        {
            albumDePapelito.Agregar(@"Resources\test-image.jpg");
            Assert.IsTrue(albumDePapelito.TodasLasFotos().Count == 1);
        }

        [TestMethod]
        public void BorrarUnaImagen()
        {
            albumDePapelito.Borrar(@"Resources\test-image.jpg");
            Assert.IsTrue(albumDePapelito.TodasLasFotos().Count == 0);
        }

        [TestMethod]
        public void GetNombreDelAlbum()
        {
            Assert.IsTrue(Equals(albumDePapelito.NombreAlbum, vacaciones));
        }

        [TestMethod]
        public void SetNombreDelAlbum()
        {
            albumDePapelito.NombreAlbum= "Finlandia";
            Assert.IsTrue(Equals(albumDePapelito.NombreAlbum, "Finlandia"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NombreVacio()
        {
            albumDePapelito.NombreAlbum = "";
        }

        [TestMethod]
        public void SetFechaDelAlbum()
        {
            albumDePapelito.FechaCreacion = fechaNacimientoFulano;
            Assert.IsTrue(Equals(albumDePapelito.FechaCreacion, fechaNacimientoFulano));
        }

        [TestMethod]
        [ExpectedException(typeof(PublicacionException))]
        public void Agregar11Imagenes()
        {
            for (int i = 0; i < 11; i++)
            {
                albumDePapelito.Agregar(@"Resources\test-image"+i+".jpg");
            }
        }

        [TestMethod]
        public void GetToString()
        {
            Assert.AreEqual(albumDePapelito.ToString(), albumDePapelito.NombreAlbum + " fue creado el " + albumDePapelito.FechaCreacion);
        }
    }
}
