using DataAccess.Entities;
using ObligatorioDisenoDeAplicaciones;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DBPublicaciones : IPublicaciones
    {
        IList<Publicacion> publicaciones;
        Mapper mapper = new Mapper();
        public DBPublicaciones() {
            publicaciones = new List<Publicacion>();

        }


        public int Count {
            get
            {
                int count;
                using (var context = new EFContext())
                {
                    count = context.UsuarioEntities.Count();
                }
                return count;
            }
        }

        public virtual void Agregar(Publicacion publicacion)
        {

            if (publicacion.Tipo.Equals("Estado"))
            {
                AgregarEstado((Estado)publicacion);
            }
            else if (publicacion.GetType().Name.Equals("Escuchando")) {
                AgregarEscuchando((Escuchando)publicacion);
            }
            else if (publicacion.GetType().Name.Equals("Album"))
            {
                AgregarAlbum((Album)publicacion);
            }
            else if (publicacion.GetType().Name.Equals("Jugada"))
            {
                AgregarJugada((Jugada)publicacion);
            }
        }

        private void AgregarJugada(Jugada jugada)
        {
            JugadaEntity jugadaEntity = mapper.ToEntity(jugada);
            if (Exists(jugada.Id))
                throw new ArgumentException("Esta jugada ya existe");
            using (EFContext context = new EFContext())
            {
                context.UsuarioEntities.Attach(jugadaEntity.CreadoPor);
                context.PublicacionEntities.Add(jugadaEntity);
                context.SaveChanges();
            }
        }

        private void AgregarAlbum(Album album)
        {
            AlbumEntity albumEntity = mapper.ToEntity(album);
            if (Exists(album.Id))
                throw new ArgumentException("Este album ya existe");
            using (EFContext context = new EFContext())
            {
                context.UsuarioEntities.Attach(albumEntity.CreadoPor);
                context.PublicacionEntities.Add(albumEntity);
                context.SaveChanges();
            }
        }

        private void AgregarEscuchando(Escuchando escuchando)
        {
            publicaciones.Add(escuchando);
            EscuchandoEntity escuchandoEntity = mapper.ToEntity(escuchando);
            if (Exists(escuchando.Id))
                throw new ArgumentException("kjasds");
            using (EFContext context = new EFContext())
            { 
                context.UsuarioEntities.Attach(escuchandoEntity.CreadoPor);
                context.PublicacionEntities.Add(escuchandoEntity);
                context.SaveChanges();
                escuchando.Id = escuchandoEntity.Id;
            }
        }

        private void AgregarEstado(Estado estado)
        {
            publicaciones.Add(estado);
            EstadoEntity estadoEntity = mapper.ToEntity(estado);
            if (Exists(estado.Id))
                throw new ArgumentException("kjasds");
            using (var context = new EFContext())
            {
                context.UsuarioEntities.Attach(estadoEntity.CreadoPor);
                context.PublicacionEntities.Add(estadoEntity);
                context.SaveChanges();
                estado.Id = estadoEntity.Id;
            }
        }


        public IEnumerable<Publicacion> GetAll()
        {
            using (EFContext context = new EFContext())
            {
                IEnumerable<PublicacionEntity> retrieved = context.PublicacionEntities.ToList();
                return retrieved.Select(p => mapper.ToDomain(p));
            }
        }

        public bool Exists(int id)
        {
            bool existe;
            using (var context = new EFContext())
            {
                existe = context.PublicacionEntities.Any(publi => publi.Id.Equals(id));
            }
            return existe;
        }

        public Publicacion Get(int key)
        {
            if (!Exists(key))
                throw new ArgumentException("No existe publicacion");
            Publicacion publicacion;
            using (var context = new EFContext())
            {
                PublicacionEntity publicacionAdquirida = context.PublicacionEntities.FirstOrDefault(publi => publi.Id == key);
                publicacion = mapper.ToDomain(publicacionAdquirida);
            }
            return publicacion;
        }

        public virtual void Borrar(int key)
        {
            using (var context = new EFContext())
            {
                var publicacion = context.PublicacionEntities.FirstOrDefault(publi => publi.Id == key);
                context.PublicacionEntities.Remove(publicacion);
                context.SaveChanges();
            }
        }

        public virtual void BorrarEstado(int key)
        {
            using (var context = new EFContext())
            {
                var publicacion = context.PublicacionEntities.FirstOrDefault(publi => publi.Id.Equals(key));
                context.PublicacionEntities.Remove(publicacion);
                context.SaveChanges();
            }
        }

        public void Update(Publicacion publicacion)
        {
            var publicacionEntidad = mapper.ToEntity(publicacion);
            if (!Exists(publicacionEntidad.Id))
                throw new ArgumentException($"{publicacionEntidad.Id} no existe");

            using (var context = new EFContext())
            {
                context.PublicacionEntities.Attach(publicacionEntidad);
                context.Entry(publicacionEntidad).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Clear()
        {
            using (var context = new EFContext())
            {
                context.PublicacionEntities.RemoveRange(context.PublicacionEntities);
                context.SaveChanges();
            }
        }
    }

    

}
