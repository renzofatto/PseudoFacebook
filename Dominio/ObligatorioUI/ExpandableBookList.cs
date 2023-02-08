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
    public partial class ExpandableBookList : UserControl
    {
        private Datos datosDelSistema;
        public ExpandableBookList(Datos datos)
        {
            this.datosDelSistema = datos;
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            this.panel.Controls.Clear();
            foreach (var album in datosDelSistema.usuarioLogeado.Albumes) {
                IList<Control> miniFotos = album.TodasLasFotos().Select(imagenes => (Control) new MiniAlbum(imagenes)).ToList();

                var expandableBook = new ExpandableBook(
                    album.NombreAlbum,
                    miniFotos
                  );
                this.panel.Controls.Add(expandableBook);
                
            }
            Refresh();
        }

        private void ExpandableBookList_VisibleChanged(object sender, EventArgs e)
        {
            LoadBooks();
        }
    }
}

