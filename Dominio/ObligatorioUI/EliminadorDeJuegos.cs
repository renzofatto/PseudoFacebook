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
    public partial class EliminadorDeJuegos : UserControl
    {
        private Datos datosDelSistema;
        public EliminadorDeJuegos(Datos datos)
        {
            datosDelSistema = datos;
            InitializeComponent();
            LoadJuegos();
        }
        private void LoadJuegos()
        {
            this.juegosEliminablesPanel.Controls.Clear();

            foreach (var juego in datosDelSistema.JuegosCreados)
            {
                if (juego.jugadas.Count == 0)
                {
                    var juegoEliminableItem = new JuegoEliminableItem(juego, datosDelSistema);
                    this.juegosEliminablesPanel.Controls.Add(juegoEliminableItem);
                }
            }
            Refresh();
        }
    }
}
