using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;
using System;
using System.Collections.Generic;

namespace Dominio.Test
{
    [TestClass]
    public class JuegoTest
    {
        private Datos misDatos = new Datos();
        private List<Usuario> usuariosRegistrados = new List<Usuario>();
        private Usuario nicolasVarela;

        [TestInitialize]
        public void Initialize()
        {
            nicolasVarela = new Usuario
            {
                Nombre = "Nicolas",
                Apellido = "Varela",
                NombreUsuario = "nicogamer",
                FechaNacimiento = new DateTime(1987,2,3),
                PicturePath = @"Resources\test-image.jpg",
                DireccionPersona = new Direccion()
                {
                    Pais = "Uruguay",
                    Ciudad = "Montevideo",
                    Calle = "Cuareim",
                },
                Contrasena = "AmoElRugby"
            };
            usuariosRegistrados.Add(nicolasVarela);
            misDatos.UsuariosRegistrados = usuariosRegistrados;
            Juego.AgregarJuego("Jueguito", "Accion", @"Resources\test - image.jpg", misDatos);
            Juego.AgregarJuego("Fifa 2021", "Deportes", @"Resources\test - image2.jpg", misDatos);
            Juego.getJuegoFromTitulo("Jueguito", misDatos).Jugar(10, nicolasVarela);
        }

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
        [ExpectedException(typeof(JuegoException))]
        public void TituloVacio()
        {
            Juego nuevoJuego = new Juego()
            {
                Titulo = ""
            };
        }

        [TestMethod]
        public void JugarJuego()
        {
            Usuario player = new Usuario()
            {
                Nombre = "Pancho",
                NombreUsuario = "Panchitox"
            };
            Juego nuevoJuego = new Juego();
            nuevoJuego.Jugar(300, player);
            Assert.IsNotNull(nuevoJuego.TodasLasJugadas());
        }

        [TestMethod]
        public void AgregarCaratulaJuego()
        {
            Juego juegoSinFoto = new Juego();
            juegoSinFoto.Caratula = "http://www.google.com/";
            Assert.AreEqual(juegoSinFoto.Caratula, "http://www.google.com/");
        }

        [TestMethod]
        public void EsValidoUnTituloNuevo()
        {
            List<Juego> juegos = new List<Juego>();
            Juego fifa = new Juego();
            fifa.Titulo= "Fifa 2021";
            Juego ufc = new Juego();
            ufc.Titulo= "UFC 4";
            juegos.Add(fifa);
            juegos.Add(ufc);
            Assert.IsTrue(Juego.TituloDeJuegoValido("SpiderMan",juegos));
        }

        [TestMethod]
        public void ValidarTituloDelPrimerJuego()
        {
            List<Juego> juegos = new List<Juego>();
            Assert.IsTrue(Juego.TituloDeJuegoValido("SpiderMan", juegos));
        }

        [TestMethod]
        [ExpectedException(typeof(JuegoException))]
        public void NoEsValidoUnTituloRepetido()
        {
            List<Juego> juegos = new List<Juego>();
            Juego fifa = new Juego();
            fifa.Titulo = "Fifa 2021";
            Juego ufc = new Juego();
            ufc.Titulo = "UFC 4";
            juegos.Add(fifa);
            juegos.Add(ufc);
            Juego.TituloDeJuegoValido("Fifa 2021", juegos);
        }

        [TestMethod]
        public void AgregarJuego()
        {
            Juego.AgregarJuego("Fifa 43", "Deporte", @"Resources\test - image.jpg", misDatos);
        }

        [TestMethod]
        public void NoExisteJuego()
        {
            Assert.IsFalse(Juego.NoExisteJuego("Jueguito", misDatos));
        }

        [TestMethod]
        public void ComprobarQueSiExiste()
        {
            Assert.IsTrue(Juego.NoExisteJuego("Fifa 43", misDatos));
        }

        [TestMethod]
        public void GetTop10()
        {
            Assert.AreNotEqual(Juego.TopDiez(Juego.getJuegoFromTitulo("Jueguito", misDatos), misDatos)[0], "Todavia nadie ha jugado Jueguito");
        }
        
        [TestMethod]
        public void GenerarPuntajeMaximo()
        {
            misDatos.usuarioLogeado = nicolasVarela;
            Assert.AreEqual(Juego.GenerarPuntajesMaximos(misDatos)[0], ($"Jueguito .... 10"));
        }
    }
}
