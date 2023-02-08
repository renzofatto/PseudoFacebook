using Dominio;
using ObligatorioDisenoDeAplicaciones;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ObligatorioUI
{
    public partial class VentanaGrafica : Form
    {
        private Encuesta miEncuesta; 
        public VentanaGrafica(Encuesta encuesta)
        {
            InitializeComponent();
            miEncuesta = encuesta;
        }

        private void Encuesta_Load(object sender, EventArgs e)
        {
            // Funcionalidad
            string[] misSeries = miEncuesta.OpcionesArray();
            int[] misPuntos = miEncuesta.VotosArray();

            chart1.Titles.Add(miEncuesta.TextoDeEncuesta);
            for (int i = 0; i < misSeries.Length; i++)
            {
                Series serie = chart1.Series.Add(misSeries[i]);
                serie.Label = misPuntos[i].ToString();
                serie.Points.Add(misPuntos[i]);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
