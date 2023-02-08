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
    public partial class ComentarioSecundario : UserControl
    {
        private Comentario comentario;
        private Datos datosDelSistema;
        public ComentarioSecundario(Comentario comment, Datos datos)
        {
            InitializeComponent();
            datosDelSistema = datos;
            comentario = comment;
            comentarioLabel.Text = ($"{comentario.CreadoPor.NombreUsuario}: {comentario.Contenido}");
            CargarReacciones();
        }

        private void CargarReacciones()
        {
            meGustaLabel.Text = ($"{comentario.MeGustas}");
        }

        private void meGustaBoton_Click_1(object sender, EventArgs e)
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
