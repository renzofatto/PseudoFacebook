using System;
using System.Runtime.Serialization;

namespace ObligatorioDisenoDeAplicaciones
{
    [Serializable]
    public class JuegoException : Exception
    {
        public JuegoException(string message) : base(message)
        {
        }
    }
}