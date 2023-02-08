using System;

namespace ObligatorioDisenoDeAplicaciones
{
    public class Jugada : Publicacion, IComparable<Jugada>
    {
        private DateTime fechaCreacion = new DateTime();

        public Jugada(Usuario creadaPor) : base(creadaPor)
        {
            fechaCreacion = DateTime.Now;
        }
        public override Usuario CreadoPor
        {
            get => creadoPor;
            set => creadoPor = value;
        }

        public string Juego { get; set; }

        public int Puntaje { get; set; }

        public Usuario Jugador { get; set; }

        public int CompareTo(Jugada other)
        {
            return other.Puntaje.CompareTo(this.Puntaje);
        }

        public DateTime FechaCreacion { get; set; }
    }
}