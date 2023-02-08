using Dominio;
using System;
using System.Collections.Generic;

namespace ObligatorioDisenoDeAplicaciones
{
    public class Album : Publicacion
    {
        private readonly int maximoImagenes = 10;
        private IList<string> album;
        private String pathImagen;
        private string nombreAlbum;

        public Album(Usuario creadaPor) : base(creadaPor)
        {
            album = new List<string>();
        }

        public override Usuario CreadoPor 
        { 
            get=> creadoPor; 
            set=> creadoPor = value; 
        }

        public override DateTime FechaCreacion 
        { 
            get=> fechaCreacion; 
            set => fechaCreacion = value; 
        }

        public void Agregar(string unaFoto)
        {
            if (album.Count == maximoImagenes)
            {
                throw new PublicacionException($"El album no puede tener mas que {maximoImagenes} imagenes");
            }
            pathImagen = unaFoto;
            album.Add(pathImagen);
        }

        public void Borrar(string unaFoto)
        {
            pathImagen = unaFoto;
            album.Remove(pathImagen);
        }

        public IList<string> TodasLasFotos()
        {
            return new List<string>(album);
        }

        public string NombreAlbum
        {
            get => nombreAlbum;
            set
            {
                if (value == "") 
                {
                    throw new ArgumentException("El nombre del album no puede ser vacio");
                }
                nombreAlbum = value;
            }
        }

        public override string ToString()
        {
            return NombreAlbum + " fue creado el " + FechaCreacion;
        }
    }
}
