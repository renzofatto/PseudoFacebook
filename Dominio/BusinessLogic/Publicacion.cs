using System;

namespace ObligatorioDisenoDeAplicaciones
{
    public abstract class Publicacion
    {
        public Usuario creadoPor;
        public DateTime fechaCreacion;

        public Publicacion(Usuario usuarioCreador)
        {
            creadoPor = usuarioCreador;
            fechaCreacion = DateTime.Now;
        }
        public abstract Usuario CreadoPor { get; set; }
        public abstract DateTime FechaCreacion { get; set; }
    }
}
