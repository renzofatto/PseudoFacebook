using DataAccess;
using ObligatorioDisenoDeAplicaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObligatorioUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Datos datosDelSistema = new Datos();
            ILibro dbUsers = new DBUsers();
            IPublicaciones dBPublicaciones = new DBPublicaciones();
            Usuario admin2 = new Usuario()
            {
                Administrador = true,
                Nombre = "Administrador",
                Apellido = "Admin",
                NombreUsuario = "admin2",
                Contrasena = "adminadmin",
                PicturePath = "fotoadmin",
                DireccionPersona = new Dominio.Direccion() { Pais = "admin", Ciudad = "admin", Calle = "admin" },
            };

            Usuario admin = new Usuario()
            {
                Administrador = true,
                Nombre = "Administrador",
                Apellido = "Admin",
                NombreUsuario = "admin",
                Contrasena = "adminadmin",
                PicturePath = "fotoadmin",
                DireccionPersona = new Dominio.Direccion() { Pais = "admin", Ciudad = "admin", Calle = "admin" },
            };
            datosDelSistema.UsuariosRegistrados.Add(admin);
            //dbUsers.Agregar(admin);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VentanaLogin(datosDelSistema,dbUsers, dBPublicaciones));
        }
    }
}
