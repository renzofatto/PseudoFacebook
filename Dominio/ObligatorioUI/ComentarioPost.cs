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
    public partial class ComentarioPost : UserControl
    {
        private Datos datosDelSistema;
        private Comentario comentario;
        public ComentarioPost(Comentario comment, Datos datos)
        {
            InitializeComponent();
            datosDelSistema = datos;
            comentario = comment;
            CargarReacciones();
            comentariosFlowPanel.HorizontalScroll.Maximum = 0;
            comentariosFlowPanel.AutoScroll = false;
            comentariosFlowPanel.VerticalScroll.Visible = false;
            comentariosFlowPanel.AutoScroll = true;
            comentarioLabel.Text = ($"{comment.CreadoPor.NombreUsuario}: {comment.Contenido}");
            CargarComentarios();
        }

        private void CargarReacciones()
        {
            meGustaLabel.Text = ($"{comentario.MeGustas}");
        }

        private void VisibilidadReply()
        {
            if (comentarioTextBox.Visible)
            {
                comentarioTextBox.Clear();
                comentarioTextBox.Hide();
                enviarBoton.Hide();
            }
            else
            {
                comentarioTextBox.Show();
                enviarBoton.Show();
            }
        }

        private void CargarComentarios()
        {
            IList<Comentario> comentarios = comentario.Comentarios();
            if (comentarios != null)
            {
                comentariosFlowPanel.Controls.Clear();
                foreach (var comentario in comentarios)
                {

                    ComentarioSecundario comment = new ComentarioSecundario(comentario, datosDelSistema);
                    comentariosFlowPanel.Controls.Add(comment);
                }
            }
        }

        private void replyBoton_Click_1(object sender, EventArgs e)
        {
            VisibilidadReply();
        }

        private void enviarBoton_Click_1(object sender, EventArgs e)
        {
            string contenido = comentarioTextBox.Text;
            Usuario comentador = datosDelSistema.usuarioLogeado;
            try
            {
                Comentario nuevoComentario = new Comentario(comentador)
                {
                    CreadoPor = comentador,
                    Contenido = contenido.Trim(),
                    Tipo = "Comentario"
                };
                datosDelSistema.Reporte.Add($"{datosDelSistema.usuarioLogeado.NombreUsuario} publico un comentario {DateTime.Now}");
                comentario.AgregarComentario(nuevoComentario);
                CargarComentarios();
                comentarioTextBox.Clear();
                VisibilidadReply();
            }
            catch (DominioException ex)
            {
                errorProvider1.SetError(comentarioTextBox, ex.Message);
            }
        }

        private void likeBoton_Click_1(object sender, EventArgs e)
        {
            if (comentario.Reaccionaron != null)
            {
                if (!comentario.Reaccionaron.Contains(datosDelSistema.usuarioLogeado))
                {
                    comentario.Megusta();
                    CargarReacciones();
                    comentario.AgregarReactor(datosDelSistema.usuarioLogeado);
                }
            }
            else
            {
                comentario.Megusta();
                CargarReacciones();
                comentario.AgregarReactor(datosDelSistema.usuarioLogeado);
            }
        }
    }
}
