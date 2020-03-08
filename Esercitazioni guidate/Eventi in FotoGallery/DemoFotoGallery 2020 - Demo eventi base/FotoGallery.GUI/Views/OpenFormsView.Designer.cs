namespace FotoGallery.GUI
{
    partial class OpenFormsView
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
            this.pnlPicture = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnlPicture
            // 
            this.pnlPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPicture.Location = new System.Drawing.Point(0, 0);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(322, 72);
            this.pnlPicture.TabIndex = 0;
            // 
            // OpenFormsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPicture);
            this.Name = "OpenFormsView";
            this.Size = new System.Drawing.Size(322, 72);
            this.Load += new System.EventHandler(this.OpenFormsView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlPicture;
    }
}
