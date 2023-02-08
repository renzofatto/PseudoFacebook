
namespace ObligatorioUI
{
    partial class EstadoFeed
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
            this.estadoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Depth = 0;
            this.estadoLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.estadoLabel.Location = new System.Drawing.Point(3, 17);
            this.estadoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(107, 19);
            this.estadoLabel.TabIndex = 0;
            this.estadoLabel.Text = "materialLabel1";
            // 
            // EstadoFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.estadoLabel);
            this.Name = "EstadoFeed";
            this.Size = new System.Drawing.Size(428, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel estadoLabel;
    }
}
