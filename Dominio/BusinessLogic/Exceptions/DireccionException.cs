using System;

namespace Dominio
{
    [Serializable]
    public class DireccionException : Exception
    {
        public DireccionException(string message) : base(message)
        {
        }
    }
}
