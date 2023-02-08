using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;

namespace Dominio.Test
{
    [TestClass]
    public class UsuarioTest
    {
        private const int ApellidoLargoMaximo = 30;
        private const int UsuarioLargoMaximo = 30;
        private const string sebastian = "Sebastian";
        private const string fernandez = "Fernandez";
        private const string papelito = "Papelito";
        private DateTime fechaNacimiento = new DateTime(1985, 5, 23);
        private const string pathDeImagen = @"Resources\test-image.jpg";
        private Usuario sebastianFernandez;
        private Usuario thiagoVecino;
        private const string nombreDemasiadoLargo = "NombreDemasiadoLargoTanLargoQueNoSePuedeAgregarUnNombreTanLargo";
        private const int SaltSize = 16;
        private const int HashSize = 20;

        [TestInitialize]
        public void Initialize()
        {
            sebastianFernandez = new Usuario()
            {
                Nombre = sebastian,
                Apellido = fernandez,
                NombreUsuario = papelito,
                FechaNacimiento = fechaNacimiento,
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
        }

        [TestMethod]
        public void NuevoUsuarioCreadoCorrectamente()
        {
            Assert.IsNotNull(sebastianFernandez);
        }

        [TestMethod]
        public void DireccionCreadaCorrectamente()
        {
            Assert.IsNotNull(sebastianFernandez.DireccionPersona);
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void NombreMuyLargo()
        {
            sebastianFernandez.Nombre = nombreDemasiadoLargo;
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void NombreMuyCorto()
        {
            sebastianFernandez.Nombre = "";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NombreVacio()
        {
            sebastianFernandez.Nombre = null;
        }

        [TestMethod]
        public void UsuariosIguales()
        {
            thiagoVecino.NombreUsuario = papelito;
            bool sonIguales = sebastianFernandez.Equals(thiagoVecino);
            Assert.IsTrue(sonIguales);
        }

        [TestMethod]
        public void UsuariosDistintos()
        {
            bool sonIguales = sebastianFernandez.Equals(thiagoVecino);
            Assert.IsFalse(sonIguales);
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void UsuarioMuyMayor()
        {
            sebastianFernandez.FechaNacimiento = new DateTime(1930, 04, 10);
        }

        [TestMethod]
        public void UsuarioConEdadCorrecta()
        {
            sebastianFernandez.FechaNacimiento = fechaNacimiento;
        }

        [TestMethod]
        public void SetImagenDePerfil()
        {
            sebastianFernandez.PicturePath = pathDeImagen;
            Assert.AreEqual(pathDeImagen, sebastianFernandez.PicturePath);
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void SetImagenConPathMuyLargo()
        {
            string pathMuyLargo = GenerarStringLargo("a", Usuario.PathMaximo + 1);
            string pathInvalido = pathMuyLargo;
            sebastianFernandez.PicturePath = pathInvalido;
        }

        [TestMethod]
        public void SetAdministrador()
        {
            sebastianFernandez.Administrador = true;
            Assert.IsTrue(sebastianFernandez.Administrador);
        }

        [TestMethod]
        public void EsAdministrador()
        {
            Assert.IsFalse(sebastianFernandez.Administrador);
        }

        [TestMethod]
        public void LogearUsuario()
        {
            sebastianFernandez.Logeado = true;
            Assert.IsTrue(sebastianFernandez.Logeado);
        }

        [TestMethod]
        public void EstaLogeado()
        {
            Assert.IsFalse(sebastianFernandez.Logeado);
        }

        [TestMethod]
        public void SetContrasena()
        {
            sebastianFernandez.Contrasena = "Contrasenia";
            Assert.IsTrue(Equals(Hash("Contrasenia"), sebastianFernandez.Contrasena));
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void SetContrasenaCorta()
        {
            sebastianFernandez.Contrasena = "Corta";
        }

        [TestMethod]
        public void ContrasenaIncorrecta()
        {
            sebastianFernandez.Contrasena = "Contrasenia";
            Assert.IsFalse(Equals("Contrasenia", sebastianFernandez.Contrasena));
        }

        [TestMethod]
        public void GetListaSeguidos()
        {
            Assert.IsTrue(sebastianFernandez.Seguidos.Count == 1);
        }

        [TestMethod]
        public void FulanoSigueAMengano()
        {
            sebastianFernandez.SeguirA(thiagoVecino);
            Assert.IsTrue(sebastianFernandez.SigueA(thiagoVecino));
        }

        [TestMethod]
        public void CantidadDeSeguidos()
        {
            sebastianFernandez.SeguirA(thiagoVecino);
            Assert.IsTrue(sebastianFernandez.Seguidos.Count == 2);
        }

        [TestMethod]
        public void CantidadDeSeguidosDespuesDeBorrar()
        {
            sebastianFernandez.SeguirA(thiagoVecino);
            sebastianFernandez.DejarDeSeguirA(thiagoVecino);
            Assert.IsTrue(sebastianFernandez.Seguidos.Count == 1);
        }

        [TestMethod]
        public void GetNombreUsuario()
        {
            Assert.IsTrue(Equals(sebastianFernandez.Nombre, sebastian));
        }

        [TestMethod]
        public void GetApellidoUsuario()
        {
            Assert.IsTrue(Equals(sebastianFernandez.Apellido, fernandez));
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void SetApellidoLargo()
        {
            string apellidoMuyLargo = GenerarStringLargo("a", ApellidoLargoMaximo + 1);
            string apellidoInvalido = apellidoMuyLargo;
            sebastianFernandez.Apellido = apellidoInvalido;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetApellidoNull()
        {
            sebastianFernandez.Apellido = null;
        }

        [TestMethod]
        public void GetNombreDeUsuariodeUsuario()
        {
            Assert.IsTrue(Equals(sebastianFernandez.NombreUsuario, papelito));
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void SetNombreUsuarioLargo()
        {
            string nombreUsuarioLargo = GenerarStringLargo("a", UsuarioLargoMaximo + 1);
            string nombreUsuarioInvalido = nombreUsuarioLargo;
            sebastianFernandez.NombreUsuario = nombreUsuarioInvalido;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetNombreUsuarioNull()
        {
            sebastianFernandez.NombreUsuario = null;
        }

        [TestMethod]
        public void GetFechaNacimientoUsuario()
        {
            Assert.IsTrue(Equals(sebastianFernandez.FechaNacimiento, fechaNacimiento));
        }

        [TestMethod]
        public void SetAlbumes()
        {
            List<Album> albums = new List<Album>();
            sebastianFernandez.Albumes = albums;
            Assert.IsTrue(sebastianFernandez.Albumes.Count==0);
        }

        [TestMethod]
        public void SetEstados()
        {
            List<Estado> estados = new List<Estado>();
            sebastianFernandez.Estados = estados;
            Assert.IsTrue(sebastianFernandez.Estados.Count == 0);
        }

        [TestMethod]
        public void SetEscuchando()
        {
            List<Escuchando> escuchadas = new List<Escuchando>();
            sebastianFernandez.Escuchadas = escuchadas;
            Assert.IsTrue(sebastianFernandez.Escuchadas.Count == 0);
        }

        [TestMethod]
        public void AddAlbumes()
        {
            Album albumSebastian = new Album(sebastianFernandez);
            albumSebastian.NombreAlbum = "Grecia";
            sebastianFernandez.Albumes.Add(albumSebastian);
            Assert.IsTrue(sebastianFernandez.Albumes.Count == 1);
        }

        [TestMethod]
        public void AddEstados()
        {
            Estado estado = new Estado(sebastianFernandez, "Estado para probar Add");
            sebastianFernandez.Estados.Add(estado);
            Assert.IsTrue(sebastianFernandez.Estados.Count == 1);
        }

        [TestMethod]
        public void AddEscuchando()
        {
            Escuchando escuchada = new Escuchando(sebastianFernandez, "cancionPrueba", "artistaEscuchado", "albumEscuchado");
            sebastianFernandez.Escuchadas.Add(escuchada);
            Assert.IsTrue(sebastianFernandez.Escuchadas.Count == 1);
        }

        private static string GenerarStringLargo(string texto, int largo)
        {
            string pathMuyLargo = "";
            while (pathMuyLargo.Length < largo)
                pathMuyLargo += texto;
            return pathMuyLargo;
        }

        private string Hash(string password, int iterations = 1000)
        {
            byte[] salt = new byte[SaltSize];
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkdf2.GetBytes(HashSize);
            var hashedBase46String = Convert.ToBase64String(hash);
            return hashedBase46String;
        }
    }
}