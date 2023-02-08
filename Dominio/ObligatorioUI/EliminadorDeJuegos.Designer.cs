
namespace ObligatorioUI
{
    partial class EliminadorDeJuegos
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
            this.juegosEliminablesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // juegosEliminablesPanel
            // 
            this.juegosEliminablesPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.juegosEliminablesPanel.AutoScroll = true;
            this.juegosEliminablesPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.juegosEliminablesPanel.Location = new System.Drawing.Point(1, 1);
            this.juegosEliminablesPanel.Name = "juegosEliminablesPanel";
            this.juegosEliminablesPanel.Size = new System.Drawing.Size(250, 318);
            this.juegosEliminablesPanel.TabIndex = 0;
            this.juegosEliminablesPanel.WrapContents = false;
            // 
            // EliminadorDeJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.juegosEliminablesPanel);
            this.Name = "EliminadorDeJuegos";
            this.Size = new System.Drawing.Size(253, 321);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel juegosEliminablesPanel;
    }
}
