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
    public partial class JuegoItem : UserControl
    {
        private Juego juegoSeleccionado;
        private Datos datosDelSistema;
        public JuegoItem(Juego juego, Datos datos)
        {
            datosDelSistema = datos;
            InitializeComponent();
            VisibilidadMenuJuego(false);
            VisibilidadSimulacion(false);
            juegoSeleccionado = juego;
            LabelTitulo.Text = juego.Titulo;
            LabelCategoria.Text = juego.Categoria;
            pictureBoxCaratula.Load(juego.Caratula);
        }

        private void SimularJuego()
        {
            if (puntajeTextBox.Text.Trim() != "")
            {
                int puntaje = Int32.Parse(puntajeTextBox.Text);
                juegoSeleccionado.Jugar(puntaje, datosDelSistema.usuarioLogeado);
                puntajeTextBox.Clear();
                MessageBox.Show($"Partida terminada, ha conseguido {puntaje} puntos", juegoSeleccionado.Titulo, MessageBoxButtons.OK);
                datosDelSistema.Reporte.Add($"{datosDelSistema.usuarioLogeado.NombreUsuario} jugo a {juegoSeleccionado.titulo} {DateTime.Now}");
            }
            VisibilidadSimulacion(false);
            VisibilidadAbrir(true);

        }

        private void jugarButton_Click(object sender, EventArgs e)
        {

            VisibilidadMenuJuego(false);
            VisibilidadSimulacion(true);

        }

        private void simularButton_Click(object sender, EventArgs e)
        {
            SimularJuego();
        }

        private void puntajeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void abrirButton_Click(object sender, EventArgs e)
        {
            if (Juego.NoExisteJuego(juegoSeleccionado.Titulo, datosDelSistema))
            {
                MessageBox.Show($"Actualice la lista", "", MessageBoxButtons.OK);
            }
            else
            {
                VisibilidadAbrir(false);
                VisibilidadMenuJuego(true);
            }
        }

        private void rankingButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Juego.TopDiez(juegoSeleccionado,datosDelSistema)}", $"Top 10 {juegoSeleccionado.Titulo}", MessageBoxButtons.OK);
        }
        private void VisibilidadAbrir(bool visible)
        {
            if (visible)
            {
                abrirButton.Show();
                pictureBoxCaratula.Show();
                LabelTitulo.Show();
                LabelCategoria.Show();
            }
            else
            {
                abrirButton.Hide();
                pictureBoxCaratula.Hide();
                LabelTitulo.Hide();
                LabelCategoria.Hide();
            }
        }
        private void VisibilidadMenuJuego(bool visible)
        {
            if (visible)
            {
                jugarButton.Show();
                rankingButton.Show();

            }
            else
            {
                jugarButton.Hide();
                rankingButton.Hide();

            }
        }
        private void VisibilidadSimulacion(bool visible)
        {
            if (visible)
            {
                simularButton.Show();
                puntajeTextBox.Show();
                atrasButton.Show();
            }
            else
            {
                simularButton.Hide();
                puntajeTextBox.Hide();
                atrasButton.Hide();
            }
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            puntajeTextBox.Clear();
            VisibilidadSimulacion(false);
            VisibilidadAbrir(true);
        }
    }
}
