using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDisenoDeAplicaciones
{
    public class Sistema
    {
        private IList<Usuario> usuarios;
        private IList<Album> albumes;
        private IList<Escuchando> escuchandos;
        private IList<Estado> estados;

        public IList<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        public IList<Album> Albumes { get => albumes; set => albumes = value; }
        public IList<Escuchando> Escuchandos { get => escuchandos; set => escuchandos = value; }
        public IList<Estado> Estados { get => estados; set => estados = value; }
    }

}
