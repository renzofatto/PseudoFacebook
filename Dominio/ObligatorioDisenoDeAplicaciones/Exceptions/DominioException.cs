using System;
using System.Runtime.Serialization;

namespace Dominio
{
    [Serializable]
    public class DominioException : Exception
    {
        public DominioException(string message) : base(message)
        {
        }
    }
}