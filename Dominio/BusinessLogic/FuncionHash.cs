using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDisenoDeAplicaciones
{
    public class FuncionHash
    {
        private const int TamanoSalt = 16;
        private const int TamanoHash = 20;
        private const int ContrasenaLargoMinimo = 8;

        public static string Hash (string contrasena, int iteraciones = 1000)
        {
            if (contrasena?.Length < ContrasenaLargoMinimo)
            {
                throw new DominioException($"La contrasena del usuario tiene que tener mas de {ContrasenaLargoMinimo} caracteres");
            }
            if (contrasena == null)
            { 
                throw new ArgumentNullException("La contrasena del usuario no puede ser null");
            }
            byte[] salt = new byte[TamanoSalt]; 
            var pbkdf2 = new Rfc2898DeriveBytes(contrasena, salt, iteraciones);
            var hash = pbkdf2.GetBytes(TamanoHash);
            var hashedBase46String = Convert.ToBase64String(hash);

            return hashedBase46String;
        }
    }
}
