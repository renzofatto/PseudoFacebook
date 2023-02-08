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
    public partial class Feed : UserControl
    {
        private Datos datosDelSistema;
        public Feed(Datos datos)
        {
            datosDelSistema = datos;
            InitializeComponent();
            feedControlPanel.HorizontalScroll.Maximum = 0;
            feedControlPanel.AutoScroll = false;
            feedControlPanel.VerticalScroll.Visible = false;
            feedControlPanel.AutoScroll = true;
            LoadFeed();
        }

        private void LoadFeed()
        {
            List<Jugada> jugadas = ManejadorListas.JugadasSeguidos(datosDelSistema);
            foreach(var jugada in jugadas)
            {
                var feedItem = new FeedJugada(jugada, datosDelSistema);
                var jugadaGenerico = new GenericoFeed(feedItem, datosDelSistema, jugada);
                this.feedControlPanel.Controls.Add(jugadaGenerico);
            }
            List<Album> albumes = ManejadorListas.UnirAlbumesDeUsuarios(datosDelSistema.usuarioLogeado.Seguidos);
            foreach(var album in albumes)
            {
                IList<Control> miniFotos = album.TodasLasFotos().Select(imagenes => (Control)new MiniAlbum(imagenes)).ToList();

                var expandableBook = new ExpandableBook(
                    album.NombreAlbum,
                    miniFotos
                  );
                var albumGenerico = new GenericoFeed(expandableBook, datosDelSistema, album);
                this.feedControlPanel.Controls.Add(albumGenerico);
            }
            List<Escuchando> hanEscuchado = ManejadorListas.UnirEscuchandoDeUsuarios(datosDelSistema.usuarioLogeado.Seguidos);
            foreach(var escuchando in hanEscuchado)
            {
                var feedItem = new EscuchandoFeed(datosDelSistema, escuchando);
                var escuchandoGenerico = new GenericoFeed(feedItem, datosDelSistema, escuchando);
                this.feedControlPanel.Controls.Add(escuchandoGenerico);
            }
            List<Estado> estados = ManejadorListas.UnirEstadosDeUsuarios(datosDelSistema.usuarioLogeado.Seguidos);
            foreach (var estado in estados)
            {
                var feedItem = new EstadoFeed(datosDelSistema, estado);
                var estadoGenerico = new GenericoFeed(feedItem, datosDelSistema, estado);
                this.feedControlPanel.Controls.Add(estadoGenerico);
            }
            IList<Encuesta> encuestas = ManejadorListas.UnirEncuestasDeUsuarios(datosDelSistema.usuarioLogeado.Seguidos);
            foreach (var encuesta in encuestas)
            {
                var feedItem = new EncuestaFeed(datosDelSistema, encuesta);
                var encuestaGenerica = new GenericoFeed(feedItem, datosDelSistema, encuesta);
                this.feedControlPanel.Controls.Add(encuestaGenerica);
            }
        }
    }
}
