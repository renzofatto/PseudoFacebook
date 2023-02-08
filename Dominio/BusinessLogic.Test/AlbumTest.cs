using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;
using System;

namespace Dominio.Test
{
    [TestClass]
    public class AlbumTest
    {
        private Album albumDeFulano;
        private string vacaciones = "Vacaciones";
        private Usuario fulanoDeTal;
        private const string Fulano = "Fulano";
        private const string DeTal = "DeTal";
        private const string fulanito = "fulanito";
        private DateTime fechaNacimientoFulano = new DateTime(1998, 10, 7);

        [TestInitialize]
        public void Initialize()
        {
            fulanoDeTal = new Usuario()
            {
                Nombre = Fulano,
                Apellido = DeTal,
                NombreUsuario = fulanito,
                FechaNacimiento = fechaNacimientoFulano,
                DireccionPersona = new Direccion()
                {
                    Pais = "Uruguay",
                    Ciudad = "Montevideo",
                    Calle = "Cuareim",
                }
            };
            albumDeFulano = new Album(fulanoDeTal, vacaciones);
        }

        [TestMethod]
        public void ConstructorDeAlbum()
        {
            Assert.IsTrue(Equals(albumDeFulano.CreadoPor, fulanoDeTal));
        }

        [TestMethod]
        public void GetCantidadElementosInicial()
        {
            Assert.IsTrue(albumDeFulano.TodasLasFotos().Count == 0);
        }

        [TestMethod]
        public void SetCreadoPor()
        {
            albumDeFulano.CreadoPor = fulanoDeTal;
            Assert.IsTrue(Equals(albumDeFulano.CreadoPor, fulanoDeTal));
        }

        [TestMethod]
        public void AgregarUnaImagen()
        {
            albumDeFulano.Agregar(@"Resources\test-image.jpg");
            Assert.IsTrue(albumDeFulano.TodasLasFotos().Count == 1);
        }

        [TestMethod]
        public void BorrarUnaImagen()
        {
            albumDeFulano.Borrar(@"Resources\test-image.jpg");
            Assert.IsTrue(albumDeFulano.TodasLasFotos().Count == 0);
        }

        [TestMethod]
        public void GetNombreDelAlbum()
        {
            Assert.IsTrue(Equals(albumDeFulano.NombreAlbum, vacaciones));
        }

        [TestMethod]
        public void SetNombreDelAlbum()
        {
            albumDeFulano.NombreAlbum= "Finlandia";
            Assert.IsTrue(Equals(albumDeFulano.NombreAlbum, "Finlandia"));
        }

        [TestMethod]
        public void SetFechaDelAlbum()
        {
            albumDeFulano.FechaCreacion = fechaNacimientoFulano;
            Assert.IsTrue(Equals(albumDeFulano.FechaCreacion, fechaNacimientoFulano));
        }

        [TestMethod]
        [ExpectedException(typeof(PublicacionException))]
        public void Agregar11Imagenes()
        {
            for (int i = 0; i < 11; i++)
            {
                albumDeFulano.Agregar(@"Resources\test-image"+i+".jpg");
            }
        }
    }
}
