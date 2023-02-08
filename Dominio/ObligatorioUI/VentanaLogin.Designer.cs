
namespace ObligatorioUI
{
    partial class VentanaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLogin));
            this.IniciarSesionButton = new MaterialSkin.Controls.MaterialButton();
            this.RegistrarseButton = new MaterialSkin.Controls.MaterialButton();
            this.LabelBienvenido = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // IniciarSesionButton
            // 
            this.IniciarSesionButton.AutoSize = false;
            this.IniciarSesionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IniciarSesionButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.IniciarSesionButton.Depth = 0;
            this.IniciarSesionButton.HighEmphasis = true;
            this.IniciarSesionButton.Icon = null;
            this.IniciarSesionButton.ImageKey = "(none)";
            this.IniciarSesionButton.Location = new System.Drawing.Point(337, 212);
            this.IniciarSesionButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.IniciarSesionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.IniciarSesionButton.Name = "IniciarSesionButton";
            this.IniciarSesionButton.Size = new System.Drawing.Size(128, 36);
            this.IniciarSesionButton.TabIndex = 0;
            this.IniciarSesionButton.Text = "Iniciar Sesion";
            this.IniciarSesionButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.IniciarSesionButton.UseAccentColor = false;
            this.IniciarSesionButton.UseVisualStyleBackColor = true;
            this.IniciarSesionButton.Click += new System.EventHandler(this.IniciarSesionButton_Click);
            // 
            // RegistrarseButton
            // 
            this.RegistrarseButton.AutoSize = false;
            this.RegistrarseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegistrarseButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RegistrarseButton.Depth = 0;
            this.RegistrarseButton.HighEmphasis = true;
            this.RegistrarseButton.Icon = null;
            this.RegistrarseButton.Location = new System.Drawing.Point(337, 272);
            this.RegistrarseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegistrarseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegistrarseButton.Name = "RegistrarseButton";
            this.RegistrarseButton.Size = new System.Drawing.Size(128, 36);
            this.RegistrarseButton.TabIndex = 1;
            this.RegistrarseButton.Text = "Registrarse";
            this.RegistrarseButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RegistrarseButton.UseAccentColor = false;
            this.RegistrarseButton.UseVisualStyleBackColor = true;
            this.RegistrarseButton.Click += new System.EventHandler(this.RegistrarseButton_Click);
            // 
            // LabelBienvenido
            // 
            this.LabelBienvenido.AutoSize = true;
            this.LabelBienvenido.Depth = 0;
            this.LabelBienvenido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelBienvenido.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelBienvenido.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.LabelBienvenido.Location = new System.Drawing.Point(137, 97);
            this.LabelBienvenido.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelBienvenido.Name = "LabelBienvenido";
            this.LabelBienvenido.Size = new System.Drawing.Size(563, 72);
            this.LabelBienvenido.TabIndex = 2;
            this.LabelBienvenido.Text = "Bienvenido a Feizvuk ";
            this.LabelBienvenido.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.png");
            this.imageList1.Images.SetKeyName(1, "nuevoUsuario.png");
            this.imageList1.Images.SetKeyName(2, "usuariosVarios.png");
            this.imageList1.Images.SetKeyName(3, "juegos.png");
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelBienvenido);
            this.Controls.Add(this.RegistrarseButton);
            this.Controls.Add(this.IniciarSesionButton);
            this.Name = "VentanaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a Feizvuk!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton IniciarSesionButton;
        private MaterialSkin.Controls.MaterialButton RegistrarseButton;
        private MaterialSkin.Controls.MaterialLabel LabelBienvenido;
        private System.Windows.Forms.ImageList imageList1;
    }
}