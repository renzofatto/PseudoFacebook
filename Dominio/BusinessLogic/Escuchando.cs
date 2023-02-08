using System;

namespace ObligatorioDisenoDeAplicaciones
{
    public class Escuchando : Publicacion
    {
        private string artista;
        private string cancion;
        private string album;

        public Escuchando(Usuario creadaPor, string cancionEscuchando, string artistaEscuchando, string albumEscuchando) : base(creadaPor)
        {
            artista = artistaEscuchando;
            cancion = cancionEscuchando;
            album = albumEscuchando;
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
        public string Artista 
        { 
            get=> artista; 
            set=> artista = value; 
        }
        public string Cancion
        {
            get => cancion;
            set => cancion = value;
        }
        public string Album
        {
            get => album;
            set => album = value;
        }
        public override string ToString()
        {
            return creadoPor.Nombre + " esta escuchando " + cancion + " de " + artista + " del album "+ album;
        }
    }
}
