using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;
using Dominio;

namespace Dominio.Test
{
    [TestClass]
    public class EscuchandoTest
    {
        private DateTime fecha = new DateTime(1999, 10, 11);
        private Escuchando escuchandoFulano;
        private Escuchando escuchandoFulano2;
        private Escuchando escuchandoMengano;
        private string lgante = "L-gante";
        private string denisElias = "DenisElias";
        private string horasVacias = "Horas Vacias";
        private string internationalLove = "International Love 420";
        private string sinAlbum = "Sin Album";
        private string otroAlbum = "Otro Album";
        private Usuario fulanoDeTal;
        private const string Fulano = "Fulano";
        private const string DeTal = "DeTal";
        private const string fulanito = "fulanito";
        private DateTime fechaNacimientoFulano = new DateTime(1998, 10, 7);
        private Usuario menganoDeTal;
        private const string Mengano = "Mengano";
        private const string menganito = "menganito";
        private DateTime fechaNacimientoMengano = new DateTime(1999, 3, 7);

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
            menganoDeTal = new Usuario()
            {
                Nombre = Mengano,
                Apellido = DeTal,
                NombreUsuario = menganito,
                FechaNacimiento = fechaNacimientoMengano,
                DireccionPersona = new Direccion()
                {
                    Pais = "Uruguay",
                    Ciudad = "Montevideo",
                    Calle = "Cuareim",
                }
            };
            escuchandoFulano = new Escuchando(fulanoDeTal, internationalLove, lgante, otroAlbum);
            escuchandoMengano = new Escuchando(menganoDeTal, horasVacias, denisElias, sinAlbum);
            escuchandoFulano2 = new Escuchando(fulanoDeTal, horasVacias, denisElias, sinAlbum);
            escuchandoFulano.FechaCreacion = fecha;
        }

        [TestMethod]
        public void CreadorDeEscuchando()
        {
            Assert.IsTrue(Equals(escuchandoFulano.CreadoPor, fulanoDeTal));
        }

        [TestMethod]
        public void SetCreadorDeEscuchando()
        {
            escuchandoFulano.CreadoPor = menganoDeTal;
            Assert.IsTrue(Equals(escuchandoFulano.CreadoPor, menganoDeTal));
        }

        [TestMethod]
        public void CompararCreadorDeEscuchando()
        {
            Assert.IsTrue(Equals(escuchandoFulano.CreadoPor, escuchandoFulano2.CreadoPor));
        }

        [TestMethod]
        public void CompararDistintoCreadorDeEscuchando()
        {
            Assert.IsFalse(Equals(escuchandoFulano.CreadoPor, escuchandoMengano.CreadoPor));
        }

        [TestMethod]
        public void CreadorIncorrectoDeEscuchando()
        {
            Assert.IsFalse(Equals(escuchandoFulano.CreadoPor, menganoDeTal));
        }

        [TestMethod]
        public void GetHoraEscuchando()
        {
            Assert.IsTrue(escuchandoFulano.FechaCreacion == fecha);
        }

        [TestMethod]
        public void GetArtistaEscuchando()
        {
            Assert.IsTrue(Equals(escuchandoFulano.Artista, lgante));
        }

        [TestMethod]
        public void SetArtistaEscuchando()
        {
            escuchandoFulano.Artista = denisElias;
            Assert.IsTrue(Equals(escuchandoFulano.Artista, denisElias));
        }

        [TestMethod]
        public void GetArtistaIncorrectoEscuchando()
        {
            Assert.IsFalse(Equals(escuchandoFulano.Artista, denisElias));
        }

        [TestMethod]
        public void GetCancionEscuchando()
        {
            Assert.IsTrue(escuchandoFulano.Cancion == internationalLove);
        }

        [TestMethod]
        public void SetCancionEscuchando()
        {
            escuchandoFulano.Cancion = horasVacias;
            Assert.IsTrue(escuchandoFulano.Cancion == horasVacias);
        }

        [TestMethod]
        public void GetCancionIncorrectoEscuchando()
        {
            Assert.IsFalse(Equals(escuchandoFulano.Artista, horasVacias));
        }

        [TestMethod]
        public void GetAlbumDeEscuchando()
        {
            Assert.IsTrue(escuchandoFulano.Album == otroAlbum);
        }

        [TestMethod]
        public void SetAlbumDeEscuchando()
        {
            escuchandoFulano.Album = sinAlbum;
            Assert.IsTrue(escuchandoFulano.Album == sinAlbum);
        }

        [TestMethod]
        public void GetAlbumIncorrectoEscuchando()
        {
            Assert.IsFalse(Equals(escuchandoFulano.Album, escuchandoFulano2.Album));
        }

        [TestMethod]
        public void GetIncorrectoEscuchando()
        {
            Assert.IsFalse(Equals(escuchandoFulano, escuchandoFulano2));
        }

        [TestMethod]
        public void GetToString()
        {
            Assert.IsTrue(Equals(escuchandoFulano.ToString(), Fulano + " esta escuchando " + escuchandoFulano.Cancion + " de " + escuchandoFulano.Artista + " del album " + escuchandoFulano.Album));
        }


    }
}
