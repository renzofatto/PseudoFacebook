
namespace ObligatorioUI
{
    partial class ComentarioPost
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
            this.comentariosFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.comentarioLabel = new System.Windows.Forms.Label();
            this.comentarioTextBox = new System.Windows.Forms.TextBox();
            this.replyBoton = new MaterialSkin.Controls.MaterialButton();
            this.likeBoton = new MaterialSkin.Controls.MaterialButton();
            this.meGustaLabel = new System.Windows.Forms.Label();
            this.enviarBoton = new MaterialSkin.Controls.MaterialButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comentariosFlowPanel
            // 
            this.comentariosFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comentariosFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comentariosFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.comentariosFlowPanel.Location = new System.Drawing.Point(1, 78);
            this.comentariosFlowPanel.Name = "comentariosFlowPanel";
            this.comentariosFlowPanel.Size = new System.Drawing.Size(409, 71);
            this.comentariosFlowPanel.TabIndex = 0;
            this.comentariosFlowPanel.WrapContents = false;
            // 
            // comentarioLabel
            // 
            this.comentarioLabel.Location = new System.Drawing.Point(2, 0);
            this.comentarioLabel.Name = "comentarioLabel";
            this.comentarioLabel.Size = new System.Drawing.Size(412, 56);
            this.comentarioLabel.TabIndex = 1;
            this.comentarioLabel.Text = "label1";
            // 
            // comentarioTextBox
            // 
            this.comentarioTextBox.Location = new System.Drawing.Point(3, 78);
            this.comentarioTextBox.Name = "comentarioTextBox";
            this.comentarioTextBox.Size = new System.Drawing.Size(404, 20);
            this.comentarioTextBox.TabIndex = 2;
            this.comentarioTextBox.Visible = false;
            // 
            // replyBoton
            // 
            this.replyBoton.AutoSize = false;
            this.replyBoton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.replyBoton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.replyBoton.Depth = 0;
            this.replyBoton.HighEmphasis = true;
            this.replyBoton.Icon = null;
            this.replyBoton.Location = new System.Drawing.Point(4, 56);
            this.replyBoton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.replyBoton.MouseState = MaterialSkin.MouseState.HOVER;
            this.replyBoton.Name = "replyBoton";
            this.replyBoton.Size = new System.Drawing.Size(53, 20);
            this.replyBoton.TabIndex = 3;
            this.replyBoton.Text = "Reply";
            this.replyBoton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.replyBoton.UseAccentColor = false;
            this.replyBoton.UseVisualStyleBackColor = true;
            this.replyBoton.Click += new System.EventHandler(this.replyBoton_Click_1);
            // 
            // likeBoton
            // 
            this.likeBoton.AutoSize = false;
            this.likeBoton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.likeBoton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.likeBoton.Depth = 0;
            this.likeBoton.HighEmphasis = true;
            this.likeBoton.Icon = null;
            this.likeBoton.Location = new System.Drawing.Point(269, 56);
            this.likeBoton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.likeBoton.MouseState = MaterialSkin.MouseState.HOVER;
            this.likeBoton.Name = "likeBoton";
            this.likeBoton.Size = new System.Drawing.Size(32, 20);
            this.likeBoton.TabIndex = 4;
            this.likeBoton.Text = "♥";
            this.likeBoton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.likeBoton.UseAccentColor = false;
            this.likeBoton.UseVisualStyleBackColor = true;
            this.likeBoton.Click += new System.EventHandler(this.likeBoton_Click_1);
            // 
            // meGustaLabel
            // 
            this.meGustaLabel.AutoSize = true;
            this.meGustaLabel.Location = new System.Drawing.Point(302, 60);
            this.meGustaLabel.Name = "meGustaLabel";
            this.meGustaLabel.Size = new System.Drawing.Size(35, 13);
            this.meGustaLabel.TabIndex = 5;
            this.meGustaLabel.Text = "label1";
            // 
            // enviarBoton
            // 
            this.enviarBoton.AutoSize = false;
            this.enviarBoton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enviarBoton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.enviarBoton.Depth = 0;
            this.enviarBoton.HighEmphasis = true;
            this.enviarBoton.Icon = null;
            this.enviarBoton.Location = new System.Drawing.Point(63, 56);
            this.enviarBoton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.enviarBoton.MouseState = MaterialSkin.MouseState.HOVER;
            this.enviarBoton.Name = "enviarBoton";
            this.enviarBoton.Size = new System.Drawing.Size(53, 20);
            this.enviarBoton.TabIndex = 6;
            this.enviarBoton.Text = "Enviar";
            this.enviarBoton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.enviarBoton.UseAccentColor = false;
            this.enviarBoton.UseVisualStyleBackColor = true;
            this.enviarBoton.Visible = false;
            this.enviarBoton.Click += new System.EventHandler(this.enviarBoton_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ComentarioPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.enviarBoton);
            this.Controls.Add(this.meGustaLabel);
            this.Controls.Add(this.likeBoton);
            this.Controls.Add(this.replyBoton);
            this.Controls.Add(this.comentarioTextBox);
            this.Controls.Add(this.comentarioLabel);
            this.Controls.Add(this.comentariosFlowPanel);
            this.Name = "ComentarioPost";
            this.Size = new System.Drawing.Size(413, 149);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel comentariosFlowPanel;
        private System.Windows.Forms.Label comentarioLabel;
        private System.Windows.Forms.TextBox comentarioTextBox;
        private MaterialSkin.Controls.MaterialButton replyBoton;
        private MaterialSkin.Controls.MaterialButton likeBoton;
        private System.Windows.Forms.Label meGustaLabel;
        private MaterialSkin.Controls.MaterialButton enviarBoton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
