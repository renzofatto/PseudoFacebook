using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class UsuarioEntity
    {
        [Key]
        public int Id_Usuario { get; set; }
        public UsuarioEntity() {
            seguidos = new List<UsuarioEntity>();
            publicaciones = new List<PublicacionEntity>();
            
        }

        public string NombreUsuario { get; set; }

        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Direccion DireccionPersona{ get; set; }
        public bool Administrador { get; set; }
        public bool Logeado { get; set; }
        public string PicturePath { get; set; }

        public virtual IList<UsuarioEntity> seguidos { get; set; }
        public virtual IList<PublicacionEntity> publicaciones{ get; set; }
        



    }
}
