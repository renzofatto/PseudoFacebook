using DataAccess;
using Dominio;
using MaterialSkin.Controls;
using ObligatorioDisenoDeAplicaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObligatorioUI
{
    public partial class VentanaPrincipal : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private Datos datosDelSistema;
        private ILibro dbUsers;
        private IPublicaciones dbPublicaciones;
        public VentanaPrincipal(Datos datos, ILibro baseDeDatos, IPublicaciones baseDePublicaciones)
        {
            InitializeComponent();
            datosDelSistema = datos;
            dbUsers = baseDeDatos;
            dbPublicaciones = baseDePublicaciones;
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            SetupMaterialComponents();
            CargarListaDeNoSeguidos();
            CargarListaSeguidos();
            CargarEstados();
            CargarAlbumes();
            CargarFeed();
            CargarJuegos();
            feedMainPanel.HorizontalScroll.Maximum = 0;
            feedMainPanel.AutoScroll = false;
            feedMainPanel.VerticalScroll.Visible = false;
            feedMainPanel.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(new ExpandableBookList(datosDelSistema));
            cerrarReporteButton.Hide();
            Reportes();
        }

        private void Reportes()
        {

            reportList.Hide();
            if (datosDelSistema.usuarioLogeado.Administrador)
            {
                reporteButton.Show();
            }
            else
            {
                reporteButton.Hide();
                cerrarReporteButton.Hide();
            }
        }

        private void CargarFeed()
        {
            feedMainPanel.Controls.Add(new Feed(datosDelSistema));
        }

        private void CargarJuegos()
        {
            panelListaJuegos.Controls.Add(new JuegoItemList(datosDelSistema));
            agregarJuegosButton.Hide();
            juegosButton.Hide();
            controlesAdminLabel.Hide();
            eliminarJuegosButton.Hide();
            if (datosDelSistema.usuarioLogeado.Administrador)
            {
                eliminarJuegosButton.Show();
                agregarJuegosButton.Show();
                juegosButton.Show();
                controlesAdminLabel.Show();
            }
        }

        public void SetupMaterialComponents()
        {
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo800, MaterialSkin.Primary.Indigo200, MaterialSkin.Accent.DeepPurple200, MaterialSkin.TextShade.WHITE);
        }
        public void CargarListaSeguidos()
        {
            foreach (var usuario in datosDelSistema.usuarioLogeado.Seguidos) {
                if (usuario.NombreUsuario != datosDelSistema.usuarioLogeado.NombreUsuario)
                {
                    SeguidosListBox.Items.Add(usuario.NombreUsuario);
                }
            }
        }



        public void CargarListaDeNoSeguidos() 
        {
            foreach (var usuario in datosDelSistema.UsuariosRegistrados)
            {
                if (!datosDelSistema.usuarioLogeado.Seguidos.Contains(usuario) && !usuario.Equals(datosDelSistema.usuarioLogeado))
                {
                    NoSeguidosListBox.Items.Add(usuario.NombreUsuario);
                }
            }
        }

        public void CargarAlbumes()
        {
            flowLayoutPanel1.Controls.Clear();
            albumesListBox.Items.Clear();
            foreach (var album in datosDelSistema.usuarioLogeado.Albumes)
            {
                albumesListBox.Items.Add(album);
            }
            flowLayoutPanel1.Controls.Add(new ExpandableBookList(datosDelSistema));
            flowLayoutPanel1.Show();


        }

        private void VentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quieres cerrar la ventana?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void PuntajeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void JugarButton_Click(object sender, EventArgs e)
        {

        }

        private void CerrarSesionButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres cerrar sesion?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                datosDelSistema.Reporte.Add($"{datosDelSistema.usuarioLogeado.NombreUsuario} cerro sesion {DateTime.Now}");
                VentanaLogin vueltaAlInicioDeSesion = new VentanaLogin(datosDelSistema, dbUsers, dbPublicaciones);
                vueltaAlInicioDeSesion.Show();
                datosDelSistema.usuarioLogeado = null;
            }
        }

        private void SeguirButton_Click(object sender, EventArgs e)
        {
            int cantidadUsuariosSinContarUsuarioLogeado = 1;
            foreach (var usuario in datosDelSistema.UsuariosRegistrados)
            {
                if (datosDelSistema.UsuariosRegistrados.Count > cantidadUsuariosSinContarUsuarioLogeado && NoSeguidosListBox.SelectedItem != null)
                {
                    if (usuario.NombreUsuario.Equals(NoSeguidosListBox.SelectedItem.ToString()))
                    {
                        datosDelSistema.usuarioLogeado.SeguirA(usuario);
                        cantidadUsuariosSinContarUsuarioLogeado++;
                        datosDelSistema.Reporte.Add($"{datosDelSistema.usuarioLogeado.NombreUsuario} siguio a {usuario.NombreUsuario} {DateTime.Now}");
                        ReloadVentanaUsuarios();
                    }
                }
            }
        }

        public void ReloadVentanaUsuarios()
        {
            SeguidosListBox.Items.Clear();
            NoSeguidosListBox.Items.Clear();
            CargarListaDeNoSeguidos();
            CargarListaSeguidos();
        }

        public void CargarEstados()
        {
            estadosListBox.Items.Clear();
            foreach (var estado in datosDelSistema.usuarioLogeado.Estados)
            {
                estadosListBox.Items.Add(estado);
            }
        }

        private void CompartirButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                Estado estado = new Estado(datosDelSistema.usuarioLogeado, estadoTextBox.Text);
                datosDelSistema.usuarioLogeado.Estados.Add(estado);
                estado.Tipo = "Estado";
                dbPublicaciones.Agregar(estado);
                estadosListBox.Items.Add(estado.ToString());
                datosDelSistema.Reporte.Add($"{datosDelSistema.usuarioLogeado.NombreUsuario} publico un estado {DateTime.Now}");
                estadoTextBox.Clear();
                errorProvider1.SetError(estadoTextBox, null);
            }
            catch (PublicacionException ex)
            {
                errorProvider1.SetError(estadoTextBox, ex.Message);
            }
        }

        private void eliminarEstadoButton_Click(object sender, EventArgs e)
        {
            if (estadosListBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un item de la lista para eliminar", "Atencion", MessageBoxButtons.OK);
            }
            else
            {
                Estado estadoAEliminar = null;
                string estadoSeleccionadoDeLaLista = estadosListBox.SelectedItem.ToString();
                foreach (var estado in datosDelSistema.usuarioLogeado.Estados)
                {
                    if (estado.ToString().Equals(estadoSeleccionadoDeLaLista) && estadoAEliminar == null)
                    {
                        estadoAEliminar = estado;
                    }
                }
                if (estadoAEliminar != null)
                {
                    datosDelSistema.usuarioLogeado.Estados.Remove(estadoAEliminar);
                    dbPublicaciones.BorrarEstado(estadoAEliminar.Id);
                    estadosListBox.Items.Remove(estadosListBox.SelectedItem);
                    CargarEstados();
                }
            }
        }

        private void EscuchandoCompartirButton_Click(object sender, EventArgs e)
        {
            if (CancionTextBox.Text.Trim() == "" || ArtistaTextBox.Text.Trim() == "" || AlbumTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Por favor rellene TODOS los campos.", "Atencion", MessageBoxButtons.OK);
            }
            else
            {
                Escuchando queEstoyEscuchando = new Escuchando(datosDelSistema.usuarioLogeado, CancionTextBox.Text, ArtistaTextBox.Text, AlbumTextBox.Text);
                datosDelSistema.usuarioLogeado.Escuchadas.Add(queEstoyEscuchando);
                MessageBox.Show("Se posteo que estas escuchando la cancion " + CancionTextBox.Text + " con exito!", "Exito!", MessageBoxButtons.OK);
                queEstoyEscuchando.Tipo = "Escuchando";
                dbPublicaciones.Agregar(queEstoyEscuchando);
                datosDelSistema.Reporte.Add($"{datosDelSistema.usuarioLogeado.NombreUsuario} escucho la cancion {queEstoyEscuchando.Cancion} {DateTime.Now}");
                CancionTextBox.Clear();
                ArtistaTextBox.Clear();
                AlbumTextBox.Clear();
            }
        }

        private void JuegosTab_Click(object sender, EventArgs e)
        {

        }

        private void agregarJuegosButton_Click_1(object sender, EventArgs e)
        {
            panelListaJuegos.Controls.Clear();
            panelListaJuegos.Controls.Add(new AgregadorDeJuego(datosDelSistema));
        }

        private void juegosButton_Click(object sender, EventArgs e)
        {
            panelListaJuegos.Controls.Clear();
            panelListaJuegos.Controls.Add(new JuegoItemList(datosDelSistema));
        }

        private void eliminarJuegosButton_Click(object sender, EventArgs e)
        {
            panelListaJuegos.Controls.Clear();
            panelListaJuegos.Controls.Add(new EliminadorDeJuegos(datosDelSistema));
        }

        private void panel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            CargarAlbumes();
            albumesListBox.Show();
            AgregarAlbumButton.Show();
            EliminarAlbumButton.Show();
            EditarAlbumButton.Show();
            SeleccionarEliminarLabel.Show();
        }

        private void AgregarAlbum_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Hide();
            albumesListBox.Hide();
            AgregarAlbumButton.Hide();
            EliminarAlbumButton.Hide();
            EditarAlbumButton.Hide();
            SeleccionarEliminarLabel.Hide();
            
            panel1.Controls.Add(new AlbumParaCrear(datosDelSistema, dbUsers, dbPublicaciones));
        }

        private void EliminarAlbumButton_Click(object sender, EventArgs e)
        {
            if (albumesListBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un item de la lista para eliminar", "Atencion", MessageBoxButtons.OK);
            }
            else
            {
                Album albumAEliminar = null;
                string albumSeleccionado = albumesListBox.SelectedItem.ToString();
                foreach (var album in datosDelSistema.usuarioLogeado.Albumes)
                {
                    if (album.ToString().Equals(albumSeleccionado) && albumAEliminar == null)
                    {
                        albumAEliminar = album;
                    }
                }
                if (albumAEliminar != null)
                {
                    datosDelSistema.usuarioLogeado.Albumes.Remove(albumAEliminar);
                    albumesListBox.Items.Remove(albumesListBox.SelectedItem);
                    CargarAlbumes();
                }
            }
        }

        private void EditarAlbumButton_Click(object sender, EventArgs e)
        {
            if (albumesListBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un item de la lista para editar", "Atencion", MessageBoxButtons.OK);
            }
            else
            {
                string nombreDelAlbumAEditarEnLaLista = albumesListBox.SelectedItem.ToString();
                Album albumAEditar = null;
                foreach (var album in datosDelSistema.usuarioLogeado.Albumes)
                {
                    if (album.ToString().Equals(nombreDelAlbumAEditarEnLaLista))
                    {
                        albumAEditar = album;
                    }
                }
                flowLayoutPanel1.Hide();
                albumesListBox.Hide();
                EliminarAlbumButton.Hide();
                EditarAlbumButton.Hide();
                SeleccionarEliminarLabel.Hide();
                panel1.Controls.Add(new AlbumParaCrear(datosDelSistema, albumAEditar));
            }
        }

        private void materialTabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            feedMainPanel.Controls.Clear();
            CargarFeed();
        }

        private void reporteButton_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void CargarReporte()
        {
            reportList.Items.Clear();
            foreach (var reporte in datosDelSistema.Reporte)
            {
                reportList.Items.Add(reporte);
            }
            reportList.Show();
            cerrarReporteButton.Show();
        }

        private void cerrarReporteButton_Click(object sender, EventArgs e)
        {
            reportList.Hide();
            cerrarReporteButton.Hide();
        }

        private void generarPuntajesButton_Click(object sender, EventArgs e)
        {
            puntajesListBox.Items.Clear();
            if (ManejadorListas.JugadasDe(datosDelSistema.usuarioLogeado, ManejadorListas.UnirJugadasDeJuegos(datosDelSistema.JuegosCreados)).Count() > 0)
            {
                List<string> puntajes = Juego.GenerarPuntajesMaximos(datosDelSistema);
                foreach (var puntaje in puntajes)
                {
                    puntajesListBox.Items.Add(puntaje);
                }
            }
            else
            {
                MessageBox.Show("Todavia no has jugado a nada!", "Puntajes Maximos", MessageBoxButtons.OK);
            }
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Encuesta encuesta = new Encuesta(datosDelSistema.usuarioLogeado, PreguntaMaterialTextBox.Text);
                Opcion opcion1 = new Opcion(Opcion1TextBox.Text);
                Opcion opcion2 = new Opcion(Opcion2TextBox.Text);
                encuesta.AgregarOpcion(opcion1);
                encuesta.AgregarOpcion(opcion2);
                if (!Opcion3TextBox.Text.Equals(""))
                {
                    Opcion opcion3 = new Opcion(Opcion3TextBox.Text);
                    encuesta.AgregarOpcion(opcion3);
                    if (!Opcion4TextBox.Text.Equals(""))
                    {
                        Opcion opcion4 = new Opcion(Opcion4TextBox.Text);
                        encuesta.AgregarOpcion(opcion4);
                        if (!Opcion5TextBox.Text.Equals(""))
                        {
                            Opcion opcion5 = new Opcion(Opcion5TextBox.Text);
                            encuesta.AgregarOpcion(opcion5);
                        }
                    }
                }
                datosDelSistema.usuarioLogeado.Encuestas.Add(encuesta);
                PreguntaMaterialTextBox.Clear();
                Opcion1TextBox.Clear();
                Opcion2TextBox.Clear();
                Opcion3TextBox.Clear();
                Opcion4TextBox.Clear();
                Opcion5TextBox.Clear();
                errorProvider1.SetError(CompartirMaterialButton, null);
                datosDelSistema.Reporte.Add($"{datosDelSistema.usuarioLogeado.NombreUsuario} publico una encuesta {DateTime.Now}");
            }
            catch (EncuestaException ex)
            {
                errorProvider1.SetError(CompartirMaterialButton, ex.Message);
            }
            catch (OpcionException ex)
            {
                errorProvider1.SetError(CompartirMaterialButton, ex.Message);
            }
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
