
namespace ObligatorioUI
{
    partial class JuegoEliminableItem
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.eliminarButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaratula)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCaratula
            // 
            this.pictureBoxCaratula.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxCaratula.Name = "pictureBoxCaratula";
            this.pictureBoxCaratula.Size = new System.Drawing.Size(63, 67);
            this.pictureBoxCaratula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCaratula.TabIndex = 1;
            this.pictureBoxCaratula.TabStop = false;
            // 
            // tituloLabel
            // 
            this.tituloLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(72, 3);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(147, 25);
            this.tituloLabel.TabIndex = 2;
            this.tituloLabel.Text = "label1";
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaLabel.Location = new System.Drawing.Point(72, 45);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(147, 25);
            this.categoriaLabel.TabIndex = 3;
            this.categoriaLabel.Text = "label1";
            // 
            // eliminarButton
            // 
            this.eliminarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminarButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.eliminarButton.Depth = 0;
            this.eliminarButton.HighEmphasis = true;
            this.eliminarButton.Icon = null;
            this.eliminarButton.Location = new System.Drawing.Point(167, 20);
            this.eliminarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eliminarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(64, 36);
            this.eliminarButton.TabIndex = 4;
            this.eliminarButton.Text = "X";
            this.eliminarButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.eliminarButton.UseAccentColor = false;
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // JuegoEliminableItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.categoriaLabel);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.pictureBoxCaratula);
            this.Name = "JuegoEliminableItem";
            this.Size = new System.Drawing.Size(235, 71);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaratula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCaratula;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label categoriaLabel;
        private MaterialSkin.Controls.MaterialButton eliminarButton;
    }
}
