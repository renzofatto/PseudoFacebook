using DataAccess;
using Dominio;
using MaterialSkin.Controls;
using ObligatorioDisenoDeAplicaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObligatorioUI
{
    public partial class VentanaRegistroUsuario : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private Datos datosDelSistema;
        private ILibro baseDeUsuarios;
        private IPublicaciones baseDePublicaciones;
        private FileInfo selectedImage;
        private Usuario usuario;
        private const int LARGO_MAX_PATH = 260;

        public VentanaRegistroUsuario(Datos datos, ILibro dbUsers, IPublicaciones dbPublicaciones)
        {
            InitializeComponent();
            datosDelSistema = datos;
            baseDeUsuarios = dbUsers;
            baseDePublicaciones = dbPublicaciones;
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            SetupMaterialComponents();
            ContrasenaTextBox.Password = true;
            newProfilePicture.Image = newProfilePicture.InitialImage;
            usuario = new Usuario();
        }

        public void SetupMaterialComponents() {
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo800, MaterialSkin.Primary.Indigo200, MaterialSkin.Accent.DeepPurple200, MaterialSkin.TextShade.WHITE);

        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaLogin ventanaLogin = new VentanaLogin(datosDelSistema, baseDeUsuarios, baseDePublicaciones);
            ventanaLogin.Show();
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            OpenFileDialog pictureFileDialog = openFileDialog;
            pictureFileDialog.Title = "Open Image";
            pictureFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (pictureFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImage = new FileInfo(pictureFileDialog.FileName);
                profilePictureFilenameLabel.Text = selectedImage.Name;
                newProfilePicture.Image = new Bitmap(pictureFileDialog.FileName);
            }
        }

        private void GuardarUsuarioButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidacionDeTodo())
                {
                    Usuario nuevoUsuario = new Usuario
                    {
                        Nombre = NombreTextBox.Text,
                        Apellido = ApellidoTextBox.Text,
                        NombreUsuario = NombreUsuarioTextBox.Text,
                        FechaNacimiento = fechaNacimientoPicker.Value,
                        Contrasena = ContrasenaTextBox.Text
                    };
                    Direccion nuevaDireccion = new Direccion();
                    nuevaDireccion.Calle = CalleTextBox.Text;
                    nuevaDireccion.Ciudad = CiudadTextBox.Text;
                    nuevaDireccion.Pais = PaisTextBox.Text;
                    nuevoUsuario.DireccionPersona = nuevaDireccion;
                    if (selectedImage == null)
                    {
                        nuevoUsuario.PicturePath = newProfilePicture.ImageLocation;
                    }
                    else
                    {
                        nuevoUsuario.PicturePath = selectedImage.FullName;
                    }

                    datosDelSistema.Reporte.Add($"{nuevoUsuario.NombreUsuario} se registro {DateTime.Now}");
                    baseDeUsuarios.Agregar(nuevoUsuario);
                    ManejoCredeciales.RegistrarUsuario(datosDelSistema,nuevoUsuario);
                    datosDelSistema.Reporte.Add($"{nuevoUsuario.NombreUsuario} se registro {DateTime.Now}");
                    LimpiarVentana();
                    MessageBox.Show("Usuario creado correctamente");
                    LimpiarVentana();
                }
            }
            catch (ArgumentException ex) 
            {
                errorProvider1.SetError(GuardarUsuarioButton, ex.Message);

            }
        }

        public void LimpiarVentana() {
            NombreTextBox.Clear();
            ApellidoTextBox.Clear();
            ContrasenaTextBox.Clear();
            errorProvider1.Clear();
            NombreUsuarioTextBox.Clear();
            CalleTextBox.Clear();
            CiudadTextBox.Clear();
            PaisTextBox.Clear();
            profilePictureFilenameLabel.ResetText();
            newProfilePicture.Image = newProfilePicture.InitialImage;
        }

        public bool NombreUsuarioValido() {
            bool validado = false;
            
            if (ManejoCredeciales.ChequeoPalabraNotNull(NombreUsuarioTextBox.Text))
            {
                errorProvider1.SetError(NombreUsuarioTextBox, "Nombre de usuario requerido!");
                validado = false;
            }
            else if (!ManejoCredeciales.ChequeoRegexLetrasYNumeros(NombreUsuarioTextBox.Text))
            {
                errorProvider1.SetError(NombreUsuarioTextBox, "Nombre de usuario invalido! Tiene que tener mas de 2 caracteres!");
                validado = false;
            }
            else
            {
                foreach (var usuario in datosDelSistema.UsuariosRegistrados)
                {
                    if (usuario.NombreUsuario.Equals(NombreUsuarioTextBox.Text))
                    {
                        errorProvider1.SetError(NombreUsuarioTextBox, "Este nombre de usuario ya existe, seleccione otro por favor!");
                        validado = false;
                    }
                    else {
                        errorProvider1.SetError(NombreUsuarioTextBox, null);
                        validado = true;
                    }
                }
                
                
            }
            return validado;
        }

        public bool ContrasenaValida()
        {
            bool validado = false;
            if (ManejoCredeciales.ChequeoPalabraNotNull(ContrasenaTextBox.Text))
            {
                errorProvider1.SetError(ContrasenaTextBox, "Contraseña requerida!");
                validado = false;
            }
            else if (!ManejoCredeciales.ContrasenaChequeoRegexLetrasYNumeros(ContrasenaTextBox.Text))
            {
                errorProvider1.SetError(ContrasenaTextBox, "Contraseña invalida! Tiene que tener mas de 7 caracteres!");
                validado = false;
            }
            else
            {
                errorProvider1.SetError(ContrasenaTextBox, null);
                validado = true;
                
            }
            return validado;
        }

        public bool NombreValido()
        {
            bool validado;
            if (ManejoCredeciales.ChequeoPalabraNotNull(NombreTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "Nombre requerido!");
                validado = false;
            }
            else if (!ManejoCredeciales.ChequeoRegexLetrasYNumeros(NombreTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "Nombre invalido! Tiene que tener mas de 2 caracteres");
                validado = false;
            }
            else
            {
                errorProvider1.SetError(NombreTextBox, null);
                validado = true;
                
            }
            return validado;
        }

        public bool ApellidoValido()
        {
            bool validado;
            if (ManejoCredeciales.ChequeoPalabraNotNull(ApellidoTextBox.Text))
            {
                errorProvider1.SetError(ApellidoTextBox, "Apellido requerido!");
                validado = false;
            }
            else if (!ManejoCredeciales.ChequeoRegexLetrasYNumeros(ApellidoTextBox.Text))
            {
                errorProvider1.SetError(ApellidoTextBox, "Apellido invalido! Tiene que tener mas de 2 caracteres.");
                validado = false;
            }
            else
            {
                errorProvider1.SetError(ApellidoTextBox, null);
                validado = true;
               
            }
            return validado;
        }

        public bool PaisValido()
        {
            bool validado;
            if (ManejoCredeciales.ChequeoPalabraNotNull(PaisTextBox.Text))
            {
                errorProvider1.SetError(PaisTextBox, "Pais requerido!");
                validado = false;
            }
            else if (!ManejoCredeciales.ChequeoRegexLetrasYNumeros(PaisTextBox.Text))
            {
                errorProvider1.SetError(PaisTextBox, "Pais invalido! Tiene que tener mas de 3 caracteres.");
                validado = false;
            }
            else
            {
                errorProvider1.SetError(PaisTextBox, null);
                validado = true;
                
            }
            return validado;
        }
        public bool CiudadValida()
        {
            bool validado;
            if (ManejoCredeciales.ChequeoPalabraNotNull(CiudadTextBox.Text))
            {
                errorProvider1.SetError(CiudadTextBox, "Ciudad requerida!");
                validado = false;
            }
            else if (!ManejoCredeciales.ChequeoRegexLetrasYNumeros(CiudadTextBox.Text))
            {
                errorProvider1.SetError(CiudadTextBox, "Ciudad invalida! Tiene que tener mas de 2 caracteres.");
                validado = false;
            }
            else
            {
                errorProvider1.SetError(CiudadTextBox, null);
                validado = true;
               
            }
            return validado;
        }

        public bool CalleValida()
        {
            bool validado;
            if (ManejoCredeciales.ChequeoPalabraNotNull(CalleTextBox.Text))
            {
                errorProvider1.SetError(CalleTextBox, "Calle requerida!");
                validado = false;
            }
            else if (!ManejoCredeciales.ChequeoRegexLetrasYNumeros(CalleTextBox.Text))
            {
                errorProvider1.SetError(CalleTextBox, "Calle invalida! Tiene que tener mas de 2 caracteres.");
                validado = false;
            }
            else
            {
                errorProvider1.SetError(CalleTextBox, null);
                validado = true;
                
            }
            return validado;
        }
        public bool ImagenValida()
        {
            bool validado;
            if (selectedImage == null)
            {
                errorProvider1.SetError(ChooseFileButton, "Por favor, seleccione una imagen!");
                validado = false;
            }
            else if (selectedImage.FullName.Length > LARGO_MAX_PATH)
            {
                errorProvider1.SetError(ChooseFileButton, "Por favor, seleccione una imagen con un path menor a 260 caracteres!");
                validado = false;
            }
            else
            {
                return true;
            }
            return validado;
        }

        private void NombreUsuarioTextBox_Validating(object sender, CancelEventArgs e)
        {
            NombreUsuarioValido();
        }
        private void ContrasenaTextBox_Validating(object sender, CancelEventArgs e)
        {
            ContrasenaValida();
        }

        private void NombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            NombreValido();
        }

        private void ApellidoTextBox_Validating(object sender, CancelEventArgs e)
        {
            ApellidoValido();
        }

        private void PaisTextBox_Validating(object sender, CancelEventArgs e)
        {
            PaisValido();
        }

        private void CiudadTextBox_Validating(object sender, CancelEventArgs e)
        {
            CiudadValida();
        }

        private void CalleTextBox_Validating(object sender, CancelEventArgs e)
        {
            CalleValida();
        }

        private void newProfilePicture_Validating(object sender, CancelEventArgs e)
        {
            ImagenValida();
        }


        private bool ValidacionDeTodo() {
            bool nombreUsuarioValido = NombreUsuarioValido();
            bool contrasenaValida = ContrasenaValida();
            bool nombreValido = NombreValido();
            bool apellidoValido = ApellidoValido();
            bool paisValido = PaisValido();
            bool ciudadValida = CiudadValida();
            bool calleValida = CalleValida();
            bool imagenValida = ImagenValida();
            bool todasLasValidaciones = true;
            if (nombreUsuarioValido && contrasenaValida && nombreValido && apellidoValido && paisValido && ciudadValida && calleValida && imagenValida)
            {
                // MessageBox.Show("Usuario creado correctamente");
                todasLasValidaciones = true;
            }
            else {
                MessageBox.Show("Ingrese datos correctamente");
                todasLasValidaciones = false;
            }
            return todasLasValidaciones;
        
        }

        private void VentanaRegistroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quieres cerrar la ventana?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                Environment.Exit(1);
            }
            else
            {
                e.Cancel = true;
            }
                
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ApellidoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
