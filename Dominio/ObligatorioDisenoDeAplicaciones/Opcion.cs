using System;
using System.Collections.Generic;

namespace ObligatorioDisenoDeAplicaciones
{
    public class Opcion
    {
        private const int opcionLargoMaximo = 160;
        private string textoOpcion;
        private int votos;

        public Opcion(string textoOpcion1)
        {
            TextoOpcion = textoOpcion1;
            votos = 0;
        }

        public string TextoOpcion
        {
            get => textoOpcion;
            set
            {
                if (value?.Length > opcionLargoMaximo)
                {
                    throw new OpcionException($"La opcion debe tener menos que {opcionLargoMaximo} caracteres.");
                }
                if (value == "")
                {
                    throw new OpcionException($"La opcion debe tener al menos 1 caracter.");
                }
                textoOpcion = value;
            }
        }

        public int Votos 
        {
            get => votos;
        }

        public void AgregarVotante()
        {
            votos++;
        }
    }
}