using System;
using System.Collections.Generic;
using System.Linq;

namespace ObligatorioDisenoDeAplicaciones
{
    public class Libro
    {
        private List<Usuario> usuarios;

        public Libro()
        {
            usuarios = new List<Usuario>();
        }

        public void Agregar(Usuario algunUsuario)
        {
            usuarios.Add(algunUsuario);
        }

        public void Borrar(string usuario)
        {
            Usuario user = usuarios.First(u => u.NombreUsuario == usuario);
            usuarios.Remove(user);
        }

        public bool Exists(string algunUsuario)
        {
            return usuarios.Any(user => user.NombreUsuario == algunUsuario);
        }

        public List<Usuario> GetAll()
        {
            return new List<Usuario>(usuarios);
        }

        public string Nombre { get; set; }


    }
}