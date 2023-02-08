using System;

namespace Dominio
{
    [Serializable]
    public class PublicacionException : Exception
    {
        public PublicacionException(string message) : base(message)
        {
        }
    }
}
