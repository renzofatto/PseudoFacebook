using DataAccess;
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
    public partial class VentanaLogin : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private Datos datosDelSistema;
        private ILibro baseDeDatos;
        private IPublicaciones baseDePublicaciones;
        public VentanaLogin(Datos datos, ILibro dbUsers, IPublicaciones dBPublicaciones)
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

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void IniciarSesionButton_Click(object sender, EventArgs e)
        {
            
            VentanaCredenciales ventanaCredenciales = new VentanaCredenciales(datosDelSistema, baseDeDatos, baseDePublicaciones);
            ventanaCredenciales.Show();
            this.Hide();
        }

        private void RegistrarseButton_Click(object sender, EventArgs e)
        {
            VentanaRegistroUsuario ventanaRegistro = new VentanaRegistroUsuario(datosDelSistema, baseDeDatos, baseDePublicaciones);
            ventanaRegistro.Show();
            this.Hide();
        }

        private void VentanaLogin_FormClosing(object sender, FormClosingEventArgs e)
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
