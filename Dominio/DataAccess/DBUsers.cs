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
    public class DBUsers : ILibro
    {
        public IList<Usuario> usuarios;
        public DBUsers()
        {
            usuarios = new List<Usuario>();
        }
        Mapper mapper = new Mapper();
        
        public Usuario UsuarioLogeado { get; set; }
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

        public void Agregar(Usuario usuario)
        {
            UsuarioEntity userEntity = mapper.ToEntity(usuario);
            if (Exists(usuario.NombreUsuario))
                throw new ArgumentException("Ese usuario ya existe");
            using (var context = new EFContext())
            {
                context.UsuarioEntities.Add(userEntity);
                context.SaveChanges();
                usuario.Id_Usuario = userEntity.Id_Usuario;
            }
        }

        public bool Exists(string nombreUsuario)
        {
            bool existe;
            using (var context = new EFContext())
            {
                existe = context.UsuarioEntities.Any(user => user.NombreUsuario.Equals(nombreUsuario));
            }
            return existe;
        }

        public Usuario Get(string key)
        {
            if (!Exists(key))
                throw new ArgumentException("No existe usuario");
            Usuario usuario;
            using (var context = new EFContext())
            {
                UsuarioEntity usuarioAdquirido = context.UsuarioEntities.FirstOrDefault(user => user.NombreUsuario == key);
                usuario = mapper.ToDomain(usuarioAdquirido);
            }
            return usuario;
        }

        public void Update(Usuario usuario)
        {
            var usuarioEntidad = mapper.ToEntity(usuario);
            if (!Exists(usuarioEntidad.NombreUsuario))
                throw new ArgumentException($"{usuarioEntidad.NombreUsuario} no existe");

            using (var context = new EFContext()) {
                context.UsuarioEntities.Attach(usuarioEntidad);
                context.Entry(usuarioEntidad).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Borrar(string nombreUsuario)
        {
            using (var context = new EFContext()) {
                var user = context.UsuarioEntities.First(u => u.NombreUsuario == nombreUsuario);
                context.UsuarioEntities.Remove(user);
                context.SaveChanges();
            }
        }

        public IEnumerable<Usuario> GetAll()
        {

            using (EFContext context = new EFContext())
            {
                IEnumerable<UsuarioEntity> retrieved = context.UsuarioEntities.ToList();
                return retrieved.Select(p => mapper.ToDomain(p));
            }
            
        }

        public void Clear()
        {
            using (var context = new EFContext())
            {
                context.UsuarioEntities.RemoveRange(context.UsuarioEntities);
                context.SaveChanges();
            }
        }

    }
}
