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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObligatorioUI
{
    public partial class VentanaCredenciales : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private Datos datosDelSistema;
        private ILibro baseDeDatos;
        private IPublicaciones baseDePublicaciones;
        public VentanaCredenciales(Datos datos, ILibro dbUsers, IPublicaciones dBPublicaciones)
        {
            datosDelSistema = datos;
            baseDeDatos = dbUsers;
            baseDePublicaciones = dBPublicaciones;
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            SetupMaterialComponents();
        }
        public void SetupMaterialComponents()
        {
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo800, MaterialSkin.Primary.Indigo200, MaterialSkin.Accent.DeepPurple200, MaterialSkin.TextShade.WHITE);
            ContrasenaTextBox.Password = true;
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaLogin ventanaLogin = new VentanaLogin(datosDelSistema, baseDeDatos, baseDePublicaciones);
            ventanaLogin.Show();

        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text) || string.IsNullOrWhiteSpace(ContrasenaTextBox.Text))
            {
                MessageBox.Show("No puede ingresar un campo vacio!", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ManejoCredeciales.InicioSesion(UsuarioTextBox.Text, ContrasenaTextBox.Text,datosDelSistema, baseDeDatos))
                {
                    VentanaPrincipal ventanaPrincipal = new VentanaPrincipal(datosDelSistema, baseDeDatos, baseDePublicaciones);
                    ventanaPrincipal.Show();
                    datosDelSistema.Reporte.Add($"{datosDelSistema.usuarioLogeado.NombreUsuario} inicio sesion {DateTime.Now}");
                    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario o la contrasena son incorrectos, por favor vuelva a intentarlo", "No se pudo iniciar sesion", MessageBoxButtons.OK);
                }
            }

        }

        private void VentanaCredenciales_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
