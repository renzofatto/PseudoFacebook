
namespace ObligatorioUI
{
    partial class Feed
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
            this.feedControlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // feedControlPanel
            // 
            this.feedControlPanel.AutoSize = true;
            this.feedControlPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.feedControlPanel.Location = new System.Drawing.Point(0, 3);
            this.feedControlPanel.Name = "feedControlPanel";
            this.feedControlPanel.Size = new System.Drawing.Size(673, 142);
            this.feedControlPanel.TabIndex = 0;
            this.feedControlPanel.WrapContents = false;
            // 
            // Feed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.feedControlPanel);
            this.Name = "Feed";
            this.Size = new System.Drawing.Size(676, 158);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel feedControlPanel;
    }
}
