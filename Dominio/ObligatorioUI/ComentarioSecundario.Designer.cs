
namespace ObligatorioUI
{
    partial class ComentarioSecundario
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
            this.comentarioLabel = new System.Windows.Forms.Label();
            this.meGustaBoton = new MaterialSkin.Controls.MaterialButton();
            this.meGustaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comentarioLabel
            // 
            this.comentarioLabel.Location = new System.Drawing.Point(3, 3);
            this.comentarioLabel.Name = "comentarioLabel";
            this.comentarioLabel.Size = new System.Drawing.Size(342, 36);
            this.comentarioLabel.TabIndex = 0;
            this.comentarioLabel.Text = "label1";
            // 
            // meGustaBoton
            // 
            this.meGustaBoton.AutoSize = false;
            this.meGustaBoton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.meGustaBoton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.meGustaBoton.Depth = 0;
            this.meGustaBoton.HighEmphasis = true;
            this.meGustaBoton.Icon = null;
            this.meGustaBoton.Location = new System.Drawing.Point(339, 9);
            this.meGustaBoton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.meGustaBoton.MouseState = MaterialSkin.MouseState.HOVER;
            this.meGustaBoton.Name = "meGustaBoton";
            this.meGustaBoton.Size = new System.Drawing.Size(32, 23);
            this.meGustaBoton.TabIndex = 1;
            this.meGustaBoton.Text = "♥";
            this.meGustaBoton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.meGustaBoton.UseAccentColor = false;
            this.meGustaBoton.UseVisualStyleBackColor = true;
            this.meGustaBoton.Click += new System.EventHandler(this.meGustaBoton_Click_1);
            // 
            // meGustaLabel
            // 
            this.meGustaLabel.AutoSize = true;
            this.meGustaLabel.Location = new System.Drawing.Point(378, 14);
            this.meGustaLabel.Name = "meGustaLabel";
            this.meGustaLabel.Size = new System.Drawing.Size(35, 13);
            this.meGustaLabel.TabIndex = 2;
            this.meGustaLabel.Text = "label1";
            // 
            // ComentarioSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.meGustaLabel);
            this.Controls.Add(this.meGustaBoton);
            this.Controls.Add(this.comentarioLabel);
            this.Name = "ComentarioSecundario";
            this.Size = new System.Drawing.Size(406, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label comentarioLabel;
        private MaterialSkin.Controls.MaterialButton meGustaBoton;
        private System.Windows.Forms.Label meGustaLabel;
    }
}
