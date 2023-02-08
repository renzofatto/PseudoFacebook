using System;

namespace ObligatorioDisenoDeAplicaciones
{
    public class Juego
    {
        private const int tituloMasCorto = 3;
        private const int tituloMasLargo = 40;
        public string titulo;
        public Juego()
        {
        }

        public string Titulo { get => titulo;
            set
            {
                if(value?.Length < tituloMasCorto || value?.Length > tituloMasLargo)
                {
                    throw new JuegoException($"El titulo tiene que tener entre {tituloMasCorto} y {tituloMasLargo} caracteres");
                }
                titulo = value ?? throw new ArgumentNullException("El titulo no puede ser null");
            }
        }
    }
}