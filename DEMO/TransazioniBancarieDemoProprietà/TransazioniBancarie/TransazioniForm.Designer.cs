namespace BancaWindow2
{
    partial class TransazioniForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVisualizzaTransazioni = new System.Windows.Forms.Button();
            this.dgTransazioni = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboConto = new System.Windows.Forms.ComboBox();
            this.txtCausale = new System.Windows.Forms.TextBox();
            this.txtValore = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnEseguiTransazione = new System.Windows.Forms.Button();
            this.cboContoTransazioni = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumeroTransazione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContoTransazione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataTransazione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CausaleTransazione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportoTransazione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransazioni)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVisualizzaTransazioni
            // 
            this.btnVisualizzaTransazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizzaTransazioni.Location = new System.Drawing.Point(25, 220);
            this.btnVisualizzaTransazioni.Name = "btnVisualizzaTransazioni";
            this.btnVisualizzaTransazioni.Size = new System.Drawing.Size(198, 40);
            this.btnVisualizzaTransazioni.TabIndex = 7;
            this.btnVisualizzaTransazioni.Text = "Visualizza Transazioni";
            this.btnVisualizzaTransazioni.UseVisualStyleBackColor = true;
            this.btnVisualizzaTransazioni.Click += new System.EventHandler(this.btnVisualizzaTransazioni_Click);
            // 
            // dgTransazioni
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTransazioni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTransazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransazioni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroTransazione,
            this.ContoTransazione,
            this.DataTransazione,
            this.CausaleTransazione,
            this.ImportoTransazione});
            this.dgTransazioni.Location = new System.Drawing.Point(25, 283);
            this.dgTransazioni.Name = "dgTransazioni";
            this.dgTransazioni.Size = new System.Drawing.Size(727, 239);
            this.dgTransazioni.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboConto);
            this.groupBox1.Controls.Add(this.txtCausale);
            this.groupBox1.Controls.Add(this.txtValore);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.btnEseguiTransazione);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 174);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuova transazione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Causale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Conto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valore";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data";
            // 
            // cboConto
            // 
            this.cboConto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConto.FormattingEnabled = true;
            this.cboConto.Location = new System.Drawing.Point(157, 125);
            this.cboConto.Name = "cboConto";
            this.cboConto.Size = new System.Drawing.Size(276, 32);
            this.cboConto.TabIndex = 4;
            this.cboConto.SelectedIndexChanged += new System.EventHandler(this.TextChanges);
            // 
            // txtCausale
            // 
            this.txtCausale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCausale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCausale.Location = new System.Drawing.Point(157, 55);
            this.txtCausale.Name = "txtCausale";
            this.txtCausale.Size = new System.Drawing.Size(416, 29);
            this.txtCausale.TabIndex = 2;
            this.txtCausale.TextChanged += new System.EventHandler(this.TextChanges);
            this.txtCausale.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // txtValore
            // 
            this.txtValore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValore.Location = new System.Drawing.Point(17, 128);
            this.txtValore.Name = "txtValore";
            this.txtValore.Size = new System.Drawing.Size(120, 29);
            this.txtValore.TabIndex = 3;
            this.txtValore.TextChanged += new System.EventHandler(this.TextChanges);
            this.txtValore.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(17, 55);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(120, 29);
            this.txtData.TabIndex = 1;
            this.txtData.TextChanged += new System.EventHandler(this.TextChanges);
            this.txtData.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // btnEseguiTransazione
            // 
            this.btnEseguiTransazione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEseguiTransazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEseguiTransazione.Location = new System.Drawing.Point(449, 121);
            this.btnEseguiTransazione.Name = "btnEseguiTransazione";
            this.btnEseguiTransazione.Size = new System.Drawing.Size(104, 40);
            this.btnEseguiTransazione.TabIndex = 5;
            this.btnEseguiTransazione.Text = "Esegui";
            this.btnEseguiTransazione.UseVisualStyleBackColor = true;
            this.btnEseguiTransazione.Click += new System.EventHandler(this.btnEseguiTransazione_Click);
            // 
            // cboContoTransazioni
            // 
            this.cboContoTransazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboContoTransazioni.FormattingEnabled = true;
            this.cboContoTransazioni.Location = new System.Drawing.Point(264, 228);
            this.cboContoTransazioni.Name = "cboContoTransazioni";
            this.cboContoTransazioni.Size = new System.Drawing.Size(288, 32);
            this.cboContoTransazioni.TabIndex = 8;
            this.cboContoTransazioni.SelectedIndexChanged += new System.EventHandler(this.cboContoTransazioni_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Conto";
            // 
            // NumeroTransazione
            // 
            this.NumeroTransazione.DataPropertyName = "Numero";
            this.NumeroTransazione.HeaderText = "N°";
            this.NumeroTransazione.Name = "NumeroTransazione";
            this.NumeroTransazione.Width = 75;
            // 
            // ContoTransazione
            // 
            this.ContoTransazione.DataPropertyName = "NumeroConto";
            this.ContoTransazione.HeaderText = "Conto";
            this.ContoTransazione.Name = "ContoTransazione";
            this.ContoTransazione.Width = 75;
            // 
            // DataTransazione
            // 
            this.DataTransazione.DataPropertyName = "Data";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DataTransazione.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataTransazione.HeaderText = "Data";
            this.DataTransazione.Name = "DataTransazione";
            // 
            // CausaleTransazione
            // 
            this.CausaleTransazione.DataPropertyName = "Causale";
            this.CausaleTransazione.HeaderText = "Causale";
            this.CausaleTransazione.Name = "CausaleTransazione";
            this.CausaleTransazione.Width = 300;
            // 
            // ImportoTransazione
            // 
            this.ImportoTransazione.DataPropertyName = "Importo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.ImportoTransazione.DefaultCellStyle = dataGridViewCellStyle3;
            this.ImportoTransazione.HeaderText = "Importo";
            this.ImportoTransazione.Name = "ImportoTransazione";
            // 
            // TransazioniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 528);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboContoTransazioni);
            this.Controls.Add(this.btnVisualizzaTransazioni);
            this.Controls.Add(this.dgTransazioni);
            this.Controls.Add(this.groupBox1);
            this.Name = "TransazioniForm";
            this.Text = "Gestione transazioni";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransazioni)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisualizzaTransazioni;
        private System.Windows.Forms.DataGridView dgTransazioni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboConto;
        private System.Windows.Forms.TextBox txtCausale;
        private System.Windows.Forms.TextBox txtValore;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnEseguiTransazione;
        private System.Windows.Forms.ComboBox cboContoTransazioni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTransazione;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContoTransazione;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataTransazione;
        private System.Windows.Forms.DataGridViewTextBoxColumn CausaleTransazione;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportoTransazione;
    }
}

