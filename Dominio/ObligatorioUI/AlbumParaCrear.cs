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
    public partial class AlbumParaCrear : UserControl
    {
        private Datos datosDelSistema;
        private List<string> imagenesAgregadas;
        private Album albumACrear;
        private Album albumAEditar;
        private ILibro baseUsuarios;
        private IPublicaciones basePublicaciones;
        private string nombreAlbum;

        public AlbumParaCrear(Datos datos, ILibro dbUsers, IPublicaciones dbPublicaciones)
        {
            datosDelSistema = datos;
            basePublicaciones = dbPublicaciones;
            baseUsuarios = dbUsers;
            imagenesAgregadas = new List<string>();
            InitializeComponent();
            ConfirmarButton.Hide();
            EditarAlbumLabel.Hide();
            GuardarAlbumButton.Show();
        }

        public AlbumParaCrear(Datos datos, Album album) 
        {
            datosDelSistema = datos;
            albumAEditar = album;
            imagenesAgregadas = new List<string>();
            InitializeComponent();
            GuardarAlbumButton.Hide();
            labelCreaTuAlbum.Hide();
            NombreAlbumTextBox.Hide();
            ConfirmarButton.Show();
            cargarImagenesAlControlador();
        }

        public string AbrirFileChooser()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            OpenFileDialog pictureFileDialog = openFileDialog;
            string nombreArchivo = null;
            pictureFileDialog.Title = "Open Image";
            pictureFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (pictureFileDialog.ShowDialog() == DialogResult.OK)
            {
                nombreArchivo = pictureFileDialog.FileName;

            }
            return nombreArchivo;
        }

        private void botonAgregar1_Click(object sender, EventArgs e)
        {
            imagen.ImageLocation = AbrirFileChooser();
            imagenesAgregadas.Add(imagen.ImageLocation);
        }

        private void botonBorrar1_Click(object sender, EventArgs e)
        {
            imagen.Image = null;
            imagenesAgregadas.Remove(imagen.ImageLocation);
            
        }

        private void botonAgregar2_Click(object sender, EventArgs e)
        {
            imagen2.ImageLocation = AbrirFileChooser();
            imagenesAgregadas.Add(imagen2.ImageLocation);
            
        }

        private void botonBorrar2_Click(object sender, EventArgs e)
        {
            imagen2.Image = null;
            imagenesAgregadas.Remove(imagen2.ImageLocation);
            
        }

        private void botonAgregar3_Click(object sender, EventArgs e)
        {
            imagen3.ImageLocation = AbrirFileChooser();
            imagenesAgregadas.Add(imagen3.ImageLocation);
        }

        private void botonBorrar3_Click(object sender, EventArgs e)
        {
            imagen3.Image = null;
            imagenesAgregadas.Remove(imagen3.ImageLocation);
        }

        private void botonAgregar4_Click(object sender, EventArgs e)
        {
            imagen4.ImageLocation = AbrirFileChooser();
            imagenesAgregadas.Add(imagen4.ImageLocation);
        }

        private void botonBorrar4_Click(object sender, EventArgs e)
        {
            imagen4.Image = null;
            imagenesAgregadas.Remove(imagen4.ImageLocation);
        }

        private void botonAgregar5_Click(object sender, EventArgs e)
        {
            imagen5.ImageLocation = AbrirFileChooser();
            imagenesAgregadas.Add(imagen5.ImageLocation);
        }

        private void botonBorrar5_Click(object sender, EventArgs e)
        {
            imagen5.Image = null;
            imagenesAgregadas.Remove(imagen5.ImageLocation);
        }

        private void botonAgregar6_Click(object sender, EventArgs e)
        {
            imagen6.ImageLocation = AbrirFileChooser();
            imagenesAgregadas.Add(imagen6.ImageLocation);
        }

        private void botonBorrar6_Click(object sender, EventArgs e)
        {
            imagen6.Image = null;
            imagenesAgregadas.Remove(imagen6.ImageLocation);
        }

        private void botonAgregar7_Click(object sender, EventArgs e)
        {
            imagen7.ImageLocation = AbrirFileChooser();
            imagenesAgregadas.Add(imagen7.ImageLocation);
        }

        private void botonBorrar7_Click(object sender, EventArgs e)
        {
            imagen7.Image = null;
            imagenesAgregadas.Remove(imagen7.ImageLocation);
        }

        private void botonAgregar8_Click(object sender, EventArgs e)
        {
            imagen8.ImageLocation = AbrirFileChooser();
            imagenesAgregadas.Add(imagen8.ImageLocation);
        }

        private void botonBorrar8_Click(object sender, EventArgs e)
        {
            imagen8.Image = null;
            imagenesAgregadas.Remove(imagen8.ImageLocation);
        }

        private void botonAgregar9_Click(object sender, EventArgs e)
        {
            imagen9.ImageLocation = AbrirFileChooser();
            imagenesAgregadas.Add(imagen9.ImageLocation);
        }

        private void botonBorrar9_Click(object sender, EventArgs e)
        {
            imagen9.Image = null;
            imagenesAgregadas.Remove(imagen9.ImageLocation);
        }

        private void botonAgregar10_Click(object sender, EventArgs e)
        {
            imagen10.ImageLocation = AbrirFileChooser();
            imagenesAgregadas.Add(imagen10.ImageLocation);
        }

        private void botonBorrar10_Click(object sender, EventArgs e)
        {
            imagen10.Image = null;
            imagenesAgregadas.Remove(imagen10.ImageLocation);
        }

        private void GuardarAlbumButton_Click(object sender, EventArgs e)
        {
            try
            {
                albumACrear = new Album(datosDelSistema.usuarioLogeado);
                foreach (var imagen in imagenesAgregadas)
                {
                    albumACrear.Agregar(imagen);
                }
                if (imagenesAgregadas.Count == 0)
                {
                    MessageBox.Show("Seleccione al menos una imagen para el album", "Atencion", MessageBoxButtons.OK);
                }
                else
                {
                    albumACrear.fechaCreacion = DateTime.Now;
                    albumACrear.NombreAlbum = NombreAlbumTextBox.Text;
                    datosDelSistema.usuarioLogeado.Albumes.Add(albumACrear);
                    albumACrear.Tipo = "Album";
                    basePublicaciones.Agregar(albumACrear);
                    MessageBox.Show($"Se creo el album {NombreAlbumTextBox.Text} con exito!", "Confirmacion", MessageBoxButtons.OK);
                    datosDelSistema.Reporte.Add($"{datosDelSistema.usuarioLogeado.NombreUsuario} creo un album {DateTime.Now}");
                    this.Dispose();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK);
            }
        }

        public void cargarImagenesAlControlador() 
        {
            int cantidadDeFotos = albumAEditar.TodasLasFotos().Count;
            int contador = 0;
            foreach (var box in imagenes()) 
            {
                if (contador < cantidadDeFotos)
                {
                    box.ImageLocation = albumAEditar.TodasLasFotos()[contador];
                    contador++;
                }
                else 
                {
                    box.Image = null;
                }
            }
        }

        public List<PictureBox> imagenes()
        {
            List<PictureBox> retorno = new List<PictureBox>();
            retorno.Add(imagen);
            retorno.Add(imagen2);
            retorno.Add(imagen3);
            retorno.Add(imagen4);
            retorno.Add(imagen5);
            retorno.Add(imagen6);
            retorno.Add(imagen7);
            retorno.Add(imagen8);
            retorno.Add(imagen9);
            retorno.Add(imagen10);
            return retorno;
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            nombreAlbum = albumAEditar.NombreAlbum;
            datosDelSistema.usuarioLogeado.Albumes.Remove(albumAEditar);
            albumACrear = new Album(datosDelSistema.usuarioLogeado);
            albumACrear.NombreAlbum = nombreAlbum;
            foreach (var imagen in imagenes()) {
                if (imagen.Image == null || imagenesAgregadas.Contains(imagen.ImageLocation))
                {

                }
                else 
                {
                    imagenesAgregadas.Add(imagen.ImageLocation);
                }
            }
            foreach (var imagen in imagenesAgregadas)
            {
                albumACrear.Agregar(imagen);                
            }
            if (imagenesAgregadas.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una imagen para el album", "Atencion", MessageBoxButtons.OK);
            }
            else
            {
                albumACrear.fechaCreacion = DateTime.Now;
                datosDelSistema.usuarioLogeado.Albumes.Add(albumACrear);
                MessageBox.Show($"Se modifico el album {nombreAlbum} con exito!", "Confirmacion", MessageBoxButtons.OK);
                this.Dispose();
            }

        }

    }
}
