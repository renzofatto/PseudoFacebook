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
        private const string Fulano = "Fulano";
        private const string DeTal = "DeTal";
        private const string fulanito = "fulanito";
        private DateTime fechaNacimiento = new DateTime(1998, 10, 7);
        private const string pathDeImagen = @"Resources\test-image.jpg";
        private Usuario fulanoDeTal;
        private Usuario menganoDeTal;
        private const string nombreDemasiadoLargo = "NombreDemasiadoLargoTanLargoQueNoSePuedeAgregarUnNombreTanLargo";
        private const int SaltSize = 16;
        private const int HashSize = 20;

        [TestInitialize]
        public void Initialize()
        {
            fulanoDeTal = new Usuario()
            {
                Nombre = Fulano,
                Apellido = DeTal,
                NombreUsuario = fulanito,
                FechaNacimiento = fechaNacimiento,
                DireccionPersona = new Direccion()
                {
                    Pais = "Uruguay",
                    Ciudad = "Montevideo",
                    Calle = "Cuareim",
                }
            };
            menganoDeTal = new Usuario()
            {
                Nombre = "Mengano",
                Apellido = "DeTala",
                FechaNacimiento = new DateTime(2000, 1, 1),
                NombreUsuario = "menganito",
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
            Assert.IsNotNull(fulanoDeTal);
        }

        [TestMethod]
        public void DireccionCreadaCorrectamente()
        {
            Assert.IsNotNull(fulanoDeTal.DireccionPersona);
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void NombreMuyLargo()
        {
            fulanoDeTal.Nombre = nombreDemasiadoLargo;
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void NombreMuyCorto()
        {
            fulanoDeTal.Nombre = "";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NombreVacio()
        {
            fulanoDeTal.Nombre = null;
        }

        [TestMethod]
        public void UsuariosIguales()
        {
            menganoDeTal.NombreUsuario = fulanito;
            bool sonIguales = fulanoDeTal.Equals(menganoDeTal);
            Assert.IsTrue(sonIguales);
        }

        [TestMethod]
        public void UsuariosDistintos()
        {
            bool sonIguales = fulanoDeTal.Equals(menganoDeTal);
            Assert.IsFalse(sonIguales);
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void UsuarioMuyMayor()
        {
            fulanoDeTal.FechaNacimiento = new DateTime(1930, 04, 10);
        }

        [TestMethod]
        public void UsuarioConEdadCorrecta()
        {
            fulanoDeTal.FechaNacimiento = fechaNacimiento;
        }

        [TestMethod]
        public void SetImagenDePerfil()
        {
            fulanoDeTal.PicturePath = pathDeImagen;
            Assert.AreEqual(pathDeImagen, fulanoDeTal.PicturePath);
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void SetImagenConPathMuyLargo()
        {
            string pathMuyLargo = GenerarStringLargo("a", Usuario.PathMaximo + 1);
            string pathInvalido = pathMuyLargo;
            fulanoDeTal.PicturePath = pathInvalido;
        }

        [TestMethod]
        public void SetAdministrador()
        {
            fulanoDeTal.Administrador = true;
            Assert.IsTrue(fulanoDeTal.Administrador);
        }

        [TestMethod]
        public void EsAdministrador()
        {
            Assert.IsFalse(fulanoDeTal.Administrador);
        }

        [TestMethod]
        public void LogearUsuario()
        {
            fulanoDeTal.Logeado = true;
            Assert.IsTrue(fulanoDeTal.Logeado);
        }

        [TestMethod]
        public void EstaLogeado()
        {
            Assert.IsFalse(fulanoDeTal.Logeado);
        }

        [TestMethod]
        public void SetContrasena()
        {
            fulanoDeTal.Contrasena = "Contrasenia";
            Assert.IsTrue(Equals(Hash("Contrasenia"), fulanoDeTal.Contrasena));
        }

        [TestMethod]
        public void ContrasenaIncorrecta()
        {
            fulanoDeTal.Contrasena = "Contrasenia";
            Assert.IsFalse(Equals("Contrasenia", fulanoDeTal.Contrasena));
        }

        [TestMethod]
        public void GetListaSeguidos()
        {
            Assert.IsTrue(fulanoDeTal.Seguidos.Count == 0);
        }

        [TestMethod]
        public void FulanoSigueAMengano()
        {
            fulanoDeTal.SeguirA(menganoDeTal);
            Assert.IsTrue(fulanoDeTal.SigueA(menganoDeTal));
        }

        [TestMethod]
        public void CantidadDeSeguidos()
        {
            fulanoDeTal.SeguirA(menganoDeTal);
            Assert.IsTrue(fulanoDeTal.Seguidos.Count == 1);
        }

        [TestMethod]
        public void CantidadDeSeguidosDespuesDeBorrar()
        {
            fulanoDeTal.SeguirA(menganoDeTal);
            fulanoDeTal.DejarDeSeguirA(menganoDeTal);
            Assert.IsTrue(fulanoDeTal.Seguidos.Count == 0);
        }

        [TestMethod]
        public void GetNombreUsuario()
        {
            Assert.IsTrue(Equals(fulanoDeTal.Nombre, Fulano));
        }

        [TestMethod]
        public void GetApellidoUsuario()
        {
            Assert.IsTrue(Equals(fulanoDeTal.Apellido, DeTal));
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void SetApellidoLargo()
        {
            string apellidoMuyLargo = GenerarStringLargo("a", ApellidoLargoMaximo + 1);
            string apellidoInvalido = apellidoMuyLargo;
            fulanoDeTal.Apellido = apellidoInvalido;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetApellidoNull()
        {
            fulanoDeTal.Apellido = null;
        }

        [TestMethod]
        public void GetNombreDeUsuariodeUsuario()
        {
            Assert.IsTrue(Equals(fulanoDeTal.NombreUsuario, fulanito));
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void SetNombreUsuarioLargo()
        {
            string nombreUsuarioLargo = GenerarStringLargo("a", UsuarioLargoMaximo + 1);
            string nombreUsuarioInvalido = nombreUsuarioLargo;
            fulanoDeTal.NombreUsuario = nombreUsuarioInvalido;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetNombreUsuarioNull()
        {
            fulanoDeTal.NombreUsuario = null;
        }

        [TestMethod]
        public void GetFechaNacimientoUsuario()
        {
            Assert.IsTrue(Equals(fulanoDeTal.FechaNacimiento, fechaNacimiento));
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