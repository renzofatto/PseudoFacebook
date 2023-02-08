using Dominio;
using System;

namespace ObligatorioDisenoDeAplicaciones
{
    public class Comentario : Publicacion
    {
        private int minimoLargoComentario = 1;
        private int maximoLargoComentario = 160;
        private string contenido;
        public Comentario(Usuario creadaPor) : base(creadaPor)
        {
        }
        public override Usuario CreadoPor { get; set; }
        public string Contenido
        {
            get => contenido;
            set
            {
                if (value?.Length < minimoLargoComentario || value?.Length > maximoLargoComentario)
                {
                    throw new DominioException($"El comentario tiene que tener entre {minimoLargoComentario} y {maximoLargoComentario} caracteres");
                }
                contenido = value ?? throw new ArgumentNullException("El comentario no puede ser vacio");
            }
        }

        public static bool verificarComentario(string comentario)
        {
            bool verifica = false;
            return verifica;
        }
        public override string ToString()
        {
            return ($"{CreadoPor}: {contenido}");
        }
    }
}