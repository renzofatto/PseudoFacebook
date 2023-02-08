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
    public partial class JuegoItemList : UserControl
    {
        private Datos datosDelSistema;
        public JuegoItemList(Datos datos)
        {
            datosDelSistema = datos;
            InitializeComponent();
            LoadJuegos();
        }
        private void LoadJuegos()
        {
            this.panel.Controls.Clear();
            foreach(var juego in datosDelSistema.JuegosCreados)
            {
                var juegoItem = new JuegoItem(juego, datosDelSistema);
                this.panel.Controls.Add(juegoItem);
            }
            Refresh();
        }
   
        private void panel_VisibleChanged(object sender, EventArgs e)
        {
            LoadJuegos();
        }
    }
}
