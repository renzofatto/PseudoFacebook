
namespace ObligatorioUI
{
    partial class GenericoFeed
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
            this.FlowPanelContenido = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reaccionesBoton = new MaterialSkin.Controls.MaterialButton();
            this.felicitacionLabel = new System.Windows.Forms.Label();
            this.meEncantaLabel = new System.Windows.Forms.Label();
            this.meGustaLabel = new System.Windows.Forms.Label();
            this.felicitacionBoton = new MaterialSkin.Controls.MaterialButton();
            this.meEncantaBoton = new MaterialSkin.Controls.MaterialButton();
            this.megustaBoton = new MaterialSkin.Controls.MaterialButton();
            this.commentButton = new MaterialSkin.Controls.MaterialButton();
            this.comentarioTextBox = new System.Windows.Forms.TextBox();
            this.comentarioFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.reactoresListBox = new System.Windows.Forms.ListBox();
            this.FlowPanelContenido.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowPanelContenido
            // 
            this.FlowPanelContenido.AutoSize = true;
            this.FlowPanelContenido.Controls.Add(this.comentarioFlowPanel);
            this.FlowPanelContenido.Controls.Add(this.comentarioTextBox);
            this.FlowPanelContenido.Controls.Add(this.panel1);
            this.FlowPanelContenido.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.FlowPanelContenido.Location = new System.Drawing.Point(18, 10);
            this.FlowPanelContenido.Name = "FlowPanelContenido";
            this.FlowPanelContenido.Size = new System.Drawing.Size(437, 178);
            this.FlowPanelContenido.TabIndex = 0;
            this.FlowPanelContenido.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reaccionesBoton);
            this.panel1.Controls.Add(this.felicitacionLabel);
            this.panel1.Controls.Add(this.meEncantaLabel);
            this.panel1.Controls.Add(this.meGustaLabel);
            this.panel1.Controls.Add(this.felicitacionBoton);
            this.panel1.Controls.Add(this.meEncantaBoton);
            this.panel1.Controls.Add(this.megustaBoton);
            this.panel1.Controls.Add(this.commentButton);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 28);
            this.panel1.TabIndex = 2;
            // 
            // reaccionesBoton
            // 
            this.reaccionesBoton.AutoSize = false;
            this.reaccionesBoton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reaccionesBoton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.reaccionesBoton.Depth = 0;
            this.reaccionesBoton.HighEmphasis = true;
            this.reaccionesBoton.Icon = null;
            this.reaccionesBoton.Location = new System.Drawing.Point(401, 7);
            this.reaccionesBoton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.reaccionesBoton.MouseState = MaterialSkin.MouseState.HOVER;
            this.reaccionesBoton.Name = "reaccionesBoton";
            this.reaccionesBoton.Size = new System.Drawing.Size(18, 16);
            this.reaccionesBoton.TabIndex = 7;
            this.reaccionesBoton.Text = "→";
            this.reaccionesBoton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.reaccionesBoton.UseAccentColor = false;
            this.reaccionesBoton.UseVisualStyleBackColor = true;
            this.reaccionesBoton.Click += new System.EventHandler(this.reaccionesBoton_Click);
            // 
            // felicitacionLabel
            // 
            this.felicitacionLabel.AutoSize = true;
            this.felicitacionLabel.Location = new System.Drawing.Point(361, 9);
            this.felicitacionLabel.Name = "felicitacionLabel";
            this.felicitacionLabel.Size = new System.Drawing.Size(35, 13);
            this.felicitacionLabel.TabIndex = 6;
            this.felicitacionLabel.Text = "label3";
            // 
            // meEncantaLabel
            // 
            this.meEncantaLabel.AutoSize = true;
            this.meEncantaLabel.Location = new System.Drawing.Point(289, 9);
            this.meEncantaLabel.Name = "meEncantaLabel";
            this.meEncantaLabel.Size = new System.Drawing.Size(35, 13);
            this.meEncantaLabel.TabIndex = 5;
            this.meEncantaLabel.Text = "label2";
            // 
            // meGustaLabel
            // 
            this.meGustaLabel.AutoSize = true;
            this.meGustaLabel.Location = new System.Drawing.Point(218, 9);
            this.meGustaLabel.Name = "meGustaLabel";
            this.meGustaLabel.Size = new System.Drawing.Size(35, 13);
            this.meGustaLabel.TabIndex = 4;
            this.meGustaLabel.Text = "label1";
            // 
            // felicitacionBoton
            // 
            this.felicitacionBoton.AutoSize = false;
            this.felicitacionBoton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.felicitacionBoton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.felicitacionBoton.Depth = 0;
            this.felicitacionBoton.HighEmphasis = true;
            this.felicitacionBoton.Icon = null;
            this.felicitacionBoton.Location = new System.Drawing.Point(328, 3);
            this.felicitacionBoton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.felicitacionBoton.MouseState = MaterialSkin.MouseState.HOVER;
            this.felicitacionBoton.Name = "felicitacionBoton";
            this.felicitacionBoton.Size = new System.Drawing.Size(32, 22);
            this.felicitacionBoton.TabIndex = 3;
            this.felicitacionBoton.Text = "☺";
            this.felicitacionBoton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.felicitacionBoton.UseAccentColor = false;
            this.felicitacionBoton.UseVisualStyleBackColor = true;
            this.felicitacionBoton.Click += new System.EventHandler(this.felicitacionBoton_Click);
            // 
            // meEncantaBoton
            // 
            this.meEncantaBoton.AutoSize = false;
            this.meEncantaBoton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.meEncantaBoton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.meEncantaBoton.Depth = 0;
            this.meEncantaBoton.HighEmphasis = true;
            this.meEncantaBoton.Icon = null;
            this.meEncantaBoton.Location = new System.Drawing.Point(255, 3);
            this.meEncantaBoton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.meEncantaBoton.MouseState = MaterialSkin.MouseState.HOVER;
            this.meEncantaBoton.Name = "meEncantaBoton";
            this.meEncantaBoton.Size = new System.Drawing.Size(32, 22);
            this.meEncantaBoton.TabIndex = 2;
            this.meEncantaBoton.Text = "☻";
            this.meEncantaBoton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.meEncantaBoton.UseAccentColor = false;
            this.meEncantaBoton.UseVisualStyleBackColor = true;
            this.meEncantaBoton.Click += new System.EventHandler(this.meEncantaBoton_Click);
            // 
            // megustaBoton
            // 
            this.megustaBoton.AutoSize = false;
            this.megustaBoton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.megustaBoton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.megustaBoton.Depth = 0;
            this.megustaBoton.HighEmphasis = true;
            this.megustaBoton.Icon = null;
            this.megustaBoton.Location = new System.Drawing.Point(185, 3);
            this.megustaBoton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.megustaBoton.MouseState = MaterialSkin.MouseState.HOVER;
            this.megustaBoton.Name = "megustaBoton";
            this.megustaBoton.Size = new System.Drawing.Size(32, 22);
            this.megustaBoton.TabIndex = 1;
            this.megustaBoton.Text = "♥";
            this.megustaBoton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.megustaBoton.UseAccentColor = false;
            this.megustaBoton.UseVisualStyleBackColor = true;
            this.megustaBoton.Click += new System.EventHandler(this.megustaBoton_Click);
            // 
            // commentButton
            // 
            this.commentButton.AutoSize = false;
            this.commentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.commentButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.commentButton.Depth = 0;
            this.commentButton.HighEmphasis = true;
            this.commentButton.Icon = null;
            this.commentButton.Location = new System.Drawing.Point(4, 2);
            this.commentButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.commentButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(89, 24);
            this.commentButton.TabIndex = 0;
            this.commentButton.Text = "comentar";
            this.commentButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.commentButton.UseAccentColor = false;
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // comentarioTextBox
            // 
            this.comentarioTextBox.Location = new System.Drawing.Point(3, 40);
            this.comentarioTextBox.Name = "comentarioTextBox";
            this.comentarioTextBox.Size = new System.Drawing.Size(431, 20);
            this.comentarioTextBox.TabIndex = 1;
            // 
            // comentarioFlowPanel
            // 
            this.comentarioFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comentarioFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.comentarioFlowPanel.Location = new System.Drawing.Point(3, 66);
            this.comentarioFlowPanel.Name = "comentarioFlowPanel";
            this.comentarioFlowPanel.Size = new System.Drawing.Size(431, 109);
            this.comentarioFlowPanel.TabIndex = 0;
            this.comentarioFlowPanel.WrapContents = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // reactoresListBox
            // 
            this.reactoresListBox.FormattingEnabled = true;
            this.reactoresListBox.Location = new System.Drawing.Point(8, 13);
            this.reactoresListBox.Name = "reactoresListBox";
            this.reactoresListBox.Size = new System.Drawing.Size(407, 186);
            this.reactoresListBox.TabIndex = 1;
            this.reactoresListBox.Visible = false;
            // 
            // GenericoFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.reactoresListBox);
            this.Controls.Add(this.FlowPanelContenido);
            this.Name = "GenericoFeed";
            this.Size = new System.Drawing.Size(458, 250);
            this.FlowPanelContenido.ResumeLayout(false);
            this.FlowPanelContenido.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPanelContenido;
        private System.Windows.Forms.FlowLayoutPanel comentarioFlowPanel;
        private System.Windows.Forms.TextBox comentarioTextBox;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton felicitacionBoton;
        private MaterialSkin.Controls.MaterialButton meEncantaBoton;
        private MaterialSkin.Controls.MaterialButton megustaBoton;
        private MaterialSkin.Controls.MaterialButton commentButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label felicitacionLabel;
        private System.Windows.Forms.Label meEncantaLabel;
        private System.Windows.Forms.Label meGustaLabel;
        private System.Windows.Forms.ListBox reactoresListBox;
        private MaterialSkin.Controls.MaterialButton reaccionesBoton;
    }
}
