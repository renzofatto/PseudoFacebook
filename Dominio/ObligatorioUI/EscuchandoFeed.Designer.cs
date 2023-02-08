
namespace ObligatorioUI
{
    partial class EscuchandoFeed
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
            this.escuchandoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // escuchandoLabel
            // 
            this.escuchandoLabel.AutoSize = true;
            this.escuchandoLabel.Depth = 0;
            this.escuchandoLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.escuchandoLabel.Location = new System.Drawing.Point(3, 18);
            this.escuchandoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.escuchandoLabel.Name = "escuchandoLabel";
            this.escuchandoLabel.Size = new System.Drawing.Size(107, 19);
            this.escuchandoLabel.TabIndex = 0;
            this.escuchandoLabel.Text = "materialLabel1";
            // 
            // EscuchandoFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.escuchandoLabel);
            this.Name = "EscuchandoFeed";
            this.Size = new System.Drawing.Size(428, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel escuchandoLabel;
    }
}
