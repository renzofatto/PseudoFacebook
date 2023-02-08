using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;
using System;
using System.Collections.Generic;

namespace Dominio.Test
{
    [TestClass]
    public class ManejoCredencialesTest
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
            usuariosRegistrados.Add(nicolasVarela);
            misDatos.UsuariosRegistrados = usuariosRegistrados;
        }

        [TestMethod]
        public void GetInicioSesion()
        {
            Assert.IsTrue(ManejoCredeciales.InicioSesion(nicoGamer, "AmoElRugby", misDatos));
        }

        [TestMethod]
        public void GetIncorrectoInicioSesion()
        {
            Assert.IsFalse(ManejoCredeciales.InicioSesion(nicoGamer, "otraContrasenalarga", misDatos));
        }

        [TestMethod]
        public void RegistrarUsuario()
        {
            ManejoCredeciales.RegistrarUsuario(misDatos, mathiasCastiñeiras);
            Assert.IsTrue(misDatos.UsuariosRegistrados.Count == 2);
        }
    }
}
