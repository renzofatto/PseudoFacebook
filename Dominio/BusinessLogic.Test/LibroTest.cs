using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;


namespace Dominio.Test
{
    [TestClass]
    public class LibroTest
    {
        private readonly string[] Names = new string[] { "John", "Johny", "Rob", "Bob", "Jessica", "Mike" };
        private readonly string[] Surnames = new string[] { "Doe", "Goodman", "McClaw", "White" };
        private readonly DateTime[] Dates = new DateTime[] { new DateTime(1997, 10, 7), new DateTime(1999, 9, 9) };
        private Direccion algunaDireccion;
        private const string PicturePathSample = @"Resources\test-image.jpg";
        private const string NombreDeLibro = "AlgunLibro";
        private readonly Random rand = new Random();

        private IList<Usuario> usuarios;

        private Libro libro = new Libro();

        private Usuario GetRandomProfile()
        {
            return usuarios?[rand.Next(usuarios.Count)];

        }

        [TestMethod]
        public void NuevoLibro()
        {
            var nuevoLibro = new Libro();
            Assert.IsNotNull(nuevoLibro);
        }

        [TestMethod]
        public void SetNombreLibro()
        {
            libro.Nombre = NombreDeLibro;
            Assert.AreEqual(libro.Nombre, NombreDeLibro);
        }

        [TestMethod]
        public void ContieneUsuario()
        {
            var algunUsuario = GetRandomProfile();
            Assert.IsFalse(libro.Contiene(algunUsuario));
        }

        [TestMethod]
        public void AgregarUsuario()
        {
            var libro = new Libro()
            {
                Nombre = NombreDeLibro,
            };

            var algunUsuario = GetRandomProfile();
            
            libro.Agregar(algunUsuario);
            Assert.IsTrue(libro.Contiene(algunUsuario));
        }

        [TestMethod]
        public void BorrarUsuario()
        {
            var algunUsuario = GetRandomProfile();
            libro.Agregar(algunUsuario);
            libro.Borrar(algunUsuario);
            Assert.IsFalse(libro.Contiene(algunUsuario));
        }
        [TestMethod]
        public void TodosLosUsuarios()
        {
            Usuario algunUsuario = new Usuario()
            {
                Nombre = "Juan",
                NombreUsuario = "pepo",
                Apellido = "Coso"
            };
            Usuario otroUsuario = new Usuario()
            {
                Nombre = "Pedro",
                NombreUsuario = "Cacho22",
                Apellido = "Gomez"
            };
            Libro libro = new Libro();
            libro.Agregar(algunUsuario);
            libro.Agregar(otroUsuario);
            IList<Usuario> lista = libro.TodosLosUsuarios();
            foreach (var usuario in lista)
            {
                Assert.IsTrue(libro.Contiene(usuario));
            }
        }
    }
}
