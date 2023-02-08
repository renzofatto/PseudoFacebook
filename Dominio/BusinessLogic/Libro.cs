using System;
using System.Collections.Generic;


namespace ObligatorioDisenoDeAplicaciones
{
    public class Libro
    {
        private IList<Usuario> usuarios;

        public Libro()
        {
            usuarios = new List<Usuario>();
        }

        public string Nombre { get; set; }

        public bool Contiene(Usuario algunUsuario)
        {
            return usuarios.Contains(algunUsuario);
        }

        public void Agregar(Usuario algunUsuario)
        {
            usuarios.Add(algunUsuario);
        }

        public void Borrar(Usuario algunUsuario)
        {
            usuarios.Remove(algunUsuario);
        }

        public IList<Usuario> TodosLosUsuarios()
        {
            return new List<Usuario>(usuarios);
        }
    }
}