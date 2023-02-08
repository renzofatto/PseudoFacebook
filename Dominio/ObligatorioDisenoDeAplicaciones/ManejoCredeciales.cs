using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ObligatorioDisenoDeAplicaciones
{
    public abstract class ManejoCredeciales
    {
        public static bool InicioSesion(string nombreUsuario, string contrasena, Datos datos, ILibro baseDeUsuarios)
        {
            bool credencialesValidas = false;
            if (ContieneUsuario(baseDeUsuarios.GetAll().ToList(), (nombreUsuario)))
            {
                Usuario usuarioAVerificar = GetUsuario(baseDeUsuarios.GetAll().ToList(), nombreUsuario);
                if (verificarCredenciales(usuarioAVerificar, contrasena))
                {
                    credencialesValidas = true;
                    usuarioAVerificar.Logeado = true;
                    datos.usuarioLogeado = usuarioAVerificar;
                }
            }
            return credencialesValidas;
        }

        private static bool verificarCredenciales(Usuario usuario, string contrasena)
        {
            bool verifica = false;
            string contrasenaHash = FuncionHash.Hash(FuncionHash.Hash(contrasena));
            if (contrasenaHash.Equals(usuario.Contrasena)) 
            {
                verifica = true;
            }
            return verifica;
        }

        public static bool ContieneUsuario(List<Usuario> usuariosRegistrados, string nombreUsuario)
        {
            bool contiene = false;
            foreach (var usuario in usuariosRegistrados)
            {
                if (usuario.NombreUsuario.Equals(nombreUsuario))
                {
                    contiene = true;
                }
            }
            return contiene;
        }


        public static Usuario GetUsuario(List<Usuario> usuariosRegistrados, string nombreUsuario)
        {
            Usuario usuarioEncontrado = null;
            foreach (var usuario in usuariosRegistrados)
            {
                if (usuario.NombreUsuario.Equals(nombreUsuario))
                {
                    usuarioEncontrado = usuario;
                }
            }
            return usuarioEncontrado;
        }

        public static void RegistrarUsuario(Datos datos, Usuario usuarioARegistrar)
        {
            datos.UsuariosRegistrados.Add(usuarioARegistrar);
        }

        public static bool ContrasenaChequeoRegexLetrasYNumeros(string palabra) {
            return Regex.IsMatch(palabra, @"[A-Za-z][A-Za-z0-9]{7}");
        }
        
        public static bool ChequeoRegexLetrasYNumeros(string palabra)
        {
            return Regex.IsMatch(palabra, @"[A-Za-z][A-Za-z0-9]{2}");
        }

        public static bool ChequeoPalabraNotNull(string palabra) {
            return string.IsNullOrEmpty(palabra);
        }

        public static List<Usuario> BuscarUsuariosPorId(List<int> usuariosId, ILibro baseDeUsuarios)
        {
            List<Usuario> listaDeRetorno = new List<Usuario>();
            foreach (var id in usuariosId)
            {
                foreach (var usuario in baseDeUsuarios.GetAll())
                {
                    if (id == usuario.Id_Usuario)
                    {
                        listaDeRetorno.Add(usuario);
                    }
                }
            }
            return listaDeRetorno;
        }
    }
}
