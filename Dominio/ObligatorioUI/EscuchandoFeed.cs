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
    public partial class EscuchandoFeed : UserControl
    {
        private Datos datosDelSistema;
        public EscuchandoFeed(Datos datos,Escuchando escuchando)
        {
            InitializeComponent();
            datosDelSistema = datos;
            escuchandoLabel.Text = $"{escuchando.CreadoPor.NombreUsuario} esta escuchando {escuchando.Cancion} por {escuchando.Artista}, album: {escuchando.Album}";
        }
    }
}
