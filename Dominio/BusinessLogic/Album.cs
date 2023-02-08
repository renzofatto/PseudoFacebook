using Dominio;
using System;
using System.Collections.Generic;

namespace ObligatorioDisenoDeAplicaciones
{
    public class Album : Publicacion
    {
        private readonly int maximoImagenes = 10;
        
        private IList<Uri> album;
        private Uri pathImagen;
        private string nombreAlbum;


        public Album(Usuario creadaPor, string nombre) : base(creadaPor)
        {
            album = new List<Uri>();
            nombreAlbum = nombre;
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
            pathImagen = new Uri(unaFoto, UriKind.RelativeOrAbsolute);
            album.Add(pathImagen);
        }
        public void Borrar(string unaFoto)
        {
            pathImagen = new Uri(unaFoto, UriKind.RelativeOrAbsolute);
            album.Remove(pathImagen);
        }
        public IList<Uri> TodasLasFotos()
        {
            return new List<Uri>(album);
        }
        public string NombreAlbum
        {
            get => nombreAlbum;
            set => nombreAlbum = value;
        }
    }
}
