namespace ValidationFramework.GUI
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
            this.txtDataNascita = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtNominativo = new System.Windows.Forms.TextBox();
            this.btnRegistra = new System.Windows.Forms.Button();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDataNascita
            // 
            this.txtDataNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascita.Location = new System.Drawing.Point(264, 21);
            this.txtDataNascita.Name = "txtDataNascita";
            this.txtDataNascita.Size = new System.Drawing.Size(111, 31);
            this.txtDataNascita.TabIndex = 0;
            this.txtDataNascita.Text = "1/1/1997";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(22, 77);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(353, 31);
            this.txtMail.TabIndex = 0;
            this.txtMail.Text = "valentino.fabbri@aruba.it";
            // 
            // txtNominativo
            // 
            this.txtNominativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNominativo.Location = new System.Drawing.Point(22, 21);
            this.txtNominativo.Name = "txtNominativo";
            this.txtNominativo.Size = new System.Drawing.Size(202, 31);
            this.txtNominativo.TabIndex = 0;
            this.txtNominativo.Text = "Fabbri, Valentino";
            // 
            // btnRegistra
            // 
            this.btnRegistra.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRegistra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistra.Location = new System.Drawing.Point(134, 132);
            this.btnRegistra.Name = "btnRegistra";
            this.btnRegistra.Size = new System.Drawing.Size(139, 41);
            this.btnRegistra.TabIndex = 1;
            this.btnRegistra.Text = "&Registra";
            this.btnRegistra.UseVisualStyleBackColor = true;
            this.btnRegistra.Click += new System.EventHandler(this.btnRegistra_Click);
            // 
            // lblRisultato
            // 
            this.lblRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRisultato.Location = new System.Drawing.Point(17, 190);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(358, 45);
            this.lblRisultato.TabIndex = 2;
            this.lblRisultato.Text = "N.D.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 255);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.btnRegistra);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtNominativo);
            this.Controls.Add(this.txtDataNascita);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDataNascita;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtNominativo;
        private System.Windows.Forms.Button btnRegistra;
        private System.Windows.Forms.Label lblRisultato;
    }
}

