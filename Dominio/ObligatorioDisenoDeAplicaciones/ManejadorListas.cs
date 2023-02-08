using ObligatorioDisenoDeAplicaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio

{
    public class ManejadorListas
    {
        public static List<Album> OrdenarAlbumesSeguidos(Datos datos)
        {
            List<Album> retorno = new List<Album>();
            IList<Usuario> seguidos = datos.usuarioLogeado.Seguidos;
            List<Album> albumesDeSeguidos = new List<Album>(UnirAlbumesDeUsuarios(seguidos));
            for (var i = 0; i < albumesDeSeguidos.Count; i++)
            {
                retorno.Add(AlbumMasNuevo(albumesDeSeguidos));
                EliminarAlbumDeLista(retorno[i].NombreAlbum, albumesDeSeguidos);
            }
            
            return retorno;
        }

        public static Album AlbumMasNuevo(List<Album> albumes)
        {
            Album masNuevo = albumes[0];
            foreach (var album in albumes)
            {
                if (album.FechaCreacion > masNuevo.FechaCreacion)
                {
                    masNuevo = album;
                }
            }
            return masNuevo;
        }

        public static List<Album> UnirAlbumesDeUsuarios(IList<Usuario> usuarios)
        {
            List<Album> retorno = new List<Album>();
            foreach (var usuario in usuarios)
            {
                foreach (var album in usuario.Albumes)
                {
                    retorno.Add(album);
                }
            }
            return retorno;
        }

        public static void EliminarAlbumDeLista (string eliminarNombre, List<Album> albumes) 
        {
            bool encontre = false;
            for (var i = 0; i<albumes.Count && !encontre; i++)
            {
                if(albumes[i].NombreAlbum == eliminarNombre)
                {
                    encontre = true;
                    albumes.Remove(albumes[i]);
                }
            }
            
        }

        public static List<Estado> OrdenarEstadoSeguidos(Datos datos)
        {
            List<Estado> retorno = new List<Estado>();
            IList<Usuario> seguidos = datos.usuarioLogeado.Seguidos;
            List<Estado> estadosDeSeguidos = new List<Estado>(UnirEstadosDeUsuarios(seguidos));
            for (var i = 0; i < estadosDeSeguidos.Count; i++)
            {
                retorno.Add(EstadoMasNuevo(estadosDeSeguidos));
                EliminarEstadoDeLista(retorno[i], estadosDeSeguidos);
            }
            return retorno;
        }

        public static Estado EstadoMasNuevo(List<Estado> estados)
        {
            Estado masNuevo = estados[0];
            foreach (var estado in estados)
            {
                if (estado.FechaCreacion > masNuevo.FechaCreacion)
                {
                    masNuevo = estado;
                }
            }
            return masNuevo;
        }

        public static List<Estado> UnirEstadosDeUsuarios(IList<Usuario> usuarios)
        {
            List<Estado> retorno = new List<Estado>();
            foreach (var usuario in usuarios)
            {
                foreach (var estado in usuario.Estados)
                {
                    retorno.Add(estado);
                }
            }
            return retorno;
        }

        public static void EliminarEstadoDeLista(Estado estadoEliminar, List<Estado> estados)
        {
            bool encontre = false;
            for (var i = 0; i < estados.Count && !encontre; i++)
            {
                if (estados[i] == estadoEliminar)
                {
                    encontre = true;
                    estados.Remove(estados[i]);
                }
            }
        }

        public static List<Escuchando> OrdenarEscuchandoSeguidos(Datos datos)
        {
            List<Escuchando> retorno = new List<Escuchando>();
            IList<Usuario> seguidos = datos.usuarioLogeado.Seguidos;
            List<Escuchando> escuchadasDeSeguidos = new List<Escuchando>(UnirEscuchandoDeUsuarios(seguidos));
            for (var i = 0; i < escuchadasDeSeguidos.Count; i++)
            {
                retorno.Add(EscuchandoMasNuevo(escuchadasDeSeguidos));
                EliminarEscuchandoDeLista(retorno[i], escuchadasDeSeguidos);
            }
            return retorno;
        }

        public static Escuchando EscuchandoMasNuevo(List<Escuchando> escuchadas)
        {
            Escuchando masNuevo = escuchadas[0];
            foreach (var escuchando in escuchadas)
            {
                if (escuchando.FechaCreacion > masNuevo.FechaCreacion)
                {
                    masNuevo = escuchando;
                }
            }
            return masNuevo;
        }

        public static List<Escuchando> UnirEscuchandoDeUsuarios(IList<Usuario> usuarios)
        {
            List<Escuchando> retorno = new List<Escuchando>();
            foreach (var usuario in usuarios)
            {
                foreach (var escuchando in usuario.Escuchadas)
                {
                    retorno.Add(escuchando);
                }
            }
            return retorno;
        }

        public static void EliminarEscuchandoDeLista(Escuchando escuchandoEliminar, List<Escuchando> escuchadas)
        {
            bool encontre = false;
            for (var i = 0; i < escuchadas.Count && !encontre; i++)
            {
                if (escuchadas[i] == escuchandoEliminar)
                {
                    encontre = true;
                    escuchadas.Remove(escuchadas[i]);
                }
            }
        }

        public static void EliminarJugadaDeLista(Jugada jugadaEliminar, List<Jugada> jugadas)
        {
            bool encontre = false;
            for (var i = 0; i < jugadas.Count && !encontre; i++)
            {
                if (jugadas[i] == jugadaEliminar)
                {
                    encontre = true;
                    jugadas.Remove(jugadas[i]);
                }
            }
        }

        public static List<Jugada> UnirJugadasDeJuegos(IList<Juego> juegos)
        {
            List<Jugada> retorno = new List<Jugada>();
            foreach (var juego in juegos)
            {
                foreach (var jugada in juego.TodasLasJugadas())
                {
                    retorno.Add(jugada);
                }
            }
            return retorno;
        }

        public static Jugada JugadaMasNueva(List<Jugada> jugadas)
        {
            Jugada masNueva = jugadas[0];
            foreach (var jugada in jugadas)
            {
                if (jugada.FechaCreacion > masNueva.FechaCreacion)
                {
                    masNueva = jugada;
                }
            }
            return masNueva;
        }

        public static List<Jugada> JugadasDe(Usuario perfil, List<Jugada> jugadas)
        {
            List<Jugada> retorno = new List<Jugada>();
            foreach (var jugada in jugadas)
            {
                if (Equals(jugada.Jugador, perfil))
                {
                    retorno.Add(jugada);
                }
            }
            return retorno;
        }

        public static List<Jugada> JugadasSeguidos(Datos datos)
        {
            IList<Usuario> seguidos = datos.usuarioLogeado.Seguidos;
            List<Jugada> jugadasDeSeguidos = new List<Jugada>();
            List<Jugada> todasLasJugadas = new List<Jugada>(UnirJugadasDeJuegos(datos.JuegosCreados));
            foreach (var seguido in seguidos) 
            {
                List<Jugada> jugadasDeUnSeguido = new List<Jugada>(JugadasDe(seguido, todasLasJugadas));
                foreach (var jugadaSeguido in jugadasDeUnSeguido)
                {
                    jugadasDeSeguidos.Add(jugadaSeguido);
                }
            }
            return jugadasDeSeguidos;
        }
        
        public static List<Encuesta> OrdenarEncuestasSeguidos(Datos datos)
        {
            List<Encuesta> retorno = new List<Encuesta>();
            IList<Usuario> seguidos = datos.usuarioLogeado.Seguidos;
            List<Encuesta> encuestasDeSeguidos = new List<Encuesta>(UnirEncuestasDeUsuarios(seguidos));
            for (var i = 0; i < encuestasDeSeguidos.Count; i++)
            {
                retorno.Add(EncuestaMasNueva(encuestasDeSeguidos));
                EliminarEncuestaDeLista(retorno[i], encuestasDeSeguidos);
            }
            return retorno;
        }

        public static Encuesta EncuestaMasNueva(List<Encuesta> encuestas)
        {
            Encuesta masNueva = encuestas[0];
            foreach (var encuesta in encuestas)
            {
                if (encuesta.FechaCreacion > masNueva.FechaCreacion)
                {
                    masNueva = encuesta;
                }
            }
            return masNueva;
        }

        public static List<Encuesta> UnirEncuestasDeUsuarios(IList<Usuario> usuarios)
        {
            List<Encuesta> retorno = new List<Encuesta>();
            foreach (var usuario in usuarios)
            {
                foreach (var encuesta in usuario.Encuestas)
                {
                    retorno.Add(encuesta);
                }
            }
            return retorno;
        }

        public static void EliminarEncuestaDeLista(Encuesta encuestaEliminar, List<Encuesta> encuestas)
        {
            bool encontre = false;
            for (var i = 0; i < encuestas.Count && !encontre; i++)
            {
                if (encuestas[i] == encuestaEliminar)
                {
                    encontre = true;
                    encuestas.Remove(encuestas[i]);
                }
            }
        }
    }
}
