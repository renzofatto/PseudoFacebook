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
    public partial class JuegoEliminableItem : UserControl
    {
        private Juego juegoSeleccionado;
        private Datos datosDelSistema;
        public JuegoEliminableItem(Juego juego, Datos datos)
        {
            datosDelSistema = datos;
            InitializeComponent();
            juegoSeleccionado = juego;
            tituloLabel.Text = juego.Titulo;
            categoriaLabel.Text = juego.Categoria;
            pictureBoxCaratula.Load(juego.Caratula);
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            datosDelSistema.JuegosCreados.Remove(juegoSeleccionado);
            datosDelSistema.Reporte.Add($"{datosDelSistema.usuarioLogeado.NombreUsuario} elimino el juego {juegoSeleccionado.titulo} {DateTime.Now}");
            this.Dispose();
        }
    }
}
