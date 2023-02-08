using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;
using System;

namespace Dominio.Test
{
    [TestClass]
    public class EncuestaTest
    {
        private const int encuestaLargo = 161;
        private Encuesta encuestaSebastian;
        private Encuesta encuestaThiago;
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
        private string preguntaSebastian = "Cuando van a echar al maestro?";
        private string preguntaThiago = "Cuando me va a llamar el maestro?";
        private Opcion opcion1Thiago;
        private Opcion opcion2Thiago;


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
            encuestaSebastian = new Encuesta(sebastianFernandez, preguntaSebastian);
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
            encuestaThiago = new Encuesta(thiagoVecino, preguntaThiago);
            opcion1Thiago = new Opcion("Mundial Qatar");
            opcion2Thiago = new Opcion("Nunca");
            encuestaThiago.AgregarOpcion(opcion1Thiago);
        }

        [TestMethod]
        public void CreadoPorSebastianFernandez()
        {
            Assert.AreEqual(encuestaSebastian.CreadoPor, sebastianFernandez);
        }

        [TestMethod]
        public void ConstructorEncuesta()
        {
            encuestaSebastian = new Encuesta(sebastianFernandez, preguntaSebastian);
            Assert.IsNotNull(encuestaSebastian);
        }

        [TestMethod]
        public void TextoDeEncuesta()
        {
            Assert.AreEqual(encuestaThiago.TextoDeEncuesta, preguntaThiago);
        }

        [TestMethod]
        public void FechaDeEncuesta()
        {
            Assert.AreEqual(encuestaThiago.FechaCreacion.Day, DateTime.Now.Day);
        }

        [TestMethod]
        public void AgregarUnaOpcion()
        {
            Opcion opcionSi = new Opcion("Si");
            encuestaSebastian.AgregarOpcion(opcionSi);
            Assert.AreEqual(encuestaSebastian.CuantasOpciones, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AgregarOpcionVacia()
        {
            encuestaSebastian.AgregarOpcion(null);
        }

        [TestMethod]
        [ExpectedException(typeof(EncuestaException))]
        public void AgregarSeisOpciones()
        {
            for (int i = 0; i <= 5; i++)
            {
                Opcion opcionAux = new Opcion("Si");
                encuestaSebastian.AgregarOpcion(opcionAux);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(EncuestaException))]
        public void EncuestaSinPregunta()
        {
            encuestaThiago = new Encuesta(thiagoVecino, "");
        }

        [TestMethod]
        [ExpectedException(typeof(EncuestaException))]
        public void EncuestaConTextoMuyLargo()
        {
            string textoMuyLargo = GenerarStringLargo("a", encuestaLargo);
            encuestaThiago = new Encuesta(thiagoVecino, textoMuyLargo);
        }

        [TestMethod]
        public void AgregarVotante()
        {
            encuestaThiago.AgregarVotante(sebastianFernandez, opcion1Thiago);
            Assert.IsTrue(opcion1Thiago.Votos == 1);
        }

        [TestMethod]
        public void Agregar2Opciones()
        {
            encuestaThiago.AgregarOpcion(opcion2Thiago);
            Assert.IsTrue(encuestaThiago.CuantasOpciones == 2);
        }

        [TestMethod]
        public void VotosTotales()
        {
            encuestaThiago.AgregarVotante(thiagoVecino, opcion1Thiago);
            encuestaThiago.AgregarOpcion(opcion2Thiago);
            encuestaThiago.AgregarVotante(sebastianFernandez, opcion2Thiago);
            Assert.IsTrue(encuestaThiago.VotosTotales == 2);
        }

        [TestMethod]
        public void OpcionesEnArray()
        {
            encuestaThiago.AgregarVotante(thiagoVecino, opcion1Thiago);
            encuestaThiago.AgregarOpcion(opcion2Thiago);
            encuestaThiago.AgregarVotante(sebastianFernandez, opcion2Thiago);
            string[] opciones = encuestaThiago.OpcionesArray();
            Assert.IsTrue(opciones[1].Equals(opcion2Thiago.TextoOpcion));
        }
            
        [TestMethod]
        public void VotosEnArray()
        {
            encuestaThiago.AgregarVotante(thiagoVecino, opcion1Thiago);
            encuestaThiago.AgregarOpcion(opcion2Thiago);
            encuestaThiago.AgregarVotante(sebastianFernandez, opcion2Thiago);
            int[] votos = encuestaThiago.VotosArray();
            Assert.IsTrue(votos[0] == 1);
        }

        private static string GenerarStringLargo(string texto, int largo)
        {
            string pathMuyLargo = "";
            while (pathMuyLargo.Length < largo)
                pathMuyLargo += texto;
            return pathMuyLargo;
        }
    }
}
