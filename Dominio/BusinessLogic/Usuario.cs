using Dominio;
using System;
using System.Collections.Generic;

namespace ObligatorioDisenoDeAplicaciones
{
    public class Usuario: IEquatable <Usuario>
    {
        private const int NombreLargoMinimo = 2;
        private const int NombreLargoMaximo = 30;
        private const int ApellidoLargoMinimo = 2;
        private const int ApellidoLargoMaximo = 30;
        private const int UsuarioLargoMinimo = 2;
        private const int UsuarioLargoMaximo = 30;
        public const int PathMaximo = 260;
        private DateTime fechaMasAntigua = new DateTime(1940, 12, 31);

        private DateTime fechaNacimiento;
        private string nombreUsuario;
        private string nombre;
        private string apellido;
        private string contrasena;
        private bool administrador = false;
        private bool logeado = false;
        private Libro seguidos = new Libro();
        private Uri pathImagen;
        private Direccion direccion;

        public Usuario()
        {
        }
        public string Nombre
        {
            get => nombre;
            set
            {
                if (value?.Length < NombreLargoMinimo || value?.Length > NombreLargoMaximo)
                {
                    throw new DominioException($"El nombre tiene que tener entre {NombreLargoMinimo} y {NombreLargoMaximo} caracteres");
                }
                nombre = value ?? throw new ArgumentNullException("El nombre no puede ser null");
            }
        }
        public string Apellido
        {
            get => apellido;
            set
            {
                if (value?.Length < ApellidoLargoMinimo || value?.Length > ApellidoLargoMaximo)
                {
                    throw new DominioException($"El apellido tiene que tener entre {ApellidoLargoMinimo} y {ApellidoLargoMaximo} caracteres");
                }
                apellido = value ?? throw new ArgumentNullException("El apellido no puede ser null");
            }
        }
        public string NombreUsuario
        {
            get => nombreUsuario;
            set
            {
                if (value?.Length < UsuarioLargoMinimo || value?.Length > UsuarioLargoMaximo)
                {
                    throw new DominioException($"El nombre de usuario tiene que tener entre {UsuarioLargoMinimo} y {UsuarioLargoMaximo} caracteres");
                }
                nombreUsuario = value ?? throw new ArgumentNullException("El nombre de usuario no puede ser null");
            }
        }
        public Direccion DireccionPersona 
        { 
            get=> direccion; 
            set=> direccion = value; 
        }
        public bool Administrador 
        { 
            get => administrador; 
            set => administrador = value; 
        }
        public bool Logeado 
        { 
            get=>logeado; 
            set=>logeado=value; 
        }
        public IList<Usuario> Seguidos
        {
            get => seguidos.TodosLosUsuarios();
        }
        public void SeguirA (Usuario perfil)
        {
            if (!seguidos.Contiene(perfil)) 
            { 
                seguidos.Agregar(perfil); 
            }
        }
        public void DejarDeSeguirA (Usuario perfil)
        {
            if (seguidos.Contiene(perfil))
            {
                seguidos.Borrar(perfil);
            }
        }
        public bool SigueA (Usuario perfil)
        {
            return (seguidos.Contiene(perfil));
        }
        public DateTime FechaNacimiento
        {
            get => fechaNacimiento;
            set
            {
                if (value.Year < fechaMasAntigua.Year)
                {
                    throw new DominioException($"Solo se permiten fechas de nacimiento posteriores a {fechaMasAntigua.Year}");
                }
                fechaNacimiento = value;
            }
        }
        public string PicturePath
        {
            get => pathImagen.OriginalString;
            set
            {
                if (value?.Length > PathMaximo)
                {
                    throw new DominioException($"Profile picture path is too long. Maximum length is {PathMaximo}");
                }
                pathImagen = new Uri(value, UriKind.RelativeOrAbsolute);
            }
        }
        public string Contrasena 
        {
            get => contrasena;
            set => contrasena = FuncionHash.Hash(value,1000);
        }
        public bool Equals(Usuario otro) => otro != null && otro.nombreUsuario.Equals(this.nombreUsuario);
    }
}