using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dominio.Test

{
    [TestClass]
    public class DireccionTest
    {
        private const string Uruguay = "Uruguay";
        private const string Montevideo = "Montevideo";
        private const string AvItalia = "Avenida Italia";
        private Direccion direccion;

        [TestInitialize]
        public void Initialize()
        {
            direccion = new Direccion()
            {
                Pais = Uruguay,
                Ciudad = Montevideo,
                Calle = AvItalia,
            };
        }

        [TestMethod]
        public void MismoPais()
        {
            Assert.AreEqual(Uruguay, direccion.Pais);
        }

        [TestMethod]
        public void MismaCiudad()
        {
            Assert.AreEqual(Montevideo, direccion.Ciudad);
        }

        [TestMethod]
        public void MismaCalle()
        {
            Assert.AreEqual(AvItalia, direccion.Calle);
        }

        [TestMethod]
        public void DireccionesDiferentes()
        {
            Direccion nuevaDireccion = new Direccion()
            {
                Pais = "Argentina",
                Ciudad = "Buenos Aires",
                Calle = "18 de Julio",
            };
            Assert.AreNotEqual(nuevaDireccion, direccion);
        }

        [TestMethod]
        [ExpectedException(typeof(DireccionException))]
        public void PaisMuyCorto()
        {
            direccion.Pais = "U";
        }

        [TestMethod]
        [ExpectedException(typeof(DireccionException))]
        public void DireccionIncorrectaCiudadCorta()
        {
            direccion.Ciudad = "M";
        }

        [TestMethod]
        [ExpectedException(typeof(DireccionException))]
        public void DireccionIncorrectaCalleCorto()
        {
            direccion.Calle = "C";
        }

        [TestMethod]
        [ExpectedException(typeof(DireccionException))]
        public void DireccionIncorrectaPaisLargo()
        {
            direccion.Pais = "UruguayPeroMuyLargoDeMuchosPeroMuchosCaracteresParaQueDeError";
        }

        [TestMethod]
        [ExpectedException(typeof(DireccionException))]
        public void DireccionIncorrectaCiudadLarga()
        {
            direccion.Ciudad = "MontevideoPeroMuyLargoDeMuchosPeroMuchosCaracteresParaQueDeError";
        }

        [TestMethod]
        [ExpectedException(typeof(DireccionException))]
        public void DireccionIncorrectaCalleLarga()
        {
            direccion.Calle = "CuareimPeroMuyLargoDeMuchosPeroMuchosCaracteresParaQueDeError";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DireccionIncorrectaPaisVacio()
        {
            direccion.Pais = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DireccionIncorrectaCiudadVacia()
        {
            direccion.Ciudad = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DireccionIncorrectaCalleVacia()
        {
            direccion.Calle = null;
        }
    }
}
