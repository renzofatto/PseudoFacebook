using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatorioDisenoDeAplicaciones;
using System;
using System.Collections.Generic;

namespace Dominio.Test
{
    [TestClass]
    public class FuncionListaTest
    {
        private List<Usuario> usuariosRegistrados = new List<Usuario>();
        private Usuario mathiasCastiñeiras;
        private string mathias = "Mathias";
        private string castiñeiras = "Castiñeiras";
        private string mathiCasti = "MathiCasti";
        private DateTime fecha = new DateTime(1998, 7, 6);
        private const string pathDeImagen = @"Resources\test-image.jpg";
        private Usuario nicolasVarela;
        private string nicolas = "Nicolas";
        private string varela = "Varela";
        private string nicoGamer = "NicoGamer";
        private Usuario renzoFattorini;
        private string renzo = "Renzo";
        private string fattorini = "Fattorini";
        private string renzoBolso = "RenzoBolso";
        private Datos misDatos = new Datos();
        private Album albumMathiInvierno;
        private Album albumMathiVerano;
        private Album albumNicoRugby;
        private Album albumMathiFutbol;
        
        private Estado estadoNicoRugby;
        private Estado estadoMathiFutbol;
        private Estado estadoNicoCumpleanos;

        private Escuchando escuchandoNicoShakira;
        private Escuchando escuchandoMathiRombai;
        private Escuchando escuchandoNicoEmiMernes;

        private Juego fifa21;
        private Juego nba2k21;


        [TestInitialize]
        public void Initialize()
        {
            mathiasCastiñeiras = new Usuario
            {
                Nombre = mathias,
                Apellido = castiñeiras,
                NombreUsuario = mathiCasti,
                FechaNacimiento = fecha,
                PicturePath = pathDeImagen,
                DireccionPersona = new Direccion()
                {
                    Pais = "Uruguay",
                    Ciudad = "Montevideo",
                    Calle = "Cuareim",
                },
                Contrasena = "vamoMathi17"
            };
            nicolasVarela = new Usuario
            {
                Nombre = nicolas,
                Apellido = varela,
                NombreUsuario = nicoGamer,
                FechaNacimiento = fecha,
                PicturePath = pathDeImagen,
                DireccionPersona = new Direccion()
                {
                    Pais = "Uruguay",
                    Ciudad = "Montevideo",
                    Calle = "Cuareim",
                },
                Contrasena = "AmoElRugby"
            };
            renzoFattorini = new Usuario
            {
                Nombre = renzo,
                Apellido = fattorini,
                NombreUsuario = renzoBolso,
                FechaNacimiento = fecha,
                PicturePath = pathDeImagen,
                DireccionPersona = new Direccion()
                {
                    Pais = "Uruguay",
                    Ciudad = "Montevideo",
                    Calle = "Cuareim",
                },
                Contrasena = "123456789"
            };
            usuariosRegistrados.Add(mathiasCastiñeiras);
            usuariosRegistrados.Add(nicolasVarela);
            usuariosRegistrados.Add(renzoFattorini);

            fifa21 = new Juego
            {
                Titulo = "Fifa 21",
                Categoria = "Deportes"
            };
            nba2k21 = new Juego
            {
                Titulo = "NBA 2k21",
                Categoria = "Deportes"
            };
            fifa21.Jugar(45, mathiasCastiñeiras);
            fifa21.Jugar(50, nicolasVarela);
            fifa21.Jugar(70, nicolasVarela);
            nba2k21.Jugar(6, nicolasVarela);
            nba2k21.Jugar(90, mathiasCastiñeiras);
            List<Jugada> jugadasNba2k21 = nba2k21.TodasLasJugadas();
            jugadasNba2k21[0].FechaCreacion = new DateTime(1998, 3, 3);
            jugadasNba2k21[1].FechaCreacion = new DateTime(2000, 3, 3);
            List<Jugada> jugadasFifa21 = fifa21.TodasLasJugadas();
            jugadasFifa21[0].FechaCreacion = new DateTime(1996, 3, 3);
            jugadasFifa21[1].FechaCreacion = new DateTime(1997, 3, 3);
            jugadasFifa21[2].FechaCreacion = new DateTime(1990, 3, 3);

            misDatos.JuegosCreados.Add(fifa21);
            misDatos.JuegosCreados.Add(nba2k21);

            albumMathiInvierno = new Album(mathiasCastiñeiras);
            albumMathiInvierno.NombreAlbum = "Invierno 2020";
            mathiasCastiñeiras.Albumes.Add(albumMathiInvierno);
            albumMathiInvierno.FechaCreacion= new DateTime (1990, 2, 2);

            albumMathiVerano = new Album(mathiasCastiñeiras);
            albumMathiVerano.NombreAlbum = "Verano 2020";
            mathiasCastiñeiras.Albumes.Add(albumMathiVerano);
            albumMathiVerano.FechaCreacion = new DateTime(1991, 2, 2);

            albumNicoRugby = new Album(nicolasVarela);
            albumNicoRugby.NombreAlbum = "Rugby";
            nicolasVarela.Albumes.Add(albumNicoRugby);
            albumNicoRugby.FechaCreacion = new DateTime(1994, 2, 2);

            albumMathiFutbol = new Album(mathiasCastiñeiras);
            albumMathiFutbol.NombreAlbum = "Futbol";
            mathiasCastiñeiras.Albumes.Add(albumMathiFutbol);
            albumMathiFutbol.FechaCreacion = new DateTime(2000, 2, 2);

            estadoNicoRugby = new Estado(nicolasVarela, "Amo el Rugby <3");
            nicolasVarela.Estados.Add(estadoNicoRugby);
            estadoNicoRugby.FechaCreacion = new DateTime(1991, 2, 2);

            estadoMathiFutbol = new Estado(mathiasCastiñeiras, "Amo el Futbol <3");
            mathiasCastiñeiras.Estados.Add(estadoMathiFutbol);
            estadoMathiFutbol.FechaCreacion = new DateTime(1999, 2, 2);

            estadoNicoCumpleanos = new Estado(nicolasVarela, "Feliz cumple amigo!");
            nicolasVarela.Estados.Add(estadoNicoCumpleanos);
            estadoNicoCumpleanos.FechaCreacion = new DateTime(2019, 2, 2);

            escuchandoNicoShakira = new Escuchando(nicolasVarela,"Waka-Waka-E-E", "Shakira", "Mundial 2010");
            nicolasVarela.Escuchadas.Add(escuchandoNicoShakira);
            escuchandoNicoShakira.FechaCreacion = new DateTime(1991, 2, 2);

            escuchandoMathiRombai = new Escuchando( mathiasCastiñeiras, "Yo tambien", "Rombai", "Aguante Rombai");
            mathiasCastiñeiras.Escuchadas.Add(escuchandoMathiRombai);
            escuchandoMathiRombai.FechaCreacion = new DateTime(2000, 2, 2);

            escuchandoNicoEmiMernes = new Escuchando(nicolasVarela, "Se me recalienta", "Emilia Mernes", "Te amo Emilia");
            nicolasVarela.Escuchadas.Add(escuchandoNicoEmiMernes);
            escuchandoNicoEmiMernes.FechaCreacion = new DateTime(2019, 2, 2);

            renzoFattorini.SeguirA(mathiasCastiñeiras);
            renzoFattorini.SeguirA(nicolasVarela);

            renzoFattorini.Logeado = true;

            misDatos.UsuariosRegistrados.Add(renzoFattorini);
            misDatos.UsuariosRegistrados.Add(mathiasCastiñeiras);
            misDatos.UsuariosRegistrados.Add(nicolasVarela);

            misDatos.usuarioLogeado = renzoFattorini;
        }

        [TestMethod]
        public void GetContieneUsuario()
        {
            Assert.IsTrue(ManejadorListas.ContieneUsuario(usuariosRegistrados, mathiasCastiñeiras.NombreUsuario));
        }

        [TestMethod]
        public void GetIncorrectoContieneUsuario()
        {
            Assert.IsFalse(ManejadorListas.ContieneUsuario(usuariosRegistrados, "Renzo"));
        }

        [TestMethod]
        public void GetUsuario()
        {
            Assert.IsTrue(Equals(ManejadorListas.GetUsuario(usuariosRegistrados, mathiasCastiñeiras.NombreUsuario),mathiasCastiñeiras));
        }

        [TestMethod]
        public void GetIncorrectoUsuario()
        {
            Assert.IsFalse(Equals(ManejadorListas.GetUsuario(usuariosRegistrados, mathiasCastiñeiras.NombreUsuario), nicolasVarela));
        }

        [TestMethod]
        public void GetAlbumesUnidos() 
        {   
            Assert.IsTrue(ManejadorListas.UnirAlbumesDeUsuarios(misDatos.usuarioLogeado.Seguidos).Count == 4);
        }

        [TestMethod]
        public void GetAlbumReciente()
        {
            Assert.IsTrue(ManejadorListas.AlbumMasNuevo(ManejadorListas.UnirAlbumesDeUsuarios(misDatos.usuarioLogeado.Seguidos)) == albumMathiFutbol);
        }

        [TestMethod]
        public void GetListaOrdenadaDeAlbumes()
        {
            Assert.IsTrue(ManejadorListas.OrdenarAlbumesSeguidos(misDatos)[0] == albumMathiFutbol);
        }

        [TestMethod]
        public void GetSegundoAlbumOrdenado()
        {
            Assert.IsTrue(ManejadorListas.OrdenarAlbumesSeguidos(misDatos)[1] == albumNicoRugby);
        }

        [TestMethod]
        public void GetEstadoUnidos()
        {
            Assert.IsTrue(ManejadorListas.UnirEstadosDeUsuarios(misDatos.usuarioLogeado.Seguidos).Count == 3);
        }

        [TestMethod]
        public void GetEstadoReciente()
        {
            Assert.IsTrue(ManejadorListas.EstadoMasNuevo(ManejadorListas.UnirEstadosDeUsuarios(misDatos.usuarioLogeado.Seguidos)) == estadoNicoCumpleanos);
        }

        [TestMethod]
        public void GetListaOrdenadaDeEstados()
        {
            Assert.IsTrue(ManejadorListas.OrdenarEstadoSeguidos(misDatos)[0] == estadoNicoCumpleanos);
        }

        [TestMethod]
        public void GetSegundoEstadoOrdenado()
        {
            Assert.IsTrue(ManejadorListas.OrdenarEstadoSeguidos(misDatos)[1] == estadoMathiFutbol);
        }

        [TestMethod]
        public void GetEscuchadasUnidas()
        {
            Assert.IsTrue(ManejadorListas.UnirEscuchandoDeUsuarios(misDatos.usuarioLogeado.Seguidos).Count == 3);
        }

        [TestMethod]
        public void GetEscuchandoReciente()
        {
            Assert.IsTrue(ManejadorListas.EscuchandoMasNuevo(ManejadorListas.UnirEscuchandoDeUsuarios(misDatos.usuarioLogeado.Seguidos)) == escuchandoNicoEmiMernes);
        }

        [TestMethod]
        public void GetListaOrdenadaDeEscuchadas()
        {
            Assert.IsTrue(ManejadorListas.OrdenarEscuchandoSeguidos(misDatos)[0] == escuchandoNicoEmiMernes);
        }

        [TestMethod]
        public void GetSegundoEscuchadoOrdenado()
        {
            Assert.IsTrue(ManejadorListas.OrdenarEscuchandoSeguidos(misDatos)[1] == escuchandoMathiRombai);
        }

        [TestMethod]
        public void GetJugadasUnidas()
        {
            Assert.IsTrue(ManejadorListas.UnirJugadasDeJuegos(misDatos.JuegosCreados).Count == 5);
        }

        [TestMethod]
        public void GetJugadaReciente()
        {
            Assert.IsTrue(ManejadorListas.JugadaMasNueva(ManejadorListas.JugadasSeguidos(misDatos)).Puntaje == 90);
        }
    }
}
