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
        private Escuchando escuchandoSebastian;
        private Escuchando escuchandoSebastian2;
        private Escuchando escuchandoThiago;
        private string lgante = "L-gante";
        private string denisElias = "DenisElias";
        private string horasVacias = "Horas Vacias";
        private string internationalLove = "International Love 420";
        private string sinAlbum = "Sin Album";
        private string otroAlbum = "Otro Album";
        private Usuario sebastianFernandez;
        private const string sebastian = "Sebastian";
        private const string fernandez = "Fernandez";
        private const string papelito = "Papelito";
        private DateTime fechaNacimientoSebastian = new DateTime(1985, 5, 23);
        private Usuario thiagoVecino;
        private const string thiago = "Thiago";
        private const string vecino = "Vecino";
        private const string thiagol = "Thiagol";
        private DateTime fechaNacimientoThiago = new DateTime(1999, 2, 25);

        [TestInitialize]
        public void Initialize()
        {
            sebastianFernandez = new Usuario()
            {
                Nombre = sebastian,
                Apellido = fernandez,
                NombreUsuario = papelito,
                FechaNacimiento = fechaNacimientoSebastian,
                DireccionPersona = new Direccion()
                {
                    Pais = "Uruguay",
                    Ciudad = "Montevideo",
                    Calle = "Cuareim",
                }
            };
            thiagoVecino = new Usuario()
            {
                Nombre = thiago,
                Apellido = vecino,
                NombreUsuario = thiagol,
                FechaNacimiento = fechaNacimientoThiago,
                DireccionPersona = new Direccion()
                {
                    Pais = "Uruguay",
                    Ciudad = "Montevideo",
                    Calle = "Cuareim",
                }
            };
            escuchandoSebastian = new Escuchando(sebastianFernandez, internationalLove, lgante, otroAlbum);
            escuchandoThiago = new Escuchando(thiagoVecino, horasVacias, denisElias, sinAlbum);
            escuchandoSebastian2 = new Escuchando(sebastianFernandez, horasVacias, denisElias, sinAlbum);
            escuchandoSebastian.FechaCreacion = fecha;
        }

        [TestMethod]
        public void CreadorDeEscuchando()
        {
            Assert.IsTrue(Equals(escuchandoSebastian.CreadoPor, sebastianFernandez));
        }

        [TestMethod]
        public void SetCreadorDeEscuchando()
        {
            escuchandoSebastian.CreadoPor = thiagoVecino;
            Assert.IsTrue(Equals(escuchandoSebastian.CreadoPor, thiagoVecino));
        }

        [TestMethod]
        public void CompararCreadorDeEscuchando()
        {
            Assert.IsTrue(Equals(escuchandoSebastian.CreadoPor, escuchandoSebastian2.CreadoPor));
        }

        [TestMethod]
        public void CompararDistintoCreadorDeEscuchando()
        {
            Assert.IsFalse(Equals(escuchandoSebastian.CreadoPor, escuchandoThiago.CreadoPor));
        }

        [TestMethod]
        public void CreadorIncorrectoDeEscuchando()
        {
            Assert.IsFalse(Equals(escuchandoSebastian.CreadoPor, thiagoVecino));
        }

        [TestMethod]
        public void GetHoraEscuchando()
        {
            Assert.IsTrue(escuchandoSebastian.FechaCreacion == fecha);
        }

        [TestMethod]
        public void GetArtistaEscuchando()
        {
            Assert.IsTrue(Equals(escuchandoSebastian.Artista, lgante));
        }

        [TestMethod]
        public void SetArtistaEscuchando()
        {
            escuchandoSebastian.Artista = denisElias;
            Assert.IsTrue(Equals(escuchandoSebastian.Artista, denisElias));
        }

        [TestMethod]
        public void GetArtistaIncorrectoEscuchando()
        {
            Assert.IsFalse(Equals(escuchandoSebastian.Artista, denisElias));
        }

        [TestMethod]
        public void GetCancionEscuchando()
        {
            Assert.IsTrue(escuchandoSebastian.Cancion == internationalLove);
        }

        [TestMethod]
        public void SetCancionEscuchando()
        {
            escuchandoSebastian.Cancion = horasVacias;
            Assert.IsTrue(escuchandoSebastian.Cancion == horasVacias);
        }

        [TestMethod]
        public void GetCancionIncorrectoEscuchando()
        {
            Assert.IsFalse(Equals(escuchandoSebastian.Artista, horasVacias));
        }

        [TestMethod]
        public void GetAlbumDeEscuchando()
        {
            Assert.IsTrue(escuchandoSebastian.Album == otroAlbum);
        }

        [TestMethod]
        public void SetAlbumDeEscuchando()
        {
            escuchandoSebastian.Album = sinAlbum;
            Assert.IsTrue(escuchandoSebastian.Album == sinAlbum);
        }

        [TestMethod]
        public void GetAlbumIncorrectoEscuchando()
        {
            Assert.IsFalse(Equals(escuchandoSebastian.Album, escuchandoSebastian2.Album));
        }

        [TestMethod]
        public void GetIncorrectoEscuchando()
        {
            Assert.IsFalse(Equals(escuchandoSebastian, escuchandoSebastian2));
        }

        [TestMethod]
        public void GetToString()
        {
            Assert.IsTrue(Equals(escuchandoSebastian.ToString(), sebastian + " esta escuchando " + escuchandoSebastian.Cancion + " de " + escuchandoSebastian.Artista + " del album " + escuchandoSebastian.Album));
        }
    }
}
