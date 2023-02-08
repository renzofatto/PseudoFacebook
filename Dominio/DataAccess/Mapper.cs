using DataAccess.Entities;
using ObligatorioDisenoDeAplicaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Mapper
    {
        string cancion;
        string album;
        string artista;
        string texto;
        public UsuarioEntity ToEntity(Usuario usuario) => new UsuarioEntity
        {
            Id_Usuario = usuario.Id_Usuario,
            NombreUsuario = usuario.NombreUsuario,
            Contrasena = usuario.Contrasena,
            Nombre = usuario.Nombre,
            Apellido = usuario.Apellido,
            DireccionPersona = usuario.DireccionPersona,
            Administrador = usuario.Administrador,
            Logeado = usuario.Logeado,
            //PicturePath = usuario.PicturePath,
        };

        public Usuario ToDomain(UsuarioEntity entity) => new Usuario
        {
            Id_Usuario = entity.Id_Usuario,
            NombreUsuario = entity.NombreUsuario,
            Contrasena = entity.Contrasena,
            Nombre = entity.Nombre,
            Apellido = entity.Apellido,
            DireccionPersona = entity.DireccionPersona,
            Administrador = entity.Administrador,
            Logeado = entity.Logeado,
            //PicturePath = entity.PicturePath
        };

        public PublicacionEntity ToEntity(Publicacion publicacion) => new PublicacionEntity
        { 
            Id = publicacion.Id,
            CreadoPor = ToEntity(publicacion.CreadoPor),
            FechaCreacion = publicacion.FechaCreacion,
        };

        public Publicacion ToDomain(PublicacionEntity entity) => new Publicacion(ToDomain(entity.CreadoPor))
        {
            Id = entity.Id,
            FechaCreacion = entity.FechaCreacion
        };

        public EstadoEntity ToEntity(Estado estado) => new EstadoEntity {
            Id = estado.Id,
            Tipo = estado.Tipo,
            TextoDeEstado = estado.TextoDeEstado,
            FechaCreacion = estado.FechaCreacion,
            CreadoPor = ToEntity(estado.CreadoPor)
        };

        public Estado ToDomain(EstadoEntity entity) => new Estado(ToDomain(entity.CreadoPor), texto)
        {
            Id = entity.Id,
            Tipo = entity.Tipo,
            TextoDeEstado = entity.TextoDeEstado
        };

        public EscuchandoEntity ToEntity(Escuchando escuchando) => new EscuchandoEntity
        {
            Id = escuchando.Id,
            Tipo = escuchando.Tipo,
            Artista = escuchando.Artista,
            Album = escuchando.Album,
            Cancion = escuchando.Cancion,
            FechaCreacion = escuchando.FechaCreacion,
            CreadoPor = ToEntity(escuchando.CreadoPor)
        };

        public Escuchando ToDomain(EscuchandoEntity entity) => new Escuchando(ToDomain(entity.CreadoPor), cancion, artista, album)
        {
            Id = entity.Id,
            Tipo = entity.Tipo,
            FechaCreacion = entity.FechaCreacion
        };

        public AlbumEntity ToEntity(Album album) => new AlbumEntity
        {
            Id = album.Id,
            Tipo = album.Tipo,
            FechaCreacion = album.FechaCreacion,
            CreadoPor = ToEntity(album.CreadoPor),
        };

        public Album ToDomain(AlbumEntity entity) => new Album(ToDomain(entity.CreadoPor))
        {
            Id = entity.Id,
            Tipo = entity.Tipo,
            FechaCreacion = entity.FechaCreacion,
        };

        public JugadaEntity ToEntity(Jugada jugada) => new JugadaEntity
        {
            Id = jugada.Id,
            Tipo = jugada.Tipo,
            Juego = jugada.Juego,
            Puntaje = jugada.Puntaje,
            Jugador = ToEntity(jugada.Jugador),
        };

        public Jugada ToDomain(JugadaEntity entity) => new Jugada(ToDomain(entity.CreadoPor))
        {
            Id = entity.Id,
            Tipo = entity.Tipo,
            Juego = entity.Juego,
            Jugador = ToDomain(entity.Jugador),
            Puntaje = entity.Puntaje,
        };
    }
}
