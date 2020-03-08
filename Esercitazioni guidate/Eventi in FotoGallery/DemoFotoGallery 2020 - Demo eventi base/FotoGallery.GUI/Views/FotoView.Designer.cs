namespace FotoGallery.GUI
{
    partial class FotoView
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
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.tipFoto = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picFoto
            // 
            this.picFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFoto.Location = new System.Drawing.Point(5, 5);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(140, 140);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // tipFoto
            // 
            this.tipFoto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tipFoto.ForeColor = System.Drawing.SystemColors.Info;
            this.tipFoto.IsBalloon = true;
            // 
            // FotoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picFoto);
            this.Name = "FotoView";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Load += new System.EventHandler(this.FotoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.ToolTip tipFoto;
    }
}
