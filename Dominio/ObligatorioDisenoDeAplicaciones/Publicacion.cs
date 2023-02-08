using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ObligatorioDisenoDeAplicaciones
{
    public class Publicacion
    {
        public Usuario creadoPor;
        public DateTime fechaCreacion;
        public List<Publicacion> publicaciones;
        private IList<Usuario> reaccionaron;
        private IList<Comentario> comentarios;

        public Publicacion(Usuario usuarioCreador)
        {
            CreadoPor = usuarioCreador;
            FechaCreacion = DateTime.Now;
            reaccionaron = new List<Usuario>();
            comentarios = new List<Comentario>();
        }
        public int Id { get; set; }

        public virtual Usuario CreadoPor { get; set; }
        
        public string Tipo { get; set; }

        public virtual DateTime FechaCreacion { get; set; }
        public int Felicitaciones { get; private set; }
        public int MeEncantas { get; private set; }
        public int MeGustas { get; private set; }
        public virtual IList<Usuario> Reaccionaron
        {
            get => reaccionaron;
        }

        public void AgregarReactor(Usuario usuario)
        {
            reaccionaron.Add(usuario);
        }
        public IList<Comentario> Comentarios()
        {
            IList<Comentario> todosLosComentarios = comentarios;
            return todosLosComentarios;
        }
        public void AgregarComentario(Comentario comentario)
        {
            comentarios.Add(comentario);
        }

        public void Felicitacion()
        {
            Felicitaciones++;
        }

        public void Meencanta()
        {
            MeEncantas++;
        }

        public void Megusta()
        {
            MeGustas++;
        }

    }
}
