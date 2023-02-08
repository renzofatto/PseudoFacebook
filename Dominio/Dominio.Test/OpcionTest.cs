using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;
using System;

namespace Dominio.Test
{
    [TestClass]
    public class OpcionTest
    {
        private const int opcionLargoMaximo = 160;
        private Opcion opcion1;
        private Encuesta encuestaSebastian;
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
        private string textoOpcion1 = "Hoy";
        private string preguntaSebastian = "Cuando van a echar al maestro?";

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
                FechaNacimiento = fechaNacimientoThiago,
                NombreUsuario = thiagol,
                DireccionPersona = new Direccion()
                {
                    Pais = "Argentina",
                    Ciudad = "Buenos Aires",
                    Calle = "Corriente",
                }
            };
            encuestaSebastian = new Encuesta(sebastianFernandez, preguntaSebastian);
            opcion1 = new Opcion(textoOpcion1);
            encuestaSebastian.AgregarOpcion(opcion1);
        }

        [TestMethod]
        public void DefinirTextoOpcion()
        {
            opcion1.TextoOpcion = "Una pregunta...?";
        }

        [TestMethod]
        public void CreadorDeOpciones()
        {
            Opcion opcionNueva = new Opcion("Opcion Nueva para encuesta");
            Assert.IsNotNull(opcionNueva);
        }

        [TestMethod]
        [ExpectedException(typeof(OpcionException))]
        public void OpcionSinTexto()
        {
            Opcion opcionCorta = new Opcion("");
        }

        [TestMethod]
        [ExpectedException(typeof(OpcionException))]
        public void OpcionLarga()
        {
            string textoMuyLargo = GenerarStringLargo("a", opcionLargoMaximo);
            Opcion opcionLarga = new Opcion(textoMuyLargo);
        }

        [TestMethod]
        public void AgregarVotante()
        {
            opcion1.AgregarVotante();
            Assert.IsTrue(opcion1.Votos == 1);
        }

        private static string GenerarStringLargo(string texto, int largo)
        {
            string pathMuyLargo = "";
            while (pathMuyLargo.Length < largo+1)
                pathMuyLargo += texto;
            return pathMuyLargo;
        }
    }
}
