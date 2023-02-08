using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;
using System;

namespace DataAccess.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetTest()
        {
            DBUsers usuarios = new DBUsers();
            usuarios.Clear();
            Usuario usuario = new Usuario()
            {
                NombreUsuario = "pepe",
                Contrasena = "asdasdasd",
                Administrador = true,
                Nombre = "Jose",
                Apellido = "Perez",
                DireccionPersona = new Dominio.Direccion() { Pais = "xdxdxd", Ciudad = "lalaalal", Calle = "xdxdasjdkad" },
                Logeado = false,
                PicturePath = "asdkjlaskl"

            };
            usuarios.Agregar(usuario);
            var retrieved = usuarios.Get(usuario.NombreUsuario);

            Assert.AreEqual(usuario.NombreUsuario, retrieved.NombreUsuario);
        }

        [TestMethod]
        public void PublicacionTest()
        {
            
        }
    }
}
