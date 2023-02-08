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
        private Estado EstadoSebastian;
        private Estado EstadoThiago;
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
        private string textoSebastian = "Este es el texto del estado de Sebastian";
        private string textoThiago = "Este es el texto del estado de Thiago";
        private string textoNuevo = "Nuevo estado de mas de 10 caracteres";

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
            EstadoSebastian = new Estado(sebastianFernandez, textoSebastian);
            EstadoThiago = new Estado(thiagoVecino, textoThiago);
        }

        [TestMethod]
        public void CreadorDeEstado()
        {
            Assert.IsTrue(Equals(EstadoSebastian.CreadoPor, sebastianFernandez));
        }

        [TestMethod]
        public void CreadorIncorrectoDeEstado()
        {
            Assert.IsFalse(Equals(EstadoSebastian.CreadoPor, EstadoThiago.creadoPor));
        }

        [TestMethod]
        public void ConstructorDeEstadoSinTexto()
        {

            Assert.IsFalse(Equals(EstadoSebastian.CreadoPor, EstadoThiago.creadoPor));
        }

        [TestMethod]
        public void GetCreadorEstado()
        {
            EstadoSebastian.CreadoPor = thiagoVecino;
            Assert.IsTrue(Equals(EstadoSebastian.CreadoPor, thiagoVecino));
        }

        [TestMethod]
        public void GetFechaDeCreacion()
        {
            Assert.IsFalse(Equals(EstadoSebastian.FechaCreacion, DateTime.Now.AddDays(2)));
        }

        [TestMethod]
        public void GetHoraDeCreacion()
        {
            Assert.IsTrue(Equals(EstadoSebastian.FechaCreacion.Hour, DateTime.Now.Hour));
        }

        [TestMethod]
        public void SetHoraDeCreacion()
        {
            EstadoSebastian.FechaCreacion = fechaNacimientoSebastian;
            Assert.IsTrue(Equals(EstadoSebastian.FechaCreacion, fechaNacimientoSebastian));
        }

        [TestMethod]
        public void GetTextoEstado()
        {
            Assert.IsTrue(Equals(EstadoSebastian.TextoDeEstado, textoSebastian));
        }

        [TestMethod]
        public void SetTextoEstado()
        {
            EstadoSebastian.TextoDeEstado = textoNuevo;
            Assert.IsTrue(Equals(EstadoSebastian.TextoDeEstado, textoNuevo));
        }

        [TestMethod]
        [ExpectedException(typeof(PublicacionException))]
        public void SetTextoVacio()
        {
            EstadoSebastian.TextoDeEstado = "";
        }

        [TestMethod]
        public void TextoIncorrectoDeEstado()
        {
            Assert.IsFalse(Equals(EstadoSebastian.TextoDeEstado, "Cualquier texto"));
        }

        [TestMethod]
        public void CompararEstados()
        {
            Assert.IsFalse(Equals(EstadoSebastian, EstadoThiago));
        }
        
        [TestMethod]
        [ExpectedException(typeof(PublicacionException))]
        public void EstadoCorto()
        {
            EstadoSebastian.TextoDeEstado = "M";   
        }

        [TestMethod]
        [ExpectedException(typeof(PublicacionException))]
        public void EstadoLargo()
        {
            EstadoSebastian.TextoDeEstado = GenerarStringLargo(textoSebastian, EstadoLargoMaximo);
        }

        [TestMethod]
        public void GetToString()
        {
            Assert.AreEqual(EstadoSebastian.ToString(), EstadoSebastian.TextoDeEstado + " fue posteado el " + EstadoSebastian.FechaCreacion);
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
