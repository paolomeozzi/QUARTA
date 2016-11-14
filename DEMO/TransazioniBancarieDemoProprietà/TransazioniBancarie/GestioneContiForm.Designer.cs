namespace BancaWindow2
{
    partial class GestioneContiForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitolare = new System.Windows.Forms.TextBox();
            this.txtSaldoIniziale = new System.Windows.Forms.TextBox();
            this.btnCreaConto = new System.Windows.Forms.Button();
            this.dgConti = new System.Windows.Forms.DataGridView();
            this.NumeroConto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titolare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenuBar = new System.Windows.Forms.MenuStrip();
            this.menuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEsci = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConti)).BeginInit();
            this.mainMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTitolare);
            this.groupBox2.Controls.Add(this.txtSaldoIniziale);
            this.groupBox2.Controls.Add(this.btnCreaConto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 176);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Titolare";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(386, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Saldo iniziale";
            // 
            // txtTitolare
            // 
            this.txtTitolare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitolare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitolare.Location = new System.Drawing.Point(17, 62);
            this.txtTitolare.Name = "txtTitolare";
            this.txtTitolare.Size = new System.Drawing.Size(318, 29);
            this.txtTitolare.TabIndex = 1;
            this.txtTitolare.TextChanged += new System.EventHandler(this.TextChanges);
            this.txtTitolare.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // txtSaldoIniziale
            // 
            this.txtSaldoIniziale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldoIniziale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoIniziale.Location = new System.Drawing.Point(390, 62);
            this.txtSaldoIniziale.Name = "txtSaldoIniziale";
            this.txtSaldoIniziale.Size = new System.Drawing.Size(120, 29);
            this.txtSaldoIniziale.TabIndex = 1;
            this.txtSaldoIniziale.TextChanged += new System.EventHandler(this.TextChanges);
            this.txtSaldoIniziale.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // btnCreaConto
            // 
            this.btnCreaConto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreaConto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreaConto.Location = new System.Drawing.Point(17, 107);
            this.btnCreaConto.Name = "btnCreaConto";
            this.btnCreaConto.Size = new System.Drawing.Size(104, 40);
            this.btnCreaConto.TabIndex = 0;
            this.btnCreaConto.Text = "&Crea";
            this.btnCreaConto.UseVisualStyleBackColor = true;
            this.btnCreaConto.Click += new System.EventHandler(this.btnCreaConto_Click);
            // 
            // dgConti
            // 
            this.dgConti.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgConti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgConti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroConto,
            this.Titolare,
            this.Saldo});
            this.dgConti.Location = new System.Drawing.Point(12, 268);
            this.dgConti.Name = "dgConti";
            this.dgConti.ReadOnly = true;
            this.dgConti.Size = new System.Drawing.Size(573, 239);
            this.dgConti.TabIndex = 7;
            // 
            // NumeroConto
            // 
            this.NumeroConto.DataPropertyName = "Numero";
            this.NumeroConto.HeaderText = "N°";
            this.NumeroConto.Name = "NumeroConto";
            this.NumeroConto.ReadOnly = true;
            this.NumeroConto.Width = 75;
            // 
            // Titolare
            // 
            this.Titolare.DataPropertyName = "Titolare";
            this.Titolare.HeaderText = "Titolare";
            this.Titolare.Name = "Titolare";
            this.Titolare.ReadOnly = true;
            this.Titolare.Width = 300;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Saldo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Elenco conti correnti";
            // 
            // mainMenuBar
            // 
            this.mainMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMain});
            this.mainMenuBar.Location = new System.Drawing.Point(0, 0);
            this.mainMenuBar.Name = "mainMenuBar";
            this.mainMenuBar.Size = new System.Drawing.Size(605, 24);
            this.mainMenuBar.TabIndex = 9;
            this.mainMenuBar.Text = "menuStrip1";
            // 
            // menuMain
            // 
            this.menuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTransaction,
            this.menuOpen,
            this.menuSave,
            this.toolStripSeparator1,
            this.menuEsci});
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(76, 20);
            this.menuMain.Text = "Operazioni";
            // 
            // menuTransaction
            // 
            this.menuTransaction.Name = "menuTransaction";
            this.menuTransaction.Size = new System.Drawing.Size(152, 22);
            this.menuTransaction.Text = "Transazioni";
            this.menuTransaction.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(152, 22);
            this.menuOpen.Text = "Apri";
            this.menuOpen.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // menuSave
            // 
            this.menuSave.Enabled = false;
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(152, 22);
            this.menuSave.Text = "Salva";
            this.menuSave.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // menuEsci
            // 
            this.menuEsci.Name = "menuEsci";
            this.menuEsci.Size = new System.Drawing.Size(152, 22);
            this.menuEsci.Text = "Esci";
            this.menuEsci.Click += new System.EventHandler(this.menuMain_Click);
            // 
            // GestioneContiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgConti);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mainMenuBar);
            this.MainMenuStrip = this.mainMenuBar;
            this.Name = "GestioneContiForm";
            this.Text = "Gestione conti correnti";
            this.Load += new System.EventHandler(this.GestioneContiForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConti)).EndInit();
            this.mainMenuBar.ResumeLayout(false);
            this.mainMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitolare;
        private System.Windows.Forms.TextBox txtSaldoIniziale;
        private System.Windows.Forms.Button btnCreaConto;
        private System.Windows.Forms.DataGridView dgConti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mainMenuBar;
        private System.Windows.Forms.ToolStripMenuItem menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuTransaction;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuEsci;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroConto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titolare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
    }
}