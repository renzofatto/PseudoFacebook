
namespace ObligatorioUI
{
    partial class VentanaRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaRegistroUsuario));
            this.fechaNacimientoPicker = new System.Windows.Forms.DateTimePicker();
            this.NombreUsuarioTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.ApellidoTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.NombreTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.VolverButton = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ContrasenaTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.fechaNacimientoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.newProfilePicture = new System.Windows.Forms.PictureBox();
            this.ChooseFileButton = new MaterialSkin.Controls.MaterialButton();
            this.profilePictureFilenameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.GuardarUsuarioButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.PaisTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.CiudadTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.CalleTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.newProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaNacimientoPicker
            // 
            this.fechaNacimientoPicker.Location = new System.Drawing.Point(331, 347);
            this.fechaNacimientoPicker.MaxDate = new System.DateTime(2021, 10, 14, 0, 0, 0, 0);
            this.fechaNacimientoPicker.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.fechaNacimientoPicker.Name = "fechaNacimientoPicker";
            this.fechaNacimientoPicker.Size = new System.Drawing.Size(286, 20);
            this.fechaNacimientoPicker.TabIndex = 5;
            this.fechaNacimientoPicker.Value = new System.DateTime(2021, 10, 14, 0, 0, 0, 0);
            // 
            // NombreUsuarioTextBox
            // 
            this.NombreUsuarioTextBox.AcceptsTab = true;
            this.NombreUsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreUsuarioTextBox.Depth = 0;
            this.NombreUsuarioTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NombreUsuarioTextBox.Hint = "Nombre de usuario";
            this.NombreUsuarioTextBox.LeadingIcon = null;
            this.NombreUsuarioTextBox.Location = new System.Drawing.Point(331, 94);
            this.NombreUsuarioTextBox.MaxLength = 50;
            this.NombreUsuarioTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.NombreUsuarioTextBox.Multiline = false;
            this.NombreUsuarioTextBox.Name = "NombreUsuarioTextBox";
            this.NombreUsuarioTextBox.Size = new System.Drawing.Size(286, 50);
            this.NombreUsuarioTextBox.TabIndex = 1;
            this.NombreUsuarioTextBox.Text = "";
            this.NombreUsuarioTextBox.TrailingIcon = null;
            this.NombreUsuarioTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NombreUsuarioTextBox_Validating);
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.AcceptsTab = true;
            this.ApellidoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApellidoTextBox.Depth = 0;
            this.ApellidoTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ApellidoTextBox.Hint = "Apellido";
            this.ApellidoTextBox.LeadingIcon = null;
            this.ApellidoTextBox.Location = new System.Drawing.Point(331, 262);
            this.ApellidoTextBox.MaxLength = 50;
            this.ApellidoTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ApellidoTextBox.Multiline = false;
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(286, 50);
            this.ApellidoTextBox.TabIndex = 4;
            this.ApellidoTextBox.Text = "";
            this.ApellidoTextBox.TrailingIcon = null;
            this.ApellidoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidoTextBox_KeyPress);
            this.ApellidoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ApellidoTextBox_Validating);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.AcceptsTab = true;
            this.NombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreTextBox.Depth = 0;
            this.NombreTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NombreTextBox.Hint = "Nombre";
            this.NombreTextBox.LeadingIcon = null;
            this.NombreTextBox.Location = new System.Drawing.Point(331, 206);
            this.NombreTextBox.MaxLength = 50;
            this.NombreTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.NombreTextBox.Multiline = false;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(286, 50);
            this.NombreTextBox.TabIndex = 3;
            this.NombreTextBox.Text = "";
            this.NombreTextBox.TrailingIcon = null;
            this.NombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreTextBox_KeyPress);
            this.NombreTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NombreTextBox_Validating);
            // 
            // VolverButton
            // 
            this.VolverButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VolverButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.VolverButton.Depth = 0;
            this.VolverButton.HighEmphasis = true;
            this.VolverButton.Icon = null;
            this.VolverButton.Location = new System.Drawing.Point(7, 70);
            this.VolverButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.VolverButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(76, 36);
            this.VolverButton.TabIndex = 11;
            this.VolverButton.Text = "Volver";
            this.VolverButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.VolverButton.UseAccentColor = false;
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.VolverButton_Click);
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
            // ContrasenaTextBox
            // 
            this.ContrasenaTextBox.AcceptsTab = true;
            this.ContrasenaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContrasenaTextBox.Depth = 0;
            this.ContrasenaTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ContrasenaTextBox.Hint = "Contraseña";
            this.ContrasenaTextBox.LeadingIcon = null;
            this.ContrasenaTextBox.Location = new System.Drawing.Point(331, 150);
            this.ContrasenaTextBox.MaxLength = 50;
            this.ContrasenaTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ContrasenaTextBox.Multiline = false;
            this.ContrasenaTextBox.Name = "ContrasenaTextBox";
            this.ContrasenaTextBox.Size = new System.Drawing.Size(286, 50);
            this.ContrasenaTextBox.TabIndex = 2;
            this.ContrasenaTextBox.Text = "";
            this.ContrasenaTextBox.TrailingIcon = null;
            this.ContrasenaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ContrasenaTextBox_Validating);
            // 
            // fechaNacimientoLabel
            // 
            this.fechaNacimientoLabel.AutoSize = true;
            this.fechaNacimientoLabel.Depth = 0;
            this.fechaNacimientoLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fechaNacimientoLabel.Location = new System.Drawing.Point(328, 319);
            this.fechaNacimientoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            this.fechaNacimientoLabel.Size = new System.Drawing.Size(154, 19);
            this.fechaNacimientoLabel.TabIndex = 14;
            this.fechaNacimientoLabel.Text = "Fecha de Nacimiento:";
            // 
            // newProfilePicture
            // 
            this.newProfilePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("newProfilePicture.InitialImage")));
            this.newProfilePicture.Location = new System.Drawing.Point(29, 133);
            this.newProfilePicture.Name = "newProfilePicture";
            this.newProfilePicture.Size = new System.Drawing.Size(261, 205);
            this.newProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newProfilePicture.TabIndex = 15;
            this.newProfilePicture.TabStop = false;
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChooseFileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ChooseFileButton.Depth = 0;
            this.ChooseFileButton.HighEmphasis = true;
            this.ChooseFileButton.Icon = null;
            this.ChooseFileButton.Location = new System.Drawing.Point(179, 347);
            this.ChooseFileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChooseFileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(111, 36);
            this.ChooseFileButton.TabIndex = 9;
            this.ChooseFileButton.Text = "Elegir Foto";
            this.ChooseFileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ChooseFileButton.UseAccentColor = false;
            this.ChooseFileButton.UseVisualStyleBackColor = true;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // profilePictureFilenameLabel
            // 
            this.profilePictureFilenameLabel.AutoSize = true;
            this.profilePictureFilenameLabel.Depth = 0;
            this.profilePictureFilenameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.profilePictureFilenameLabel.Location = new System.Drawing.Point(29, 348);
            this.profilePictureFilenameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.profilePictureFilenameLabel.Name = "profilePictureFilenameLabel";
            this.profilePictureFilenameLabel.Size = new System.Drawing.Size(1, 0);
            this.profilePictureFilenameLabel.TabIndex = 17;
            // 
            // GuardarUsuarioButton
            // 
            this.GuardarUsuarioButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GuardarUsuarioButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.GuardarUsuarioButton.Depth = 0;
            this.GuardarUsuarioButton.HighEmphasis = true;
            this.GuardarUsuarioButton.Icon = null;
            this.GuardarUsuarioButton.Location = new System.Drawing.Point(791, 489);
            this.GuardarUsuarioButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GuardarUsuarioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GuardarUsuarioButton.Name = "GuardarUsuarioButton";
            this.GuardarUsuarioButton.Size = new System.Drawing.Size(88, 36);
            this.GuardarUsuarioButton.TabIndex = 10;
            this.GuardarUsuarioButton.Text = "Guardar";
            this.GuardarUsuarioButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.GuardarUsuarioButton.UseAccentColor = false;
            this.GuardarUsuarioButton.UseVisualStyleBackColor = true;
            this.GuardarUsuarioButton.Click += new System.EventHandler(this.GuardarUsuarioButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(328, 380);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(71, 19);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "Direccion:";
            // 
            // PaisTextBox
            // 
            this.PaisTextBox.AcceptsTab = true;
            this.PaisTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaisTextBox.Depth = 0;
            this.PaisTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PaisTextBox.Hint = "Pais";
            this.PaisTextBox.LeadingIcon = null;
            this.PaisTextBox.Location = new System.Drawing.Point(321, 403);
            this.PaisTextBox.MaxLength = 50;
            this.PaisTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PaisTextBox.Multiline = false;
            this.PaisTextBox.Name = "PaisTextBox";
            this.PaisTextBox.Size = new System.Drawing.Size(100, 50);
            this.PaisTextBox.TabIndex = 6;
            this.PaisTextBox.Text = "";
            this.PaisTextBox.TrailingIcon = null;
            this.PaisTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PaisTextBox_Validating);
            // 
            // CiudadTextBox
            // 
            this.CiudadTextBox.AcceptsTab = true;
            this.CiudadTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CiudadTextBox.Depth = 0;
            this.CiudadTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CiudadTextBox.Hint = "Ciudad";
            this.CiudadTextBox.LeadingIcon = null;
            this.CiudadTextBox.Location = new System.Drawing.Point(450, 403);
            this.CiudadTextBox.MaxLength = 50;
            this.CiudadTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CiudadTextBox.Multiline = false;
            this.CiudadTextBox.Name = "CiudadTextBox";
            this.CiudadTextBox.Size = new System.Drawing.Size(100, 50);
            this.CiudadTextBox.TabIndex = 7;
            this.CiudadTextBox.Text = "";
            this.CiudadTextBox.TrailingIcon = null;
            this.CiudadTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CiudadTextBox_Validating);
            // 
            // CalleTextBox
            // 
            this.CalleTextBox.AcceptsTab = true;
            this.CalleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CalleTextBox.Depth = 0;
            this.CalleTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CalleTextBox.Hint = "Calle";
            this.CalleTextBox.LeadingIcon = null;
            this.CalleTextBox.Location = new System.Drawing.Point(575, 403);
            this.CalleTextBox.MaxLength = 50;
            this.CalleTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CalleTextBox.Multiline = false;
            this.CalleTextBox.Name = "CalleTextBox";
            this.CalleTextBox.Size = new System.Drawing.Size(100, 50);
            this.CalleTextBox.TabIndex = 8;
            this.CalleTextBox.Text = "";
            this.CalleTextBox.TrailingIcon = null;
            this.CalleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CalleTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // VentanaRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.CalleTextBox);
            this.Controls.Add(this.CiudadTextBox);
            this.Controls.Add(this.PaisTextBox);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.GuardarUsuarioButton);
            this.Controls.Add(this.profilePictureFilenameLabel);
            this.Controls.Add(this.ChooseFileButton);
            this.Controls.Add(this.newProfilePicture);
            this.Controls.Add(this.fechaNacimientoLabel);
            this.Controls.Add(this.ContrasenaTextBox);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.fechaNacimientoPicker);
            this.Controls.Add(this.NombreUsuarioTextBox);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Name = "VentanaRegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaRegistroUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaRegistroUsuario_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.newProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaNacimientoPicker;
        private MaterialSkin.Controls.MaterialTextBox NombreUsuarioTextBox;
        private MaterialSkin.Controls.MaterialTextBox ApellidoTextBox;
        private MaterialSkin.Controls.MaterialTextBox NombreTextBox;
        private MaterialSkin.Controls.MaterialButton VolverButton;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTextBox ContrasenaTextBox;
        private MaterialSkin.Controls.MaterialLabel fechaNacimientoLabel;
        private System.Windows.Forms.PictureBox newProfilePicture;
        private MaterialSkin.Controls.MaterialButton ChooseFileButton;
        private MaterialSkin.Controls.MaterialLabel profilePictureFilenameLabel;
        private MaterialSkin.Controls.MaterialButton GuardarUsuarioButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox PaisTextBox;
        private MaterialSkin.Controls.MaterialTextBox CiudadTextBox;
        private MaterialSkin.Controls.MaterialTextBox CalleTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}