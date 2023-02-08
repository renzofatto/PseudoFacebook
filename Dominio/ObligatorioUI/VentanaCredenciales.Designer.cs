
namespace ObligatorioUI
{
    partial class VentanaCredenciales
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
            this.UsuarioTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.ContrasenaTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.IngresarButton = new MaterialSkin.Controls.MaterialButton();
            this.VolverButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsuarioTextBox.Depth = 0;
            this.UsuarioTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UsuarioTextBox.Hint = "Usuario";
            this.UsuarioTextBox.LeadingIcon = null;
            this.UsuarioTextBox.Location = new System.Drawing.Point(262, 183);
            this.UsuarioTextBox.MaxLength = 50;
            this.UsuarioTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.UsuarioTextBox.Multiline = false;
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(255, 50);
            this.UsuarioTextBox.TabIndex = 0;
            this.UsuarioTextBox.Text = "";
            this.UsuarioTextBox.TrailingIcon = null;
            // 
            // ContrasenaTextBox
            // 
            this.ContrasenaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContrasenaTextBox.Depth = 0;
            this.ContrasenaTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ContrasenaTextBox.Hint = "Contraseña";
            this.ContrasenaTextBox.LeadingIcon = null;
            this.ContrasenaTextBox.Location = new System.Drawing.Point(262, 266);
            this.ContrasenaTextBox.MaxLength = 50;
            this.ContrasenaTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ContrasenaTextBox.Multiline = false;
            this.ContrasenaTextBox.Name = "ContrasenaTextBox";
            this.ContrasenaTextBox.Size = new System.Drawing.Size(255, 50);
            this.ContrasenaTextBox.TabIndex = 1;
            this.ContrasenaTextBox.Text = "";
            this.ContrasenaTextBox.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.materialLabel1.Location = new System.Drawing.Point(186, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(466, 72);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Ingrese sus datos";
            // 
            // IngresarButton
            // 
            this.IngresarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IngresarButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.IngresarButton.Depth = 0;
            this.IngresarButton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.IngresarButton.HighEmphasis = true;
            this.IngresarButton.Icon = null;
            this.IngresarButton.Location = new System.Drawing.Point(348, 346);
            this.IngresarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.IngresarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(91, 36);
            this.IngresarButton.TabIndex = 3;
            this.IngresarButton.Text = "Ingresar";
            this.IngresarButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.IngresarButton.UseAccentColor = false;
            this.IngresarButton.UseVisualStyleBackColor = true;
            this.IngresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // VolverButton
            // 
            this.VolverButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VolverButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.VolverButton.Depth = 0;
            this.VolverButton.HighEmphasis = true;
            this.VolverButton.Icon = null;
            this.VolverButton.Location = new System.Drawing.Point(7, 86);
            this.VolverButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.VolverButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(76, 36);
            this.VolverButton.TabIndex = 4;
            this.VolverButton.Text = "Volver";
            this.VolverButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.VolverButton.UseAccentColor = false;
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.VolverButton_Click);
            // 
            // VentanaCredenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.IngresarButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ContrasenaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Name = "VentanaCredenciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaCredenciales_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox UsuarioTextBox;
        private MaterialSkin.Controls.MaterialTextBox ContrasenaTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton IngresarButton;
        private MaterialSkin.Controls.MaterialButton VolverButton;
    }
}