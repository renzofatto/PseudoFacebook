using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDisenoDeAplicaciones
{
    public interface IRepository<K, T>
    {
        int Count { get; }

        void Agregar(T entity);

        bool Exists(K key);

        T Get(K key);

        void Update(T entity);

        void Borrar(K key);

        IEnumerable<T> GetAll();

        void Clear();

    }

    public interface ILibro : IRepository<string, Usuario> { 
        Usuario UsuarioLogeado { get; set; }
    }

    public interface IPublicaciones : IRepository<int, Publicacion> {
        void BorrarEstado(int key);
    }

    public interface IAlbumes : IRepository<int, Album> { }
    public interface IEscuchando : IRepository<int, Escuchando> { }
    public interface IEstado : IRepository<int, Estado> { }
    public interface IJugada : IRepository<int, Jugada> { }
}
