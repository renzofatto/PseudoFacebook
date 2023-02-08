using ObligatorioDisenoDeAplicaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObligatorioUI
{
    public partial class AgregadorDeJuego : UserControl
    {
        private Datos datosDelSistema;
        private string direccionImagen;
        public AgregadorDeJuego(Datos datos)
        {
            datosDelSistema = datos;
            InitializeComponent();
            
            categoriaComboBox.Items.Add("Accion");
            categoriaComboBox.Items.Add("Terror");
            categoriaComboBox.Items.Add("Aventura");
            categoriaComboBox.Items.Add("Deportes");
            categoriaComboBox.Items.Add("Puzzle");
            categoriaComboBox.Items.Add("Trivia");
            categoriaComboBox.Items.Add("Azar");
            categoriaComboBox.SelectedIndex = 0;
            errorProvider1.SetError(tituloTextBox, null);
        }
        
        
        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Juego.AgregarJuego(tituloTextBox.Text, categoriaComboBox.SelectedItem.ToString(), direccionImagen, datosDelSistema);
                MessageBox.Show($"Has agregado {tituloTextBox.Text} con exito!", "", MessageBoxButtons.OK);
                datosDelSistema.Reporte.Add($"{datosDelSistema.usuarioLogeado.NombreUsuario} agrego el juego {tituloTextBox.Text} {DateTime.Now}");
                errorProvider1.SetError(tituloTextBox, null);
                errorProvider1.SetError(seleccionLabel, null);
                LimpiarAgregador();
            }
            catch (JuegoException ex)
            {
                errorProvider1.SetError(tituloTextBox, ex.Message);
            }
            catch (ArgumentException ex) 
            {
                errorProvider1.SetError(seleccionLabel, ex.Message);
            }
        }

        private void LimpiarAgregador()
        {
            tituloTextBox.Clear();
            caratulaPictureBox.Image = null;
            direccionImagen = null;
            seleccionLabel.Text = "";
            categoriaComboBox.SelectedIndex = 0;
            errorProvider1.Clear();
        }

        private void seleccionarImagenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            OpenFileDialog pictureFileDialog = openFileDialog;
            pictureFileDialog.Title = "Open Image";
            pictureFileDialog.Filter = "Image Files (*.jpg;*.jpeg,*.png)|*.JPG;*.JPEG;*.PNG";
            if (pictureFileDialog.ShowDialog() == DialogResult.OK)
            {
                direccionImagen = pictureFileDialog.FileName;
                var caratulaSeleccionada = new FileInfo(pictureFileDialog.FileName);
                seleccionLabel.Text = caratulaSeleccionada.Name;
                caratulaPictureBox.Image = new Bitmap(pictureFileDialog.FileName);
            }
        }

        private void tituloTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                bool valido = Juego.TituloDeJuegoValido(tituloTextBox.Text, datosDelSistema.JuegosCreados);
                errorProvider1.SetError(tituloTextBox, null);
            }
            catch (JuegoException ex) {
                errorProvider1.SetError(tituloTextBox, ex.Message);
            }
            
        }

        
    }
}
