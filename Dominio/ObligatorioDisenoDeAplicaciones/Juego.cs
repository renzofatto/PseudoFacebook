using Dominio;
using System;
using System.Collections.Generic;

namespace ObligatorioDisenoDeAplicaciones
{
    public class Juego
    {
        private const int tituloMasCorto = 5;
        private const int tituloMasLargo = 40;
        public string titulo;
        public List<Jugada> jugadas;
        private string caratula;

        public Juego()
        {
            jugadas = new List<Jugada>();
        }

        public string Titulo
        {
            get => titulo;
            set
            {
                if (value?.Length < tituloMasCorto || value?.Length > tituloMasLargo)
                {
                    throw new JuegoException($"El titulo tiene que tener entre {tituloMasCorto} y {tituloMasLargo} caracteres");
                }
                titulo = value;
            }
        }

        public static bool TituloDeJuegoValido(string tituloAValidar, List<Juego> juegos) 
        {
            bool validado = false;
            Juego aux = new Juego();
            aux.Titulo = tituloAValidar;
            if (juegos.Count > 0)
            {
                foreach (var juego in juegos)
                {
                    if (juego.Titulo.Equals(aux.Titulo))
                    {
                        throw new JuegoException("Este nombre de juego ya existe, seleccione otro por favor!");
                    }
                    else
                    {
                        validado = true;
                    }
                }
            }
            else {
                validado = true;
            }
            return validado;
        }

        public string Caratula 
        {
            get => caratula;
            set
            {
                caratula = value ?? throw new ArgumentException("El juego tiene que tener una imagen");
            }
        }

        public List<Jugada> TodasLasJugadas()
        {
            List<Jugada> todasLasJugadas = jugadas;
            return todasLasJugadas;
        }

        public string Categoria { get; set; }

        public void Jugar(int puntaje, Usuario player)
        {
            Jugada nuevaJugada = new Jugada(player)
            {
                Juego = Titulo,
                Jugador = player,
                Puntaje = puntaje,
            };
            jugadas.Add(nuevaJugada);
        }

        public static void AgregarJuego(string titulo, string categoria, string caratulaSeleccionada, Datos datos)
        {
            Juego juegoNuevo = new Juego();
            juegoNuevo.Titulo = titulo;
            juegoNuevo.Caratula = caratulaSeleccionada;
            juegoNuevo.Categoria = categoria;
            datos.JuegosCreados.Add(juegoNuevo);
        }

        public static bool NoExisteJuego(string titulo, Datos datos)
        {
            bool verifica = true;
            foreach (var juego in datos.JuegosCreados)
            {
                if (juego.Titulo.Equals(titulo))
                {
                    verifica = false;
                }
            }
            return verifica;
        }

        public static string TopDiez(Juego juegoSeleccionado, Datos datos)
        {
            string topJugadores = TopJugadores(juegoSeleccionado);
            return topJugadores;
        }

        private static string TopJugadores(Juego juego)
        {
            List<int> topPuntajes = new List<int>();
            List<Usuario> jugadores = new List<Usuario>();
            List<Jugada> jugadas = juego.TodasLasJugadas();
            jugadas.Sort();
            string top = $"Todavia nadie ha jugado {juego.Titulo}";
            int count = 0;
            if (jugadas.Count > 0)
            {
                for (int i = 0; i < jugadas.Count && (count < 10); i++)
                {
                    var jugada = jugadas[i];
                    if (!jugadores.Contains(jugada.Jugador))
                    {
                        jugadores.Add(jugada.Jugador);
                        topPuntajes.Add(jugada.Puntaje);
                        count++;
                    }
                }
                top = ArmarTop(jugadores, topPuntajes);
            }
            return top;
        }

        private static string ArmarTop(List<Usuario> jugadores, List<int> puntajes)
        {
            string top = "";
            for (int i = 0; i < jugadores.Count && i < 10; i++)
            {
                top += $"{System.Environment.NewLine} {i + 1} {jugadores[i].NombreUsuario} {puntajes[i]}";
            }
            return top;
        }

        public static Juego getJuegoFromTitulo(string titulo, Datos datos)
        {
            Juego juegoEncontrado = null;
            foreach (var juego in datos.JuegosCreados)
            {
                if (juego.Titulo.Equals(titulo))
                {
                    juegoEncontrado = juego;
                }
            }
            return juegoEncontrado;
        }

        public static List<string> GenerarPuntajesMaximos(Datos datos)
        {
            var usuario = datos.usuarioLogeado;
            List<string> puntajesMaximos = new List<string>();
            List<Jugada> jugadas = ManejadorListas.JugadasDe(usuario, ManejadorListas.UnirJugadasDeJuegos(datos.JuegosCreados));
            jugadas.Sort();
            string anterior = "";
            foreach (var jugada in jugadas)
            {
                if (!jugada.Juego.Equals(anterior))
                {
                    puntajesMaximos.Add($"{jugada.Juego} .... {jugada.Puntaje}");
                    anterior = jugada.Juego;
                }
            }
            return puntajesMaximos;
        }
    }
}