
namespace ObligatorioUI
{
    partial class AgregadorDeJuego
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tituloLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tituloTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.categoriaLabel = new MaterialSkin.Controls.MaterialLabel();
            this.seleccionarImagenButton = new MaterialSkin.Controls.MaterialButton();
            this.caratulaPictureBox = new System.Windows.Forms.PictureBox();
            this.caratulaLabel = new MaterialSkin.Controls.MaterialLabel();
            this.seleccionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.categoriaComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caratulaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(14, 347);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(138, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Agregar Juego";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Depth = 0;
            this.tituloLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tituloLabel.Location = new System.Drawing.Point(12, 0);
            this.tituloLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(42, 19);
            this.tituloLabel.TabIndex = 1;
            this.tituloLabel.Text = "Titulo";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tituloTextBox.Depth = 0;
            this.tituloTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tituloTextBox.Hint = "Ingresar titulo...";
            this.tituloTextBox.LeadingIcon = null;
            this.tituloTextBox.Location = new System.Drawing.Point(15, 22);
            this.tituloTextBox.MaxLength = 50;
            this.tituloTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.tituloTextBox.Multiline = false;
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(193, 50);
            this.tituloTextBox.TabIndex = 2;
            this.tituloTextBox.Text = "";
            this.tituloTextBox.TrailingIcon = null;
            this.tituloTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.tituloTextBox_Validating);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.AutoSize = true;
            this.categoriaLabel.Depth = 0;
            this.categoriaLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.categoriaLabel.Location = new System.Drawing.Point(12, 75);
            this.categoriaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(69, 19);
            this.categoriaLabel.TabIndex = 5;
            this.categoriaLabel.Text = "Categoria";
            // 
            // seleccionarImagenButton
            // 
            this.seleccionarImagenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.seleccionarImagenButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.seleccionarImagenButton.Depth = 0;
            this.seleccionarImagenButton.HighEmphasis = true;
            this.seleccionarImagenButton.Icon = null;
            this.seleccionarImagenButton.Location = new System.Drawing.Point(15, 299);
            this.seleccionarImagenButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.seleccionarImagenButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.seleccionarImagenButton.Name = "seleccionarImagenButton";
            this.seleccionarImagenButton.Size = new System.Drawing.Size(118, 36);
            this.seleccionarImagenButton.TabIndex = 6;
            this.seleccionarImagenButton.Text = "Seleccionar";
            this.seleccionarImagenButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.seleccionarImagenButton.UseAccentColor = false;
            this.seleccionarImagenButton.UseVisualStyleBackColor = true;
            this.seleccionarImagenButton.Click += new System.EventHandler(this.seleccionarImagenButton_Click);
            // 
            // caratulaPictureBox
            // 
            this.caratulaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caratulaPictureBox.InitialImage = null;
            this.caratulaPictureBox.Location = new System.Drawing.Point(15, 180);
            this.caratulaPictureBox.Name = "caratulaPictureBox";
            this.caratulaPictureBox.Size = new System.Drawing.Size(105, 115);
            this.caratulaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caratulaPictureBox.TabIndex = 7;
            this.caratulaPictureBox.TabStop = false;
            // 
            // caratulaLabel
            // 
            this.caratulaLabel.AutoSize = true;
            this.caratulaLabel.Depth = 0;
            this.caratulaLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.caratulaLabel.Location = new System.Drawing.Point(12, 158);
            this.caratulaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.caratulaLabel.Name = "caratulaLabel";
            this.caratulaLabel.Size = new System.Drawing.Size(140, 19);
            this.caratulaLabel.TabIndex = 8;
            this.caratulaLabel.Text = "Seleccionar Imagen";
            // 
            // seleccionLabel
            // 
            this.seleccionLabel.AutoSize = true;
            this.seleccionLabel.Depth = 0;
            this.seleccionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.seleccionLabel.Location = new System.Drawing.Point(140, 309);
            this.seleccionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.seleccionLabel.Name = "seleccionLabel";
            this.seleccionLabel.Size = new System.Drawing.Size(1, 0);
            this.seleccionLabel.TabIndex = 10;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.AutoResize = false;
            this.categoriaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoriaComboBox.Depth = 0;
            this.categoriaComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.categoriaComboBox.DropDownHeight = 174;
            this.categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaComboBox.DropDownWidth = 121;
            this.categoriaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.categoriaComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Hint = "Seleccionar Categoria...";
            this.categoriaComboBox.IntegralHeight = false;
            this.categoriaComboBox.ItemHeight = 43;
            this.categoriaComboBox.Location = new System.Drawing.Point(15, 97);
            this.categoriaComboBox.MaxDropDownItems = 4;
            this.categoriaComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(193, 49);
            this.categoriaComboBox.StartIndex = 0;
            this.categoriaComboBox.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AgregadorDeJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(this.seleccionLabel);
            this.Controls.Add(this.caratulaLabel);
            this.Controls.Add(this.caratulaPictureBox);
            this.Controls.Add(this.seleccionarImagenButton);
            this.Controls.Add(this.categoriaLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.materialButton1);
            this.Name = "AgregadorDeJuego";
            this.Size = new System.Drawing.Size(340, 428);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caratulaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel tituloLabel;
        private MaterialSkin.Controls.MaterialTextBox tituloTextBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private MaterialSkin.Controls.MaterialLabel caratulaLabel;
        private System.Windows.Forms.PictureBox caratulaPictureBox;
        private MaterialSkin.Controls.MaterialButton seleccionarImagenButton;
        private MaterialSkin.Controls.MaterialLabel categoriaLabel;
        private MaterialSkin.Controls.MaterialLabel seleccionLabel;
        private MaterialSkin.Controls.MaterialComboBox categoriaComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
