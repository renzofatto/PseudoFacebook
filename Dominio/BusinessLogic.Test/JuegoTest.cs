using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;
using System;

namespace Dominio.Test
{
    [TestClass]
    public class JuegoTest
    {
        [TestMethod]
        public void CrearJuego()
        {
            Juego nuevoJuego = new Juego();
            Assert.IsNotNull(nuevoJuego);
        }

        [TestMethod]
        public void SetTitulo()
        {
            Juego nuevoJuego = new Juego()
            {
                Titulo = "Juego Generico"
            };
            Assert.IsNotNull(nuevoJuego.Titulo);
        }

        [TestMethod]
        [ExpectedException(typeof(JuegoException))]
        public void TituloMuyLargo()
        {
            Juego nuevoJuego = new Juego()
            {
                Titulo = "TituloDeJuegoExtremadamenteLargoInclusoMasQueLoQueDeberiaPoderse"
            };
        }
        [TestMethod]
        [ExpectedException(typeof(JuegoException))]
        public void TituloMuyCorto()
        {
            Juego nuevoJuego = new Juego()
            {
                Titulo = "T"
            };
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TituloNulo()
        {
            Juego nuevoJuego = new Juego()
            {
                Titulo = null
            };
        }

    }
}
