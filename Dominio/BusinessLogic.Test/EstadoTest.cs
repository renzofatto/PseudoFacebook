using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;
using Dominio;

namespace Dominio.Test
{
    [TestClass]
    public class EstadoTest
    {
        private const int EstadoLargoMaximo = 260;
        private Estado EstadoFulano;
        private Estado EstadoMengano;
        private Usuario fulanoDeTal;
        private const string Fulano = "Fulano";
        private const string DeTal = "DeTal";
        private const string fulanito = "fulanito";
        private DateTime fechaNacimientoFulano = new DateTime(1998, 10, 7);
        private Usuario menganoDeTal;
        private const string Mengano = "Mengano";
        private const string menganito = "menganito";
        private DateTime fechaNacimientoMengano = new DateTime(1999, 3, 7);
        private string textoFulano = "Este es el texto del estado de FULANO";
        private string textoMengano = "Este es el texto del estado de MENGANO";
        private string textoNuevo = "Nuevo estado de mas de 10 caracteres";

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
            EstadoFulano = new Estado(fulanoDeTal, textoFulano);
            EstadoMengano = new Estado(menganoDeTal, textoMengano);
        }

        [TestMethod]
        public void CreadorDeEstado()
        {
            Assert.IsTrue(Equals(EstadoFulano.CreadoPor, fulanoDeTal));
        }

        [TestMethod]
        public void CreadorIncorrectoDeEstado()
        {
            Assert.IsFalse(Equals(EstadoFulano.CreadoPor, EstadoMengano.creadoPor));
        }

        [TestMethod]
        public void GetCreadorEstado()
        {
            EstadoFulano.CreadoPor = menganoDeTal;
            Assert.IsTrue(Equals(EstadoFulano.CreadoPor, menganoDeTal));
        }

        [TestMethod]
        public void GetFechaDeCreacion()
        {
            Assert.IsFalse(Equals(EstadoFulano.FechaCreacion, DateTime.Now.AddDays(2)));
        }

        [TestMethod]
        public void GetHoraDeCreacion()
        {
            Assert.IsTrue(Equals(EstadoFulano.FechaCreacion.Hour, DateTime.Now.Hour));
        }

        [TestMethod]
        public void SetHoraDeCreacion()
        {
            EstadoFulano.FechaCreacion = fechaNacimientoFulano;
            Assert.IsTrue(Equals(EstadoFulano.FechaCreacion, fechaNacimientoFulano));
        }

        [TestMethod]
        public void GetTextoEstado()
        {
            Assert.IsTrue(Equals(EstadoFulano.TextoDeEstado, textoFulano));
        }

        [TestMethod]
        public void SetTextoEstado()
        {
            EstadoFulano.TextoDeEstado = textoNuevo;
            Assert.IsTrue(Equals(EstadoFulano.TextoDeEstado, textoNuevo));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetTextoNull()
        {
            EstadoFulano.TextoDeEstado = null;
        }

        [TestMethod]
        public void TextoIncorrectoDeEstado()
        {
            Assert.IsFalse(Equals(EstadoFulano.TextoDeEstado, "Cualquier texto"));
        }

        [TestMethod]
        public void CompararEstados()
        {
            Assert.IsFalse(Equals(EstadoFulano, EstadoMengano));
        }
        
        [TestMethod]
        [ExpectedException(typeof(PublicacionException))]
        public void EstadoCorto()
        {
            EstadoFulano.TextoDeEstado = "M";   
        }

        [TestMethod]
        [ExpectedException(typeof(PublicacionException))]
        public void EstadoLargo()
        {
            EstadoFulano.TextoDeEstado = GenerarStringLargo(textoFulano, EstadoLargoMaximo);
        }

        private static string GenerarStringLargo(string texto, int largo)
        {
            string textoMuyLargo = "";
            while (textoMuyLargo.Length < largo)
                textoMuyLargo += texto;
            return textoMuyLargo;
        }
    }
}
