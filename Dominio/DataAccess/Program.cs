using ObligatorioDisenoDeAplicaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {

            DBUsers usuarios = new DBUsers();
            usuarios.Clear();
            Usuario usuario = new Usuario()
            {
                NombreUsuario = "pepe",
                Contrasena = "asdasdasd",
                Administrador = true,
                Logeado = true,
                DireccionPersona = new Dominio.Direccion() { Pais = "xdxdxd", Ciudad = "lalaalal", Calle = "xdxdasjdkad" },
                Nombre = "Jose",
                PicturePath = "djasdhajakjd",
                Apellido = "Perez",

            };
            Usuario usuario2 = new Usuario()
            {
                NombreUsuario = "Tomas",
                Contrasena = "asdasdasd",
                Administrador = true,
                Logeado = true,
                DireccionPersona = new Dominio.Direccion() { Pais = "xdxdxd", Ciudad = "lalaalal", Calle = "xdxdasjdkad" },
                Nombre = "Jose",
                PicturePath = "djasdhajakjd",
                Apellido = "Perez",

            };
            usuarios.Agregar(usuario);
            usuarios.Agregar(usuario2);
            

            
        }
    }
}
