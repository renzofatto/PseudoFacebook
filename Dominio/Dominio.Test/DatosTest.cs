using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;
using System;
using System.Collections.Generic;

namespace Dominio.Test
{
    
    [TestClass]
    public class DatosTest
    {
        private Datos misDatos = new Datos();
        private List<Usuario> usuariosRegistrados = new List<Usuario>();
        private Usuario mathiasCastiñeiras;
        private string mathias = "Mathias";
        private string castiñeiras = "Castiñeiras";
        private string mathiCasti = "MathiCasti";
        private DateTime fecha = new DateTime(1998, 7, 6);
        private const string pathDeImagen = @"Resources\test-image.jpg";
        private Usuario nicolasVarela;
        private string nicolas = "Nicolas";
        private string varela = "Varela";
        private string nicoGamer = "NicoGamer";

        [TestInitialize]
        public void Initialize()
        {
            mathiasCastiñeiras = new Usuario
            {
                Nombre = mathias,
                Apellido = castiñeiras,
                NombreUsuario = mathiCasti,
                FechaNacimiento = fecha,
                PicturePath = pathDeImagen,
                DireccionPersona = new Direccion()
                {
                    Pais = "Uruguay",
                    Ciudad = "Montevideo",
                    Calle = "Cuareim",
                },
                Contrasena = "vamoMathi17"
            };
            nicolasVarela = new Usuario
            {
                Nombre = nicolas,
                Apellido = varela,
                NombreUsuario = nicoGamer,
                FechaNacimiento = fecha,
                PicturePath = pathDeImagen,
                DireccionPersona = new Direccion()
                {
                    Pais = "Uruguay",
                    Ciudad = "Montevideo",
                    Calle = "Cuareim",
                },
                Contrasena = "AmoElRugby"
            };
            usuariosRegistrados.Add(mathiasCastiñeiras);
            usuariosRegistrados.Add(nicolasVarela);
            misDatos.UsuariosRegistrados = usuariosRegistrados;
        }

        [TestMethod]
        public void GetPrimerUsuarioRegistrado()
        {
            Assert.AreEqual(misDatos.UsuariosRegistrados[0], mathiasCastiñeiras);
        }

        [TestMethod]
        public void GetIncorrectoPrimerUsuarioRegistrado()
        {
            Assert.AreNotEqual(misDatos.UsuariosRegistrados[0], nicolasVarela);
        }
        
        [TestMethod]
        public void GetJuegosCreados()
        {
            Assert.IsTrue(misDatos.JuegosCreados.Count == 0 );
        }

        [TestMethod]
        public void SetJuegoCreado()
        {
            Juego nuevoJuego = new Juego();
            misDatos.JuegosCreados.Add(nuevoJuego);
            Assert.IsTrue(misDatos.JuegosCreados.Count == 1);
        }
    }
}
