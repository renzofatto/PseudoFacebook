using Dominio;
using System;

namespace ObligatorioDisenoDeAplicaciones
{ 
    public class Estado : Publicacion
    {
        private const int EstadoLargoMinimo = 10;
        private const int EstadoLargoMaximo = 260;
        private string textoDeEstado;
        
        public Estado(Usuario creadaPor, string texto): base(creadaPor)
        {
            textoDeEstado = texto;
        }
        public string TextoDeEstado
        {
            get => textoDeEstado;
            set
            {
                if (value?.Length < EstadoLargoMinimo || value?.Length > EstadoLargoMaximo)
                {
                    throw new PublicacionException($"El estado tiene que tener entre {EstadoLargoMinimo} y {EstadoLargoMaximo} caracteres");
                }
                textoDeEstado = value ?? throw new ArgumentNullException("El texto no puede ser null");
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
    }
}
