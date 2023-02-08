using System;
using System.Collections.Generic;

namespace ObligatorioDisenoDeAplicaciones
{
    public class Encuesta : Publicacion
    {
        private const int encuestaLargoMaximo = 160;
        private string textoDeEncuesta;
        private List<Opcion> opciones = new List<Opcion>();
        private int votosTotales;
        private List<Usuario> votantes = new List<Usuario>();

        public Encuesta(Usuario creadaPor, string texto) : base(creadaPor)
        {
            TextoDeEncuesta = texto;
            votosTotales = 0;
        }

        public string TextoDeEncuesta
        {
            get => textoDeEncuesta;
            set
            {
                if (value?.Length > encuestaLargoMaximo)
                {
                    throw new EncuestaException($"La encuesta tiene que tener menos de {encuestaLargoMaximo} caracteres");
                }
                if(value == "")
                {
                    throw new EncuestaException("La encuesta tiene que tener algun caracter");
                }
                textoDeEncuesta = value;
            }
        }

        public override Usuario CreadoPor
        {
            get => creadoPor;
            set => creadoPor = value;
        }

        public override DateTime FechaCreacion
        {
            get => fechaCreacion;
            set => fechaCreacion = value;
        }

        public void AgregarOpcion(Opcion opcion)
        {
            if (this.CuantasOpciones == 5)
            {
                throw new EncuestaException("La encuesta ya tiene el maximo de opciones posibles");
            }
            if(opcion == null)
            {
                throw new ArgumentException("Opcion vacia");
            }
            foreach(Opcion opcionEnLista in opciones)
            {
                if (opcionEnLista.TextoOpcion.Equals(opcion.TextoOpcion))
                {
                    throw new EncuestaException("Hay dos opciones iguales");
                }
            }
            this.opciones.Add(opcion); 
        }

        public int CuantasOpciones 
        { 
            get => opciones.Count;
        }

        public int VotosTotales 
        {
            get => votosTotales;
        }
        public List<Usuario> Votantes { get ; set ; }

        public void AgregarVotante(Usuario votante, Opcion opcionElegida)
        {
            foreach (var opcion in opciones)
            {
                if (opcion.TextoOpcion.Equals(opcionElegida.TextoOpcion))
                {
                    opcion.AgregarVotante();
                    votantes.Add(votante);
                    votosTotales++;
                }
            }
        }
        
        public void AgregarVotanteYVoto(Usuario votante, string opcionElegida)
        {
            if (votantes.Contains(votante))
            {
                throw new EncuestaException($"{votante.NombreUsuario} ya voto");
            }
            foreach (var opcion in opciones)
            {
                if (opcion.TextoOpcion.Equals(opcionElegida))
                {
                    opcion.AgregarVotante();
                    votantes.Add(votante);
                    votosTotales++;
                }
            }
        }

        public string[] OpcionesArray()
        {
            int aux = 0;
            string[] retorno = new string[CuantasOpciones];
            foreach (var opcion in opciones)
            {
                retorno[aux] = opcion.TextoOpcion;
                aux++;
            }
            return retorno;
        }

        public int[] VotosArray()
        {
            int aux = 0;
            int[] retorno = new int[CuantasOpciones];
            foreach (var opcion in opciones)
            {
                retorno[aux] = opcion.Votos;
                aux++;
            }
            return retorno;
        }
    }
}