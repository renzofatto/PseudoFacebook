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
        private const string NombreDeLibro = "Harry Potter y la piedra filosofal";
        private Libro libro;
        private Usuario sebastianFernandez;
        private Usuario thiagoVecino;

        [TestInitialize]
        public void Initialize()
        {
            sebastianFernandez = new Usuario()
            {
                Nombre = "Sebastian",
                Apellido = "Fernandez",
                NombreUsuario = "Papelito",
                FechaNacimiento = new DateTime (1997,5,4),
                DireccionPersona = new Direccion()
                {
                    Pais = "Uruguay",
                    Ciudad = "Montevideo",
                    Calle = "Cuareim",
                }
            };
            thiagoVecino = new Usuario()
            {
                Nombre = "Thiago",
                Apellido = "Vecino",
                FechaNacimiento = new DateTime(2000, 2, 22),
                NombreUsuario = "Thiagol",
                DireccionPersona = new Direccion()
                {
                    Pais = "Argentina",
                    Ciudad = "Buenos Aires",
                    Calle = "Corriente",
                }
            };
            libro = new Libro();
            libro.Agregar(sebastianFernandez);
        }

        [TestMethod]
        public void NuevoLibro()
        {
            Libro nuevoLibro = new Libro();
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
            Assert.IsTrue(libro.Exists(sebastianFernandez.NombreUsuario));
        }

        [TestMethod]
        public void NoContieneThiago()
        {
            Assert.IsFalse(libro.Exists(thiagoVecino.NombreUsuario));
        }

        [TestMethod]
        public void AgregarUsuario()
        {
            Libro libro = new Libro()
            {
                Nombre = NombreDeLibro,
            };
            libro.Agregar(thiagoVecino);
            Assert.IsTrue(libro.Exists(thiagoVecino.NombreUsuario));
        }

        [TestMethod]
        public void BorrarUsuario()
        {
            libro.Borrar(sebastianFernandez.NombreUsuario);
            Assert.IsFalse(libro.Exists(thiagoVecino.NombreUsuario));
        }

        [TestMethod]
        public void TodosLosUsuarios()
        {
            libro.Agregar(thiagoVecino);
            IList<Usuario> lista = libro.GetAll();
            foreach (var usuario in lista)
            {
                Assert.IsTrue(libro.Exists(usuario.NombreUsuario));
            }
        }
        
        [TestMethod]
        public void Clonacion()
        {
            libro.Agregar(thiagoVecino);
            IList<Usuario> copia = libro.GetAll();
            copia.Remove(sebastianFernandez);
            Assert.IsTrue(libro.Exists(sebastianFernandez.NombreUsuario));

        }
    }
}
