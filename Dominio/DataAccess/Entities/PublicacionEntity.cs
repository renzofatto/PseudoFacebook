using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class PublicacionEntity
    {
        [Key]
        public int Id { get; set; }
        
        public UsuarioEntity CreadoPor { get; set; }
        public string Tipo { get; set; }

        public DateTime FechaCreacion { get; set; }

    }

    public class AlbumEntity : PublicacionEntity
    {
        public AlbumEntity()
        {
            IList<string> album = new List<string>();
        }
        
        
    }

    public class EstadoEntity : PublicacionEntity
    {
        public string TextoDeEstado { get; set; }
    }

    public class EscuchandoEntity : PublicacionEntity
    {
        public string Cancion { get; set; }
        public string Album { get; set; }
        public string Artista { get; set; }
    }

    public class JugadaEntity : PublicacionEntity
    {
        public string Juego { get; set; }
        public int Puntaje { get; set; }
        public UsuarioEntity Jugador { get; set; }
    }
}
