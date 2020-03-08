namespace FotoGallery.GUI
{
    partial class FotoForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picFoto
            // 
            this.picFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFoto.Location = new System.Drawing.Point(0, 0);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(160, 55);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // FotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(160, 55);
            this.Controls.Add(this.picFoto);
            this.Name = "FotoForm";
            this.Text = "FotoForm";
            this.Activated += new System.EventHandler(this.FotoForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFoto;
    }
}