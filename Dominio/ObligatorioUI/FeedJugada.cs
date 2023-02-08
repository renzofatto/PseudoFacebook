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
    public partial class FeedJugada : UserControl
    {
        private Jugada jugadaSeleccionada;
        private Datos datosDelSistema;
        public FeedJugada(Jugada jugada, Datos datos)
        {
            datosDelSistema = datos;
            InitializeComponent();
            jugadaSeleccionada = jugada;
            var juego = Juego.getJuegoFromTitulo(jugada.Juego, datosDelSistema);
            caratulaPictureBox.Load(juego.Caratula);
            jugadaLabel.Text = $"{jugada.Jugador.NombreUsuario} consiguio un puntaje de {jugada.Puntaje} en {jugada.Juego}";
        }

        private void FeedJugada_Load(object sender, EventArgs e)
        {

        }
    }
}
