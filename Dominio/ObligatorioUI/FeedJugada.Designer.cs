
namespace ObligatorioUI
{
    partial class FeedJugada
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
            this.caratulaPictureBox = new System.Windows.Forms.PictureBox();
            this.jugadaLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.caratulaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // caratulaPictureBox
            // 
            this.caratulaPictureBox.Location = new System.Drawing.Point(0, 0);
            this.caratulaPictureBox.Name = "caratulaPictureBox";
            this.caratulaPictureBox.Size = new System.Drawing.Size(53, 56);
            this.caratulaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caratulaPictureBox.TabIndex = 0;
            this.caratulaPictureBox.TabStop = false;
            // 
            // jugadaLabel
            // 
            this.jugadaLabel.AutoSize = true;
            this.jugadaLabel.Depth = 0;
            this.jugadaLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.jugadaLabel.Location = new System.Drawing.Point(59, 20);
            this.jugadaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.jugadaLabel.Name = "jugadaLabel";
            this.jugadaLabel.Size = new System.Drawing.Size(107, 19);
            this.jugadaLabel.TabIndex = 1;
            this.jugadaLabel.Text = "materialLabel1";
            // 
            // FeedJugada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jugadaLabel);
            this.Controls.Add(this.caratulaPictureBox);
            this.Name = "FeedJugada";
            this.Size = new System.Drawing.Size(428, 56);
            this.Load += new System.EventHandler(this.FeedJugada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caratulaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox caratulaPictureBox;
        private MaterialSkin.Controls.MaterialLabel jugadaLabel;
    }
}
