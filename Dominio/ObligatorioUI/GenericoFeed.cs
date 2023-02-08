using Dominio;
using ObligatorioDisenoDeAplicaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObligatorioUI
{
    public partial class GenericoFeed : UserControl
    {
        private Datos datosDelSistema;
        private Publicacion publicacion;
        public GenericoFeed(UserControl content, Datos datos, Publicacion post)
        {
            InitializeComponent();
            comentarioFlowPanel.HorizontalScroll.Maximum = 0;
            comentarioFlowPanel.AutoScroll = false;
            comentarioFlowPanel.VerticalScroll.Visible = false;
            comentarioFlowPanel.AutoScroll = true;
            datosDelSistema = datos;
            publicacion = post;
            CargarPublicacion(content);
            CargarComentarios();
            CargarReacciones();
            CargarReactores();
        }

        private void CargarReactores()
        {
            reactoresListBox.Items.Clear();
            foreach (var usuario in publicacion.Reaccionaron)
            {
                reactoresListBox.Items.Add(($"{usuario.NombreUsuario} reacciono a esta publicacion"));
            }
        }

        private void CargarReacciones()
        {
            felicitacionLabel.Text = ($"{publicacion.Felicitaciones}");
            meGustaLabel.Text = ($"{publicacion.MeGustas}");
            meEncantaLabel.Text = ($"{publicacion.MeEncantas}");
        }

        private void CargarComentarios()
        {
            //comentariosBox.Items.Clear();
            IList<Comentario> comentarios = publicacion.Comentarios();
            if (comentarios != null)
            {
                comentarioFlowPanel.Controls.Clear();
                foreach (var comentario in comentarios)
                {

                    ComentarioPost comment = new ComentarioPost(comentario, datosDelSistema);
                    comentarioFlowPanel.Controls.Add(comment);
                }
            }
        }

        public void CargarPublicacion(UserControl content)
        {
            FlowPanelContenido.Controls.Add(content);
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            string comentario = comentarioTextBox.Text;
            Usuario comentador = datosDelSistema.usuarioLogeado;
            try
            {
                Comentario nuevoComentario = new Comentario(comentador)
                {
                    CreadoPor = comentador,
                    Contenido = comentario.Trim(),
                    Tipo = "Comentario"
                };
                datosDelSistema.Reporte.Add($"{datosDelSistema.usuarioLogeado.NombreUsuario} publico un comentario {DateTime.Now}");
                publicacion.AgregarComentario(nuevoComentario);
                CargarComentarios();
                comentarioTextBox.Clear();
            }
            catch (DominioException ex)
            {
                errorProvider1.SetError(comentarioTextBox, ex.Message);
            }
        }
        private void megustaBoton_Click(object sender, EventArgs e)
        {
            if (publicacion.Reaccionaron != null)
            {
                if (!publicacion.Reaccionaron.Contains(datosDelSistema.usuarioLogeado))
                {
                    publicacion.Megusta();
                    CargarReacciones();
                    publicacion.AgregarReactor(datosDelSistema.usuarioLogeado);
                }
            }
            else
            {
                publicacion.Megusta();
                CargarReacciones();
                publicacion.AgregarReactor(datosDelSistema.usuarioLogeado);
            }
        }

        private void meEncantaBoton_Click(object sender, EventArgs e)
        {
            if (publicacion.Reaccionaron != null)
            {
                if (!publicacion.Reaccionaron.Contains(datosDelSistema.usuarioLogeado))
                {
                    publicacion.Meencanta();
                    CargarReacciones();
                    publicacion.AgregarReactor(datosDelSistema.usuarioLogeado);
                }
            }
            else
            {
                publicacion.Meencanta();
                CargarReacciones();
                publicacion.AgregarReactor(datosDelSistema.usuarioLogeado);
            }
        }

        private void felicitacionBoton_Click(object sender, EventArgs e)
        {
            if (publicacion.Reaccionaron != null)
            {
                if (!publicacion.Reaccionaron.Contains(datosDelSistema.usuarioLogeado))
                {
                    publicacion.Felicitacion();
                    CargarReacciones();
                    publicacion.AgregarReactor(datosDelSistema.usuarioLogeado);
                }
            }
            else
            {
                publicacion.Felicitacion();
                CargarReacciones();
                publicacion.AgregarReactor(datosDelSistema.usuarioLogeado);
            }
        }

        private void reaccionesBoton_Click(object sender, EventArgs e)
        {
            if (reactoresListBox.Visible)
            {
                reactoresListBox.Hide();
            }
            else
            {
                CargarReactores();
                reactoresListBox.Show();
            }
        }
    }
}
