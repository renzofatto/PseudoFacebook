
namespace ObligatorioUI
{
    partial class EncuestaFeed
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
            this.encuestaMaterialTextBox = new MaterialSkin.Controls.MaterialLabel();
            this.VotarMaterialButton = new MaterialSkin.Controls.MaterialButton();
            this.GraficaMaterialButton = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // encuestaMaterialTextBox
            // 
            this.encuestaMaterialTextBox.AutoSize = true;
            this.encuestaMaterialTextBox.Depth = 0;
            this.encuestaMaterialTextBox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.encuestaMaterialTextBox.Location = new System.Drawing.Point(2, 29);
            this.encuestaMaterialTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.encuestaMaterialTextBox.Name = "encuestaMaterialTextBox";
            this.encuestaMaterialTextBox.Size = new System.Drawing.Size(182, 19);
            this.encuestaMaterialTextBox.TabIndex = 0;
            this.encuestaMaterialTextBox.Text = "EncuestaMaterialTextBox";
            // 
            // VotarMaterialButton
            // 
            this.VotarMaterialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VotarMaterialButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.VotarMaterialButton.Depth = 0;
            this.VotarMaterialButton.HighEmphasis = true;
            this.VotarMaterialButton.Icon = null;
            this.VotarMaterialButton.Location = new System.Drawing.Point(304, 71);
            this.VotarMaterialButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.VotarMaterialButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.VotarMaterialButton.Name = "VotarMaterialButton";
            this.VotarMaterialButton.Size = new System.Drawing.Size(69, 36);
            this.VotarMaterialButton.TabIndex = 6;
            this.VotarMaterialButton.Text = "Votar";
            this.VotarMaterialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.VotarMaterialButton.UseAccentColor = false;
            this.VotarMaterialButton.UseVisualStyleBackColor = true;
            this.VotarMaterialButton.Click += new System.EventHandler(this.VotarMaterialButton_Click);
            // 
            // GraficaMaterialButton
            // 
            this.GraficaMaterialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GraficaMaterialButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.GraficaMaterialButton.Depth = 0;
            this.GraficaMaterialButton.HighEmphasis = true;
            this.GraficaMaterialButton.Icon = null;
            this.GraficaMaterialButton.Location = new System.Drawing.Point(298, 19);
            this.GraficaMaterialButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GraficaMaterialButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GraficaMaterialButton.Name = "GraficaMaterialButton";
            this.GraficaMaterialButton.Size = new System.Drawing.Size(82, 36);
            this.GraficaMaterialButton.TabIndex = 7;
            this.GraficaMaterialButton.Text = "Grafica";
            this.GraficaMaterialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.GraficaMaterialButton.UseAccentColor = false;
            this.GraficaMaterialButton.UseVisualStyleBackColor = true;
            this.GraficaMaterialButton.Click += new System.EventHandler(this.GraficaMaterialButton_Click);
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(2, 58);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(252, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EncuestaFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.GraficaMaterialButton);
            this.Controls.Add(this.VotarMaterialButton);
            this.Controls.Add(this.encuestaMaterialTextBox);
            this.Name = "EncuestaFeed";
            this.Size = new System.Drawing.Size(400, 166);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel encuestaMaterialTextBox;
        private MaterialSkin.Controls.MaterialButton VotarMaterialButton;
        private MaterialSkin.Controls.MaterialButton GraficaMaterialButton;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
