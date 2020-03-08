namespace FotoGallery.GUI
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statFotoSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainBar = new System.Windows.Forms.Panel();
            this.pnlOpenForms = new System.Windows.Forms.Panel();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.pnlGallery = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlMainBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statFotoSelected});
            this.statusStrip1.Location = new System.Drawing.Point(0, 598);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(956, 35);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statFotoSelected
            // 
            this.statFotoSelected.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statFotoSelected.Name = "statFotoSelected";
            this.statFotoSelected.Size = new System.Drawing.Size(66, 30);
            this.statFotoSelected.Text = "[N.D.]";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWindows});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuWindows
            // 
            this.menuWindows.Name = "menuWindows";
            this.menuWindows.Size = new System.Drawing.Size(60, 20);
            this.menuWindows.Text = "Finestre";
            // 
            // pnlMainBar
            // 
            this.pnlMainBar.Controls.Add(this.pnlOpenForms);
            this.pnlMainBar.Controls.Add(this.txtTags);
            this.pnlMainBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainBar.Location = new System.Drawing.Point(0, 24);
            this.pnlMainBar.Name = "pnlMainBar";
            this.pnlMainBar.Size = new System.Drawing.Size(956, 49);
            this.pnlMainBar.TabIndex = 3;
            // 
            // pnlOpenForms
            // 
            this.pnlOpenForms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOpenForms.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlOpenForms.Location = new System.Drawing.Point(285, 3);
            this.pnlOpenForms.Name = "pnlOpenForms";
            this.pnlOpenForms.Size = new System.Drawing.Size(668, 40);
            this.pnlOpenForms.TabIndex = 2;
            // 
            // txtTags
            // 
            this.txtTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTags.Location = new System.Drawing.Point(12, 12);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(267, 31);
            this.txtTags.TabIndex = 1;
            this.txtTags.TextChanged += new System.EventHandler(this.txtTags_TextChanged);
            // 
            // pnlGallery
            // 
            this.pnlGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGallery.Location = new System.Drawing.Point(0, 73);
            this.pnlGallery.Name = "pnlGallery";
            this.pnlGallery.Size = new System.Drawing.Size(956, 525);
            this.pnlGallery.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 633);
            this.Controls.Add(this.pnlGallery);
            this.Controls.Add(this.pnlMainBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMainBar.ResumeLayout(false);
            this.pnlMainBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statFotoSelected;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuWindows;
        private System.Windows.Forms.Panel pnlMainBar;
        private System.Windows.Forms.Panel pnlOpenForms;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.FlowLayoutPanel pnlGallery;
    }
}

