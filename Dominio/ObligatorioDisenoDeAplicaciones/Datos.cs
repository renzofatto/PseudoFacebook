using Dominio;
using ObligatorioDisenoDeAplicaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDisenoDeAplicaciones
{
    public class Datos
    {
        public List<Usuario> UsuariosRegistrados { get; set; }
        
        public List<Juego> JuegosCreados { get; set; }

        public Usuario usuarioLogeado { get; set; }
        
        public List<string> Reporte { get; set; }
        
        public Datos()
        {
            UsuariosRegistrados = new List<Usuario>();
            JuegosCreados = new List<Juego>();
            Reporte = new List<string>();
        }
    }
}
