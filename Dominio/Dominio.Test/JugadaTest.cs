using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;
using System;

namespace Dominio.Test
{
    [TestClass]
    public class JugadaTest
    {
        private Usuario jugador;
        private Jugada nuevaJugada;
        private Jugada jugadaPuntajeAlto;
        private Jugada jugadaPuntajeBajo;

        [TestInitialize]
        public void Initilize()
        {
            jugador = new Usuario()
            {
                Nombre = "Ariel",
                NombreUsuario = "Nahuelgol"
            };
            nuevaJugada = new Jugada()
            {
                Juego = "Fifa",
                Puntaje = 300
            };
            jugadaPuntajeAlto = new Jugada()
            {
                Juego = "Nba",
                Puntaje = 10000
            };
            jugadaPuntajeBajo = new Jugada()
            {
                Juego = "Tetris",
                Puntaje = 20
            };
        }

        [TestMethod]
        public void NuevaJugada()
        {
            Jugada nuevaJugada = new Jugada();
            Assert.IsNotNull(nuevaJugada);
        }

        [TestMethod]
        public void JugarTest()
        {
            Juego nuevoJuego = new Juego();
            nuevoJuego.Jugar(200, jugador);
            Assert.IsNotNull(nuevoJuego.TodasLasJugadas());
        }

        [TestMethod]
        public void SetPuntaje()
        {
            Assert.AreEqual(nuevaJugada.Puntaje, 300);
        }

        [TestMethod]
        public void PuntajeDistinto()
        {
            Assert.AreNotEqual(jugadaPuntajeAlto.Puntaje, jugadaPuntajeBajo.Puntaje);
        }

        [TestMethod]
        public void AsignarJugador()
        {
            nuevaJugada.Jugador = jugador;
            Assert.AreEqual(jugador, nuevaJugada.Jugador);
        }

        [TestMethod]
        public void CompararJugada()
        {
            Assert.IsTrue(jugadaPuntajeAlto.CompareTo(jugadaPuntajeBajo) == -1);
        }
    }
}
