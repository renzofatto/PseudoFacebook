
using System;

namespace ObligatorioUI
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.InicioTab = new System.Windows.Forms.TabPage();
            this.cerrarReporteButton = new MaterialSkin.Controls.MaterialButton();
            this.reportList = new System.Windows.Forms.ListBox();
            this.reporteButton = new MaterialSkin.Controls.MaterialButton();
            this.feedMainPanel = new System.Windows.Forms.Panel();
            this.MiraGenteLabel = new MaterialSkin.Controls.MaterialLabel();
            this.UsuariosTab = new System.Windows.Forms.TabPage();
            this.NoSeguidosListBox = new System.Windows.Forms.ListBox();
            this.SeguidosListBox = new System.Windows.Forms.ListBox();
            this.SeguirButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.UsuariosDisponiblesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AlbumTab = new System.Windows.Forms.TabPage();
            this.albumesListBox = new System.Windows.Forms.ListBox();
            this.EditarAlbumButton = new MaterialSkin.Controls.MaterialButton();
            this.EliminarAlbumButton = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AgregarAlbumButton = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SeleccionarEliminarLabel = new MaterialSkin.Controls.MaterialLabel();
            this.JuegosTab = new System.Windows.Forms.TabPage();
            this.puntajesListBox = new System.Windows.Forms.ListBox();
            this.generarPuntajesButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.controlesAdminLabel = new MaterialSkin.Controls.MaterialLabel();
            this.eliminarJuegosButton = new MaterialSkin.Controls.MaterialButton();
            this.juegosButton = new MaterialSkin.Controls.MaterialButton();
            this.agregarJuegosButton = new MaterialSkin.Controls.MaterialButton();
            this.panelListaJuegos = new System.Windows.Forms.Panel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.EscuchandoTab = new System.Windows.Forms.TabPage();
            this.EscuchandoCompartirButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.AlbumTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.ArtistaTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.CancionTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.EstadoTab = new System.Windows.Forms.TabPage();
            this.eliminarEstadoButton = new MaterialSkin.Controls.MaterialButton();
            this.listaEstadosLabel = new MaterialSkin.Controls.MaterialLabel();
            this.estadosListBox = new System.Windows.Forms.ListBox();
            this.CompartirButton = new MaterialSkin.Controls.MaterialButton();
            this.estadoTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.EncuestaTab = new System.Windows.Forms.TabPage();
            this.Opcion5TextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.Opcion4TextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.Opcion3TextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.Opcion2TextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.Opcion1TextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.CompartirMaterialButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.PreguntaMaterialTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.CerrarSesionTab = new System.Windows.Forms.TabPage();
            this.CerrarSesionButton = new MaterialSkin.Controls.MaterialButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialTabControl1.SuspendLayout();
            this.InicioTab.SuspendLayout();
            this.UsuariosTab.SuspendLayout();
            this.AlbumTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.JuegosTab.SuspendLayout();
            this.EscuchandoTab.SuspendLayout();
            this.EstadoTab.SuspendLayout();
            this.EncuestaTab.SuspendLayout();
            this.CerrarSesionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.png");
            this.imageList1.Images.SetKeyName(1, "nuevoUsuario.png");
            this.imageList1.Images.SetKeyName(2, "usuariosVarios.png");
            this.imageList1.Images.SetKeyName(3, "juegos.png");
            this.imageList1.Images.SetKeyName(4, "Musica.png");
            this.imageList1.Images.SetKeyName(5, "Estado.png");
            this.imageList1.Images.SetKeyName(6, "pensando.png");
            this.imageList1.Images.SetKeyName(7, "thinking.png");
            this.imageList1.Images.SetKeyName(8, "group.png");
            this.imageList1.Images.SetKeyName(9, "logoff.png");
            this.imageList1.Images.SetKeyName(10, "album.png");
            this.imageList1.Images.SetKeyName(11, "encuestasincuadraditos.png");
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.InicioTab);
            this.materialTabControl1.Controls.Add(this.UsuariosTab);
            this.materialTabControl1.Controls.Add(this.AlbumTab);
            this.materialTabControl1.Controls.Add(this.JuegosTab);
            this.materialTabControl1.Controls.Add(this.EscuchandoTab);
            this.materialTabControl1.Controls.Add(this.EstadoTab);
            this.materialTabControl1.Controls.Add(this.EncuestaTab);
            this.materialTabControl1.Controls.Add(this.CerrarSesionTab);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1055, 658);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged_1);
            // 
            // InicioTab
            // 
            this.InicioTab.BackColor = System.Drawing.Color.White;
            this.InicioTab.Controls.Add(this.cerrarReporteButton);
            this.InicioTab.Controls.Add(this.reportList);
            this.InicioTab.Controls.Add(this.reporteButton);
            this.InicioTab.Controls.Add(this.feedMainPanel);
            this.InicioTab.Controls.Add(this.MiraGenteLabel);
            this.InicioTab.ImageKey = "home.png";
            this.InicioTab.Location = new System.Drawing.Point(4, 39);
            this.InicioTab.Name = "InicioTab";
            this.InicioTab.Padding = new System.Windows.Forms.Padding(3);
            this.InicioTab.Size = new System.Drawing.Size(1047, 615);
            this.InicioTab.TabIndex = 0;
            this.InicioTab.Text = "Inicio";
            // 
            // cerrarReporteButton
            // 
            this.cerrarReporteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cerrarReporteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cerrarReporteButton.Depth = 0;
            this.cerrarReporteButton.HighEmphasis = true;
            this.cerrarReporteButton.Icon = null;
            this.cerrarReporteButton.Location = new System.Drawing.Point(93, 526);
            this.cerrarReporteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cerrarReporteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cerrarReporteButton.Name = "cerrarReporteButton";
            this.cerrarReporteButton.Size = new System.Drawing.Size(77, 36);
            this.cerrarReporteButton.TabIndex = 5;
            this.cerrarReporteButton.Text = "Cerrar";
            this.cerrarReporteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cerrarReporteButton.UseAccentColor = false;
            this.cerrarReporteButton.UseVisualStyleBackColor = true;
            this.cerrarReporteButton.Click += new System.EventHandler(this.cerrarReporteButton_Click);
            // 
            // reportList
            // 
            this.reportList.FormattingEnabled = true;
            this.reportList.Location = new System.Drawing.Point(7, 6);
            this.reportList.Name = "reportList";
            this.reportList.Size = new System.Drawing.Size(1034, 511);
            this.reportList.TabIndex = 4;
            // 
            // reporteButton
            // 
            this.reporteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reporteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.reporteButton.Depth = 0;
            this.reporteButton.HighEmphasis = true;
            this.reporteButton.Icon = null;
            this.reporteButton.Location = new System.Drawing.Point(7, 526);
            this.reporteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.reporteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.reporteButton.Name = "reporteButton";
            this.reporteButton.Size = new System.Drawing.Size(85, 36);
            this.reporteButton.TabIndex = 3;
            this.reporteButton.Text = "Reporte";
            this.reporteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.reporteButton.UseAccentColor = false;
            this.reporteButton.UseVisualStyleBackColor = true;
            this.reporteButton.Click += new System.EventHandler(this.reporteButton_Click);
            // 
            // feedMainPanel
            // 
            this.feedMainPanel.Location = new System.Drawing.Point(177, 79);
            this.feedMainPanel.Name = "feedMainPanel";
            this.feedMainPanel.Size = new System.Drawing.Size(673, 483);
            this.feedMainPanel.TabIndex = 2;
            // 
            // MiraGenteLabel
            // 
            this.MiraGenteLabel.AutoSize = true;
            this.MiraGenteLabel.Depth = 0;
            this.MiraGenteLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.MiraGenteLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.MiraGenteLabel.Location = new System.Drawing.Point(160, 17);
            this.MiraGenteLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MiraGenteLabel.Name = "MiraGenteLabel";
            this.MiraGenteLabel.Size = new System.Drawing.Size(699, 41);
            this.MiraGenteLabel.TabIndex = 1;
            this.MiraGenteLabel.Text = "Mira lo que esta haciendo la gente que sigues!";
            // 
            // UsuariosTab
            // 
            this.UsuariosTab.BackColor = System.Drawing.Color.White;
            this.UsuariosTab.Controls.Add(this.NoSeguidosListBox);
            this.UsuariosTab.Controls.Add(this.SeguidosListBox);
            this.UsuariosTab.Controls.Add(this.SeguirButton);
            this.UsuariosTab.Controls.Add(this.materialLabel2);
            this.UsuariosTab.Controls.Add(this.UsuariosDisponiblesLabel);
            this.UsuariosTab.ImageKey = "group.png";
            this.UsuariosTab.Location = new System.Drawing.Point(4, 39);
            this.UsuariosTab.Name = "UsuariosTab";
            this.UsuariosTab.Size = new System.Drawing.Size(1047, 615);
            this.UsuariosTab.TabIndex = 2;
            this.UsuariosTab.Text = "Usuarios";
            // 
            // NoSeguidosListBox
            // 
            this.NoSeguidosListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoSeguidosListBox.FormattingEnabled = true;
            this.NoSeguidosListBox.ItemHeight = 20;
            this.NoSeguidosListBox.Location = new System.Drawing.Point(490, 84);
            this.NoSeguidosListBox.Name = "NoSeguidosListBox";
            this.NoSeguidosListBox.Size = new System.Drawing.Size(227, 164);
            this.NoSeguidosListBox.TabIndex = 6;
            // 
            // SeguidosListBox
            // 
            this.SeguidosListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguidosListBox.FormattingEnabled = true;
            this.SeguidosListBox.ItemHeight = 20;
            this.SeguidosListBox.Location = new System.Drawing.Point(70, 84);
            this.SeguidosListBox.Name = "SeguidosListBox";
            this.SeguidosListBox.Size = new System.Drawing.Size(240, 164);
            this.SeguidosListBox.TabIndex = 5;
            // 
            // SeguirButton
            // 
            this.SeguirButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SeguirButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SeguirButton.Depth = 0;
            this.SeguirButton.HighEmphasis = true;
            this.SeguirButton.Icon = null;
            this.SeguirButton.Location = new System.Drawing.Point(567, 267);
            this.SeguirButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SeguirButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SeguirButton.Name = "SeguirButton";
            this.SeguirButton.Size = new System.Drawing.Size(76, 36);
            this.SeguirButton.TabIndex = 4;
            this.SeguirButton.Text = "Seguir!";
            this.SeguirButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SeguirButton.UseAccentColor = false;
            this.SeguirButton.UseVisualStyleBackColor = true;
            this.SeguirButton.Click += new System.EventHandler(this.SeguirButton_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(67, 32);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(147, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Usuarios que sigues!";
            // 
            // UsuariosDisponiblesLabel
            // 
            this.UsuariosDisponiblesLabel.AutoSize = true;
            this.UsuariosDisponiblesLabel.Depth = 0;
            this.UsuariosDisponiblesLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UsuariosDisponiblesLabel.Location = new System.Drawing.Point(500, 32);
            this.UsuariosDisponiblesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.UsuariosDisponiblesLabel.Name = "UsuariosDisponiblesLabel";
            this.UsuariosDisponiblesLabel.Size = new System.Drawing.Size(169, 19);
            this.UsuariosDisponiblesLabel.TabIndex = 1;
            this.UsuariosDisponiblesLabel.Text = "Usuarios que no sigues!";
            // 
            // AlbumTab
            // 
            this.AlbumTab.Controls.Add(this.albumesListBox);
            this.AlbumTab.Controls.Add(this.EditarAlbumButton);
            this.AlbumTab.Controls.Add(this.EliminarAlbumButton);
            this.AlbumTab.Controls.Add(this.flowLayoutPanel1);
            this.AlbumTab.Controls.Add(this.AgregarAlbumButton);
            this.AlbumTab.Controls.Add(this.panel1);
            this.AlbumTab.ImageKey = "album.png";
            this.AlbumTab.Location = new System.Drawing.Point(4, 39);
            this.AlbumTab.Name = "AlbumTab";
            this.AlbumTab.Size = new System.Drawing.Size(1047, 615);
            this.AlbumTab.TabIndex = 7;
            this.AlbumTab.Text = "Albumes";
            this.AlbumTab.UseVisualStyleBackColor = true;
            // 
            // albumesListBox
            // 
            this.albumesListBox.FormattingEnabled = true;
            this.albumesListBox.Location = new System.Drawing.Point(690, 431);
            this.albumesListBox.Name = "albumesListBox";
            this.albumesListBox.Size = new System.Drawing.Size(226, 56);
            this.albumesListBox.TabIndex = 1;
            // 
            // EditarAlbumButton
            // 
            this.EditarAlbumButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditarAlbumButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditarAlbumButton.Depth = 0;
            this.EditarAlbumButton.HighEmphasis = true;
            this.EditarAlbumButton.Icon = null;
            this.EditarAlbumButton.Location = new System.Drawing.Point(713, 496);
            this.EditarAlbumButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditarAlbumButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditarAlbumButton.Name = "EditarAlbumButton";
            this.EditarAlbumButton.Size = new System.Drawing.Size(71, 36);
            this.EditarAlbumButton.TabIndex = 5;
            this.EditarAlbumButton.Text = "Editar";
            this.EditarAlbumButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EditarAlbumButton.UseAccentColor = false;
            this.EditarAlbumButton.UseVisualStyleBackColor = true;
            this.EditarAlbumButton.Click += new System.EventHandler(this.EditarAlbumButton_Click);
            // 
            // EliminarAlbumButton
            // 
            this.EliminarAlbumButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EliminarAlbumButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EliminarAlbumButton.Depth = 0;
            this.EliminarAlbumButton.HighEmphasis = true;
            this.EliminarAlbumButton.Icon = null;
            this.EliminarAlbumButton.Location = new System.Drawing.Point(812, 496);
            this.EliminarAlbumButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EliminarAlbumButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EliminarAlbumButton.Name = "EliminarAlbumButton";
            this.EliminarAlbumButton.Size = new System.Drawing.Size(88, 36);
            this.EliminarAlbumButton.TabIndex = 4;
            this.EliminarAlbumButton.Text = "Eliminar";
            this.EliminarAlbumButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EliminarAlbumButton.UseAccentColor = false;
            this.EliminarAlbumButton.UseVisualStyleBackColor = true;
            this.EliminarAlbumButton.Click += new System.EventHandler(this.EliminarAlbumButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(810, 391);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // AgregarAlbumButton
            // 
            this.AgregarAlbumButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AgregarAlbumButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AgregarAlbumButton.Depth = 0;
            this.AgregarAlbumButton.HighEmphasis = true;
            this.AgregarAlbumButton.Icon = null;
            this.AgregarAlbumButton.Location = new System.Drawing.Point(68, 444);
            this.AgregarAlbumButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AgregarAlbumButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarAlbumButton.Name = "AgregarAlbumButton";
            this.AgregarAlbumButton.Size = new System.Drawing.Size(141, 36);
            this.AgregarAlbumButton.TabIndex = 0;
            this.AgregarAlbumButton.Text = "Agregar Album";
            this.AgregarAlbumButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AgregarAlbumButton.UseAccentColor = false;
            this.AgregarAlbumButton.UseVisualStyleBackColor = true;
            this.AgregarAlbumButton.Click += new System.EventHandler(this.AgregarAlbum_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SeleccionarEliminarLabel);
            this.panel1.Location = new System.Drawing.Point(118, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 486);
            this.panel1.TabIndex = 2;
            this.panel1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panel1_ControlRemoved);
            // 
            // SeleccionarEliminarLabel
            // 
            this.SeleccionarEliminarLabel.AutoSize = true;
            this.SeleccionarEliminarLabel.BackColor = System.Drawing.SystemColors.Control;
            this.SeleccionarEliminarLabel.Depth = 0;
            this.SeleccionarEliminarLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SeleccionarEliminarLabel.Location = new System.Drawing.Point(255, 420);
            this.SeleccionarEliminarLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SeleccionarEliminarLabel.Name = "SeleccionarEliminarLabel";
            this.SeleccionarEliminarLabel.Size = new System.Drawing.Size(281, 19);
            this.SeleccionarEliminarLabel.TabIndex = 5;
            this.SeleccionarEliminarLabel.Text = "Seleccione album para realizar accion...";
            // 
            // JuegosTab
            // 
            this.JuegosTab.BackColor = System.Drawing.Color.White;
            this.JuegosTab.Controls.Add(this.puntajesListBox);
            this.JuegosTab.Controls.Add(this.generarPuntajesButton);
            this.JuegosTab.Controls.Add(this.materialLabel5);
            this.JuegosTab.Controls.Add(this.controlesAdminLabel);
            this.JuegosTab.Controls.Add(this.eliminarJuegosButton);
            this.JuegosTab.Controls.Add(this.juegosButton);
            this.JuegosTab.Controls.Add(this.agregarJuegosButton);
            this.JuegosTab.Controls.Add(this.panelListaJuegos);
            this.JuegosTab.Controls.Add(this.materialLabel3);
            this.JuegosTab.ImageKey = "juegos.png";
            this.JuegosTab.Location = new System.Drawing.Point(4, 39);
            this.JuegosTab.Name = "JuegosTab";
            this.JuegosTab.Size = new System.Drawing.Size(1047, 615);
            this.JuegosTab.TabIndex = 3;
            this.JuegosTab.Text = "Juegos";
            this.JuegosTab.Click += new System.EventHandler(this.JuegosTab_Click);
            // 
            // puntajesListBox
            // 
            this.puntajesListBox.FormattingEnabled = true;
            this.puntajesListBox.Location = new System.Drawing.Point(409, 270);
            this.puntajesListBox.Name = "puntajesListBox";
            this.puntajesListBox.Size = new System.Drawing.Size(245, 277);
            this.puntajesListBox.TabIndex = 15;
            // 
            // generarPuntajesButton
            // 
            this.generarPuntajesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generarPuntajesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.generarPuntajesButton.Depth = 0;
            this.generarPuntajesButton.HighEmphasis = true;
            this.generarPuntajesButton.Icon = null;
            this.generarPuntajesButton.Location = new System.Drawing.Point(484, 225);
            this.generarPuntajesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.generarPuntajesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.generarPuntajesButton.Name = "generarPuntajesButton";
            this.generarPuntajesButton.Size = new System.Drawing.Size(87, 36);
            this.generarPuntajesButton.TabIndex = 14;
            this.generarPuntajesButton.Text = "Generar";
            this.generarPuntajesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.generarPuntajesButton.UseAccentColor = false;
            this.generarPuntajesButton.UseVisualStyleBackColor = true;
            this.generarPuntajesButton.Click += new System.EventHandler(this.generarPuntajesButton_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(456, 200);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(153, 19);
            this.materialLabel5.TabIndex = 13;
            this.materialLabel5.Text = "Usuario Top Puntajes";
            // 
            // controlesAdminLabel
            // 
            this.controlesAdminLabel.AutoSize = true;
            this.controlesAdminLabel.Depth = 0;
            this.controlesAdminLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.controlesAdminLabel.Location = new System.Drawing.Point(437, 23);
            this.controlesAdminLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.controlesAdminLabel.Name = "controlesAdminLabel";
            this.controlesAdminLabel.Size = new System.Drawing.Size(192, 19);
            this.controlesAdminLabel.TabIndex = 12;
            this.controlesAdminLabel.Text = "Controles de administrador";
            // 
            // eliminarJuegosButton
            // 
            this.eliminarJuegosButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminarJuegosButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.eliminarJuegosButton.Depth = 0;
            this.eliminarJuegosButton.HighEmphasis = true;
            this.eliminarJuegosButton.Icon = null;
            this.eliminarJuegosButton.Location = new System.Drawing.Point(490, 148);
            this.eliminarJuegosButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eliminarJuegosButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminarJuegosButton.Name = "eliminarJuegosButton";
            this.eliminarJuegosButton.Size = new System.Drawing.Size(88, 36);
            this.eliminarJuegosButton.TabIndex = 11;
            this.eliminarJuegosButton.Text = "Eliminar";
            this.eliminarJuegosButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.eliminarJuegosButton.UseAccentColor = false;
            this.eliminarJuegosButton.UseVisualStyleBackColor = true;
            this.eliminarJuegosButton.Click += new System.EventHandler(this.eliminarJuegosButton_Click);
            // 
            // juegosButton
            // 
            this.juegosButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.juegosButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.juegosButton.Depth = 0;
            this.juegosButton.HighEmphasis = true;
            this.juegosButton.Icon = null;
            this.juegosButton.Location = new System.Drawing.Point(494, 100);
            this.juegosButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.juegosButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.juegosButton.Name = "juegosButton";
            this.juegosButton.Size = new System.Drawing.Size(77, 36);
            this.juegosButton.TabIndex = 10;
            this.juegosButton.Text = "Juegos";
            this.juegosButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.juegosButton.UseAccentColor = false;
            this.juegosButton.UseVisualStyleBackColor = true;
            this.juegosButton.Click += new System.EventHandler(this.juegosButton_Click);
            // 
            // agregarJuegosButton
            // 
            this.agregarJuegosButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.agregarJuegosButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.agregarJuegosButton.Depth = 0;
            this.agregarJuegosButton.HighEmphasis = true;
            this.agregarJuegosButton.Icon = null;
            this.agregarJuegosButton.Location = new System.Drawing.Point(459, 52);
            this.agregarJuegosButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.agregarJuegosButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.agregarJuegosButton.Name = "agregarJuegosButton";
            this.agregarJuegosButton.Size = new System.Drawing.Size(147, 36);
            this.agregarJuegosButton.TabIndex = 9;
            this.agregarJuegosButton.Text = "Agregar Juegos";
            this.agregarJuegosButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.agregarJuegosButton.UseAccentColor = false;
            this.agregarJuegosButton.UseVisualStyleBackColor = true;
            this.agregarJuegosButton.Click += new System.EventHandler(this.agregarJuegosButton_Click_1);
            // 
            // panelListaJuegos
            // 
            this.panelListaJuegos.Location = new System.Drawing.Point(20, 51);
            this.panelListaJuegos.Name = "panelListaJuegos";
            this.panelListaJuegos.Size = new System.Drawing.Size(355, 499);
            this.panelListaJuegos.TabIndex = 7;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(33, 23);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(193, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Lista de juegos disponibles";
            // 
            // EscuchandoTab
            // 
            this.EscuchandoTab.BackColor = System.Drawing.Color.White;
            this.EscuchandoTab.Controls.Add(this.EscuchandoCompartirButton);
            this.EscuchandoTab.Controls.Add(this.materialLabel1);
            this.EscuchandoTab.Controls.Add(this.AlbumTextBox);
            this.EscuchandoTab.Controls.Add(this.ArtistaTextBox);
            this.EscuchandoTab.Controls.Add(this.CancionTextBox);
            this.EscuchandoTab.ImageKey = "Musica.png";
            this.EscuchandoTab.Location = new System.Drawing.Point(4, 39);
            this.EscuchandoTab.Name = "EscuchandoTab";
            this.EscuchandoTab.Size = new System.Drawing.Size(1047, 615);
            this.EscuchandoTab.TabIndex = 4;
            this.EscuchandoTab.Text = "Escuchando";
            // 
            // EscuchandoCompartirButton
            // 
            this.EscuchandoCompartirButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EscuchandoCompartirButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EscuchandoCompartirButton.Depth = 0;
            this.EscuchandoCompartirButton.HighEmphasis = true;
            this.EscuchandoCompartirButton.Icon = null;
            this.EscuchandoCompartirButton.Location = new System.Drawing.Point(386, 201);
            this.EscuchandoCompartirButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EscuchandoCompartirButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EscuchandoCompartirButton.Name = "EscuchandoCompartirButton";
            this.EscuchandoCompartirButton.Size = new System.Drawing.Size(108, 36);
            this.EscuchandoCompartirButton.TabIndex = 4;
            this.EscuchandoCompartirButton.Text = "Compartir!";
            this.EscuchandoCompartirButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EscuchandoCompartirButton.UseAccentColor = false;
            this.EscuchandoCompartirButton.UseVisualStyleBackColor = true;
            this.EscuchandoCompartirButton.Click += new System.EventHandler(this.EscuchandoCompartirButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(274, 56);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(363, 41);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Que estas escuchando?";
            // 
            // AlbumTextBox
            // 
            this.AlbumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlbumTextBox.Depth = 0;
            this.AlbumTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AlbumTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.AlbumTextBox.Hint = "Album";
            this.AlbumTextBox.LeadingIcon = null;
            this.AlbumTextBox.Location = new System.Drawing.Point(558, 119);
            this.AlbumTextBox.MaxLength = 50;
            this.AlbumTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.AlbumTextBox.Multiline = false;
            this.AlbumTextBox.Name = "AlbumTextBox";
            this.AlbumTextBox.Size = new System.Drawing.Size(154, 50);
            this.AlbumTextBox.TabIndex = 2;
            this.AlbumTextBox.Text = "";
            this.AlbumTextBox.TrailingIcon = null;
            // 
            // ArtistaTextBox
            // 
            this.ArtistaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ArtistaTextBox.Depth = 0;
            this.ArtistaTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ArtistaTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ArtistaTextBox.Hint = "Artista";
            this.ArtistaTextBox.LeadingIcon = null;
            this.ArtistaTextBox.Location = new System.Drawing.Point(375, 119);
            this.ArtistaTextBox.MaxLength = 50;
            this.ArtistaTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ArtistaTextBox.Multiline = false;
            this.ArtistaTextBox.Name = "ArtistaTextBox";
            this.ArtistaTextBox.Size = new System.Drawing.Size(164, 50);
            this.ArtistaTextBox.TabIndex = 1;
            this.ArtistaTextBox.Text = "";
            this.ArtistaTextBox.TrailingIcon = null;
            // 
            // CancionTextBox
            // 
            this.CancionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CancionTextBox.Depth = 0;
            this.CancionTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CancionTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancionTextBox.Hint = "Cancion";
            this.CancionTextBox.LeadingIcon = null;
            this.CancionTextBox.Location = new System.Drawing.Point(176, 119);
            this.CancionTextBox.MaxLength = 50;
            this.CancionTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CancionTextBox.Multiline = false;
            this.CancionTextBox.Name = "CancionTextBox";
            this.CancionTextBox.Size = new System.Drawing.Size(178, 50);
            this.CancionTextBox.TabIndex = 0;
            this.CancionTextBox.Text = "";
            this.CancionTextBox.TrailingIcon = null;
            // 
            // EstadoTab
            // 
            this.EstadoTab.BackColor = System.Drawing.Color.White;
            this.EstadoTab.Controls.Add(this.eliminarEstadoButton);
            this.EstadoTab.Controls.Add(this.listaEstadosLabel);
            this.EstadoTab.Controls.Add(this.estadosListBox);
            this.EstadoTab.Controls.Add(this.CompartirButton);
            this.EstadoTab.Controls.Add(this.estadoTextBox);
            this.EstadoTab.Controls.Add(this.materialLabel4);
            this.EstadoTab.ImageKey = "thinking.png";
            this.EstadoTab.Location = new System.Drawing.Point(4, 39);
            this.EstadoTab.Name = "EstadoTab";
            this.EstadoTab.Size = new System.Drawing.Size(1047, 615);
            this.EstadoTab.TabIndex = 5;
            this.EstadoTab.Text = "Estado";
            // 
            // eliminarEstadoButton
            // 
            this.eliminarEstadoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminarEstadoButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.eliminarEstadoButton.Depth = 0;
            this.eliminarEstadoButton.HighEmphasis = true;
            this.eliminarEstadoButton.Icon = null;
            this.eliminarEstadoButton.Location = new System.Drawing.Point(308, 413);
            this.eliminarEstadoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eliminarEstadoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminarEstadoButton.Name = "eliminarEstadoButton";
            this.eliminarEstadoButton.Size = new System.Drawing.Size(148, 36);
            this.eliminarEstadoButton.TabIndex = 6;
            this.eliminarEstadoButton.Text = "Eliminar estado";
            this.eliminarEstadoButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.eliminarEstadoButton.UseAccentColor = false;
            this.eliminarEstadoButton.UseVisualStyleBackColor = true;
            this.eliminarEstadoButton.Click += new System.EventHandler(this.eliminarEstadoButton_Click);
            // 
            // listaEstadosLabel
            // 
            this.listaEstadosLabel.AutoSize = true;
            this.listaEstadosLabel.Depth = 0;
            this.listaEstadosLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listaEstadosLabel.Location = new System.Drawing.Point(117, 236);
            this.listaEstadosLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.listaEstadosLabel.Name = "listaEstadosLabel";
            this.listaEstadosLabel.Size = new System.Drawing.Size(297, 19);
            this.listaEstadosLabel.TabIndex = 5;
            this.listaEstadosLabel.Text = "Estos son los estados que has posteado...";
            // 
            // estadosListBox
            // 
            this.estadosListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadosListBox.FormattingEnabled = true;
            this.estadosListBox.ItemHeight = 15;
            this.estadosListBox.Location = new System.Drawing.Point(117, 268);
            this.estadosListBox.Name = "estadosListBox";
            this.estadosListBox.Size = new System.Drawing.Size(551, 124);
            this.estadosListBox.TabIndex = 4;
            // 
            // CompartirButton
            // 
            this.CompartirButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CompartirButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CompartirButton.Depth = 0;
            this.CompartirButton.HighEmphasis = true;
            this.CompartirButton.Icon = null;
            this.CompartirButton.Location = new System.Drawing.Point(325, 109);
            this.CompartirButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CompartirButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CompartirButton.Name = "CompartirButton";
            this.CompartirButton.Size = new System.Drawing.Size(108, 36);
            this.CompartirButton.TabIndex = 3;
            this.CompartirButton.Text = "Compartir!";
            this.CompartirButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CompartirButton.UseAccentColor = false;
            this.CompartirButton.UseVisualStyleBackColor = true;
            this.CompartirButton.Click += new System.EventHandler(this.CompartirButton_Click);
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.AcceptsTab = true;
            this.estadoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.estadoTextBox.Depth = 0;
            this.estadoTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.estadoTextBox.Hint = "En que estas pensando?";
            this.estadoTextBox.LeadingIcon = null;
            this.estadoTextBox.Location = new System.Drawing.Point(120, 50);
            this.estadoTextBox.MaxLength = 250;
            this.estadoTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.estadoTextBox.Multiline = false;
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(537, 50);
            this.estadoTextBox.TabIndex = 2;
            this.estadoTextBox.Text = "";
            this.estadoTextBox.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(114, 50);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(1, 0);
            this.materialLabel4.TabIndex = 1;
            // 
            // EncuestaTab
            // 
            this.EncuestaTab.Controls.Add(this.Opcion5TextBox);
            this.EncuestaTab.Controls.Add(this.Opcion4TextBox);
            this.EncuestaTab.Controls.Add(this.Opcion3TextBox);
            this.EncuestaTab.Controls.Add(this.Opcion2TextBox);
            this.EncuestaTab.Controls.Add(this.Opcion1TextBox);
            this.EncuestaTab.Controls.Add(this.CompartirMaterialButton);
            this.EncuestaTab.Controls.Add(this.materialLabel6);
            this.EncuestaTab.Controls.Add(this.PreguntaMaterialTextBox);
            this.EncuestaTab.ImageKey = "encuestasincuadraditos.png";
            this.EncuestaTab.Location = new System.Drawing.Point(4, 39);
            this.EncuestaTab.Name = "EncuestaTab";
            this.EncuestaTab.Size = new System.Drawing.Size(1047, 615);
            this.EncuestaTab.TabIndex = 8;
            this.EncuestaTab.Text = "Encuesta";
            this.EncuestaTab.UseVisualStyleBackColor = true;
            // 
            // Opcion5TextBox
            // 
            this.Opcion5TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Opcion5TextBox.Depth = 0;
            this.Opcion5TextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Opcion5TextBox.Hint = "Opcion 5 (Opcional)";
            this.Opcion5TextBox.LeadingIcon = null;
            this.Opcion5TextBox.Location = new System.Drawing.Point(303, 427);
            this.Opcion5TextBox.MaxLength = 50;
            this.Opcion5TextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.Opcion5TextBox.Multiline = false;
            this.Opcion5TextBox.Name = "Opcion5TextBox";
            this.Opcion5TextBox.Size = new System.Drawing.Size(330, 50);
            this.Opcion5TextBox.TabIndex = 26;
            this.Opcion5TextBox.Text = "";
            this.Opcion5TextBox.TrailingIcon = null;
            // 
            // Opcion4TextBox
            // 
            this.Opcion4TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Opcion4TextBox.Depth = 0;
            this.Opcion4TextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Opcion4TextBox.Hint = "Opcion 4 (Opcional)";
            this.Opcion4TextBox.LeadingIcon = null;
            this.Opcion4TextBox.Location = new System.Drawing.Point(303, 361);
            this.Opcion4TextBox.MaxLength = 50;
            this.Opcion4TextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.Opcion4TextBox.Multiline = false;
            this.Opcion4TextBox.Name = "Opcion4TextBox";
            this.Opcion4TextBox.Size = new System.Drawing.Size(330, 50);
            this.Opcion4TextBox.TabIndex = 24;
            this.Opcion4TextBox.Text = "";
            this.Opcion4TextBox.TrailingIcon = null;
            // 
            // Opcion3TextBox
            // 
            this.Opcion3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Opcion3TextBox.Depth = 0;
            this.Opcion3TextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Opcion3TextBox.Hint = "Opcion 3 (Opcional)";
            this.Opcion3TextBox.LeadingIcon = null;
            this.Opcion3TextBox.Location = new System.Drawing.Point(303, 293);
            this.Opcion3TextBox.MaxLength = 50;
            this.Opcion3TextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.Opcion3TextBox.Multiline = false;
            this.Opcion3TextBox.Name = "Opcion3TextBox";
            this.Opcion3TextBox.Size = new System.Drawing.Size(330, 50);
            this.Opcion3TextBox.TabIndex = 22;
            this.Opcion3TextBox.Text = "";
            this.Opcion3TextBox.TrailingIcon = null;
            // 
            // Opcion2TextBox
            // 
            this.Opcion2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Opcion2TextBox.Depth = 0;
            this.Opcion2TextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Opcion2TextBox.Hint = "Opcion 2";
            this.Opcion2TextBox.LeadingIcon = null;
            this.Opcion2TextBox.Location = new System.Drawing.Point(303, 227);
            this.Opcion2TextBox.MaxLength = 50;
            this.Opcion2TextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.Opcion2TextBox.Multiline = false;
            this.Opcion2TextBox.Name = "Opcion2TextBox";
            this.Opcion2TextBox.Size = new System.Drawing.Size(330, 50);
            this.Opcion2TextBox.TabIndex = 20;
            this.Opcion2TextBox.Text = "";
            this.Opcion2TextBox.TrailingIcon = null;
            // 
            // Opcion1TextBox
            // 
            this.Opcion1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Opcion1TextBox.Depth = 0;
            this.Opcion1TextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Opcion1TextBox.Hint = "Opcion 1";
            this.Opcion1TextBox.LeadingIcon = null;
            this.Opcion1TextBox.Location = new System.Drawing.Point(303, 161);
            this.Opcion1TextBox.MaxLength = 50;
            this.Opcion1TextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.Opcion1TextBox.Multiline = false;
            this.Opcion1TextBox.Name = "Opcion1TextBox";
            this.Opcion1TextBox.Size = new System.Drawing.Size(330, 50);
            this.Opcion1TextBox.TabIndex = 18;
            this.Opcion1TextBox.Text = "";
            this.Opcion1TextBox.TrailingIcon = null;
            // 
            // CompartirMaterialButton
            // 
            this.CompartirMaterialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CompartirMaterialButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CompartirMaterialButton.Depth = 0;
            this.CompartirMaterialButton.HighEmphasis = true;
            this.CompartirMaterialButton.Icon = null;
            this.CompartirMaterialButton.Location = new System.Drawing.Point(723, 107);
            this.CompartirMaterialButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CompartirMaterialButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CompartirMaterialButton.Name = "CompartirMaterialButton";
            this.CompartirMaterialButton.Size = new System.Drawing.Size(108, 36);
            this.CompartirMaterialButton.TabIndex = 7;
            this.CompartirMaterialButton.Text = "Compartir!";
            this.CompartirMaterialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CompartirMaterialButton.UseAccentColor = false;
            this.CompartirMaterialButton.UseVisualStyleBackColor = true;
            this.CompartirMaterialButton.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel6.Location = new System.Drawing.Point(338, 16);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.materialLabel6.Size = new System.Drawing.Size(337, 41);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "Que desea encuestar?";
            // 
            // PreguntaMaterialTextBox
            // 
            this.PreguntaMaterialTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreguntaMaterialTextBox.Depth = 0;
            this.PreguntaMaterialTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PreguntaMaterialTextBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.PreguntaMaterialTextBox.Hint = "Pregunta";
            this.PreguntaMaterialTextBox.LeadingIcon = null;
            this.PreguntaMaterialTextBox.Location = new System.Drawing.Point(210, 96);
            this.PreguntaMaterialTextBox.MaxLength = 50;
            this.PreguntaMaterialTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PreguntaMaterialTextBox.Multiline = false;
            this.PreguntaMaterialTextBox.Name = "PreguntaMaterialTextBox";
            this.PreguntaMaterialTextBox.Size = new System.Drawing.Size(477, 50);
            this.PreguntaMaterialTextBox.TabIndex = 5;
            this.PreguntaMaterialTextBox.Text = "";
            this.PreguntaMaterialTextBox.TrailingIcon = null;
            this.PreguntaMaterialTextBox.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // CerrarSesionTab
            // 
            this.CerrarSesionTab.Controls.Add(this.CerrarSesionButton);
            this.CerrarSesionTab.ImageKey = "logoff.png";
            this.CerrarSesionTab.Location = new System.Drawing.Point(4, 39);
            this.CerrarSesionTab.Name = "CerrarSesionTab";
            this.CerrarSesionTab.Size = new System.Drawing.Size(1047, 615);
            this.CerrarSesionTab.TabIndex = 6;
            this.CerrarSesionTab.Text = "Cerrar Session";
            this.CerrarSesionTab.UseVisualStyleBackColor = true;
            // 
            // CerrarSesionButton
            // 
            this.CerrarSesionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CerrarSesionButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CerrarSesionButton.Depth = 0;
            this.CerrarSesionButton.HighEmphasis = true;
            this.CerrarSesionButton.Icon = null;
            this.CerrarSesionButton.ImageList = this.imageList1;
            this.CerrarSesionButton.Location = new System.Drawing.Point(418, 218);
            this.CerrarSesionButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CerrarSesionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CerrarSesionButton.Name = "CerrarSesionButton";
            this.CerrarSesionButton.Size = new System.Drawing.Size(131, 36);
            this.CerrarSesionButton.TabIndex = 0;
            this.CerrarSesionButton.Text = "Cerrar Sesion";
            this.CerrarSesionButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CerrarSesionButton.UseAccentColor = false;
            this.CerrarSesionButton.UseVisualStyleBackColor = true;
            this.CerrarSesionButton.Click += new System.EventHandler(this.CerrarSesionButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 725);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "VentanaPrincipal";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feizvuk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaPrincipal_FormClosing);
            this.materialTabControl1.ResumeLayout(false);
            this.InicioTab.ResumeLayout(false);
            this.InicioTab.PerformLayout();
            this.UsuariosTab.ResumeLayout(false);
            this.UsuariosTab.PerformLayout();
            this.AlbumTab.ResumeLayout(false);
            this.AlbumTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.JuegosTab.ResumeLayout(false);
            this.JuegosTab.PerformLayout();
            this.EscuchandoTab.ResumeLayout(false);
            this.EscuchandoTab.PerformLayout();
            this.EstadoTab.ResumeLayout(false);
            this.EstadoTab.PerformLayout();
            this.EncuestaTab.ResumeLayout(false);
            this.EncuestaTab.PerformLayout();
            this.CerrarSesionTab.ResumeLayout(false);
            this.CerrarSesionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage InicioTab;
        private System.Windows.Forms.TabPage UsuariosTab;
        private System.Windows.Forms.TabPage JuegosTab;
        private System.Windows.Forms.TabPage EscuchandoTab;
        private System.Windows.Forms.TabPage EstadoTab;
        private MaterialSkin.Controls.MaterialLabel UsuariosDisponiblesLabel;
        private MaterialSkin.Controls.MaterialTextBox AlbumTextBox;
        private MaterialSkin.Controls.MaterialTextBox ArtistaTextBox;
        private MaterialSkin.Controls.MaterialTextBox CancionTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton SeguirButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton CompartirButton;
        private MaterialSkin.Controls.MaterialTextBox estadoTextBox;
        private MaterialSkin.Controls.MaterialLabel MiraGenteLabel;
        private System.Windows.Forms.TabPage CerrarSesionTab;
        private MaterialSkin.Controls.MaterialButton CerrarSesionButton;
        private System.Windows.Forms.ListBox SeguidosListBox;
        private System.Windows.Forms.ListBox NoSeguidosListBox;
        private System.Windows.Forms.TabPage AlbumTab;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialLabel listaEstadosLabel;
        private System.Windows.Forms.ListBox estadosListBox;
        private MaterialSkin.Controls.MaterialButton eliminarEstadoButton;
        private System.Windows.Forms.Panel panelListaJuegos;
        private MaterialSkin.Controls.MaterialButton agregarJuegosButton;
        private MaterialSkin.Controls.MaterialButton juegosButton;
        private MaterialSkin.Controls.MaterialButton eliminarJuegosButton;
        private MaterialSkin.Controls.MaterialLabel controlesAdminLabel;
        private MaterialSkin.Controls.MaterialButton EscuchandoCompartirButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox albumesListBox;
        private MaterialSkin.Controls.MaterialButton AgregarAlbumButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton EliminarAlbumButton;
        private MaterialSkin.Controls.MaterialLabel SeleccionarEliminarLabel;
        private MaterialSkin.Controls.MaterialButton EditarAlbumButton;
        private System.Windows.Forms.Panel feedMainPanel;
        private MaterialSkin.Controls.MaterialButton reporteButton;
        private System.Windows.Forms.ListBox reportList;
        private MaterialSkin.Controls.MaterialButton cerrarReporteButton;
        private System.Windows.Forms.ListBox puntajesListBox;
        private MaterialSkin.Controls.MaterialButton generarPuntajesButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TabPage EncuestaTab;
        private MaterialSkin.Controls.MaterialButton CompartirMaterialButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox PreguntaMaterialTextBox;
        private MaterialSkin.Controls.MaterialTextBox Opcion4TextBox;
        private MaterialSkin.Controls.MaterialTextBox Opcion3TextBox;
        private MaterialSkin.Controls.MaterialTextBox Opcion2TextBox;
        private MaterialSkin.Controls.MaterialTextBox Opcion1TextBox;
        private MaterialSkin.Controls.MaterialTextBox Opcion5TextBox;
    }
}

