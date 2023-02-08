using System;
using System.Runtime.Serialization;

namespace ObligatorioDisenoDeAplicaciones
{
    [Serializable]
    public class EncuestaException : Exception
    {
        public EncuestaException(string message) : base(message)
        {
        }
    }
}