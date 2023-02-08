
namespace ObligatorioUI
{
    partial class JuegoItem
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
            this.pictureBoxCaratula = new System.Windows.Forms.PictureBox();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.jugarButton = new MaterialSkin.Controls.MaterialButton();
            this.simularButton = new MaterialSkin.Controls.MaterialButton();
            this.puntajeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.rankingButton = new MaterialSkin.Controls.MaterialButton();
            this.abrirButton = new MaterialSkin.Controls.MaterialButton();
            this.atrasButton = new MaterialSkin.Controls.MaterialButton();
            this.LabelCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaratula)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCaratula
            // 
            this.pictureBoxCaratula.Location = new System.Drawing.Point(3, 1);
            this.pictureBoxCaratula.Name = "pictureBoxCaratula";
            this.pictureBoxCaratula.Size = new System.Drawing.Size(63, 67);
            this.pictureBoxCaratula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCaratula.TabIndex = 0;
            this.pictureBoxCaratula.TabStop = false;
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.Location = new System.Drawing.Point(72, 4);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(117, 25);
            this.LabelTitulo.TabIndex = 1;
            this.LabelTitulo.Text = "label1";
            // 
            // jugarButton
            // 
            this.jugarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jugarButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.jugarButton.Depth = 0;
            this.jugarButton.HighEmphasis = true;
            this.jugarButton.Icon = null;
            this.jugarButton.Location = new System.Drawing.Point(20, 22);
            this.jugarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.jugarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.jugarButton.Name = "jugarButton";
            this.jugarButton.Size = new System.Drawing.Size(68, 36);
            this.jugarButton.TabIndex = 2;
            this.jugarButton.Text = "Jugar";
            this.jugarButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.jugarButton.UseAccentColor = false;
            this.jugarButton.UseVisualStyleBackColor = true;
            this.jugarButton.Click += new System.EventHandler(this.jugarButton_Click);
            // 
            // simularButton
            // 
            this.simularButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.simularButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.simularButton.Depth = 0;
            this.simularButton.HighEmphasis = true;
            this.simularButton.Icon = null;
            this.simularButton.Location = new System.Drawing.Point(64, 22);
            this.simularButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.simularButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.simularButton.Name = "simularButton";
            this.simularButton.Size = new System.Drawing.Size(84, 36);
            this.simularButton.TabIndex = 3;
            this.simularButton.Text = "Simular";
            this.simularButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.simularButton.UseAccentColor = false;
            this.simularButton.UseVisualStyleBackColor = true;
            this.simularButton.Click += new System.EventHandler(this.simularButton_Click);
            // 
            // puntajeTextBox
            // 
            this.puntajeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.puntajeTextBox.Depth = 0;
            this.puntajeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.puntajeTextBox.Hint = "Puntaje: 0";
            this.puntajeTextBox.LeadingIcon = null;
            this.puntajeTextBox.Location = new System.Drawing.Point(147, 11);
            this.puntajeTextBox.MaxLength = 50;
            this.puntajeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.puntajeTextBox.Multiline = false;
            this.puntajeTextBox.Name = "puntajeTextBox";
            this.puntajeTextBox.Size = new System.Drawing.Size(92, 50);
            this.puntajeTextBox.TabIndex = 4;
            this.puntajeTextBox.Text = "";
            this.puntajeTextBox.TrailingIcon = null;
            this.puntajeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.puntajeTextBox_KeyPress);
            // 
            // rankingButton
            // 
            this.rankingButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rankingButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.rankingButton.Depth = 0;
            this.rankingButton.HighEmphasis = true;
            this.rankingButton.Icon = null;
            this.rankingButton.Location = new System.Drawing.Point(133, 22);
            this.rankingButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rankingButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.rankingButton.Name = "rankingButton";
            this.rankingButton.Size = new System.Drawing.Size(85, 36);
            this.rankingButton.TabIndex = 5;
            this.rankingButton.Text = "Ranking";
            this.rankingButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.rankingButton.UseAccentColor = false;
            this.rankingButton.UseVisualStyleBackColor = true;
            this.rankingButton.Click += new System.EventHandler(this.rankingButton_Click);
            // 
            // abrirButton
            // 
            this.abrirButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.abrirButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.abrirButton.Depth = 0;
            this.abrirButton.HighEmphasis = true;
            this.abrirButton.Icon = null;
            this.abrirButton.Location = new System.Drawing.Point(167, 22);
            this.abrirButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.abrirButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.abrirButton.Name = "abrirButton";
            this.abrirButton.Size = new System.Drawing.Size(64, 36);
            this.abrirButton.TabIndex = 6;
            this.abrirButton.Text = "Abrir";
            this.abrirButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.abrirButton.UseAccentColor = false;
            this.abrirButton.UseVisualStyleBackColor = true;
            this.abrirButton.Click += new System.EventHandler(this.abrirButton_Click);
            // 
            // atrasButton
            // 
            this.atrasButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.atrasButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.atrasButton.Depth = 0;
            this.atrasButton.HighEmphasis = true;
            this.atrasButton.Icon = null;
            this.atrasButton.Location = new System.Drawing.Point(0, 22);
            this.atrasButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.atrasButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.atrasButton.Name = "atrasButton";
            this.atrasButton.Size = new System.Drawing.Size(67, 36);
            this.atrasButton.TabIndex = 7;
            this.atrasButton.Text = "Atras";
            this.atrasButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.atrasButton.UseAccentColor = false;
            this.atrasButton.UseVisualStyleBackColor = true;
            this.atrasButton.Click += new System.EventHandler(this.atrasButton_Click);
            // 
            // LabelCategoria
            // 
            this.LabelCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.LabelCategoria.Location = new System.Drawing.Point(72, 43);
            this.LabelCategoria.Name = "LabelCategoria";
            this.LabelCategoria.Size = new System.Drawing.Size(88, 25);
            this.LabelCategoria.TabIndex = 8;
            this.LabelCategoria.Text = "label1";
            // 
            // JuegoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelCategoria);
            this.Controls.Add(this.atrasButton);
            this.Controls.Add(this.simularButton);
            this.Controls.Add(this.puntajeTextBox);
            this.Controls.Add(this.rankingButton);
            this.Controls.Add(this.abrirButton);
            this.Controls.Add(this.jugarButton);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.pictureBoxCaratula);
            this.Name = "JuegoItem";
            this.Size = new System.Drawing.Size(235, 71);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaratula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCaratula;
        private System.Windows.Forms.Label LabelTitulo;
        private MaterialSkin.Controls.MaterialButton jugarButton;
        private MaterialSkin.Controls.MaterialButton simularButton;
        private MaterialSkin.Controls.MaterialTextBox puntajeTextBox;
        private MaterialSkin.Controls.MaterialButton rankingButton;
        private MaterialSkin.Controls.MaterialButton abrirButton;
        private MaterialSkin.Controls.MaterialButton atrasButton;
        private System.Windows.Forms.Label LabelCategoria;
    }
}
