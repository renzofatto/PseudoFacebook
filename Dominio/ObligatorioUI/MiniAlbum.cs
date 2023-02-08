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
    public partial class MiniAlbum : UserControl
    {
        public MiniAlbum(string imagePath)
        {
            InitializeComponent();
            this.imagen.Image = new Bitmap(imagePath);
            Refresh();
        }
    }
}
