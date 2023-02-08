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
    public partial class EstadoFeed : UserControl
    {

            private Datos datosDelSistema;
            public EstadoFeed(Datos datos, Estado estado)
            {
                InitializeComponent();
                datosDelSistema = datos;
                estadoLabel.Text = $"{estado.CreadoPor.NombreUsuario} Publico: {estado.TextoDeEstado}";
            }
        
    }
}
