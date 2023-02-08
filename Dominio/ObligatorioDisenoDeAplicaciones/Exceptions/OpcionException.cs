using System;

namespace ObligatorioDisenoDeAplicaciones
{
    [Serializable]
    public class OpcionException : Exception
    {
        public OpcionException(string message) : base(message)
        {
        }
    }
}