using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;
using System;

namespace Dominio.Test
{
    [TestClass]
    public class FuncionHashTest
    {
        private const string contrasenaCorta = "Hola";
        private const string contrasena = "LaM3J0RC0N7R423n14";

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void ContrasenaCorta()
        {
            FuncionHash.Hash(contrasenaCorta, 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ContrasenaNull()
        {
            FuncionHash.Hash(null, 1000);
        }

        [TestMethod]
        public void GetHash()
        {
            Assert.IsFalse(Equals(contrasena, FuncionHash.Hash(contrasena, 1000)));
        }


    }
}
