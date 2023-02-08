using ObligatorioDisenoDeAplicaciones;
using System;
using System.Windows.Forms;

namespace ObligatorioUI
{
    public partial class EncuestaFeed : UserControl
    {
        private Datos datosDelSistema;
        private Encuesta miEncuesta;
        public EncuestaFeed(Datos datos, Encuesta encuesta)
        {
            InitializeComponent();
            miEncuesta = encuesta;
            datosDelSistema = datos;
            encuestaMaterialTextBox.Text = $"{encuesta.CreadoPor.NombreUsuario} Publico: {encuesta.TextoDeEncuesta}";
            materialComboBox1.Items.AddRange(encuesta.OpcionesArray());
            materialComboBox1.SelectedIndex = 0;
        }

        private void VotarMaterialButton_Click(object sender, System.EventArgs e)
        {
            try 
            {
                miEncuesta.AgregarVotanteYVoto(datosDelSistema.usuarioLogeado, miEncuesta.OpcionesArray()[materialComboBox1.SelectedIndex]);
                errorProvider1.SetError(materialComboBox1, null);
                datosDelSistema.Reporte.Add($"{datosDelSistema.usuarioLogeado.NombreUsuario} voto en la encuesta '{miEncuesta.TextoDeEncuesta}' {DateTime.Now}");
            }
            catch (EncuestaException ex)
            {
                errorProvider1.SetError(materialComboBox1, ex.Message);
            }
        }

        private void GraficaMaterialButton_Click(object sender, EventArgs e)
        {
            VentanaGrafica ventanaGrafica = new VentanaGrafica(miEncuesta);
            ventanaGrafica.Show();
        }
    }
}
