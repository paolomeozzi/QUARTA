using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancaWindow2
{
    public partial class TransazioniForm : Form
    {
        public TransazioniForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboConto.DisplayMember = "Titolare";  
            cboConto.ValueMember = "Numero";    

            cboContoTransazioni.DisplayMember = "Titolare";
            cboContoTransazioni.ValueMember = "Numero";
            
            dgTransazioni.AutoGenerateColumns = false;
            AggiornaVistaConti();
            AggiornaUI();
        }


        private void AggiornaVistaConti()
        {
            var conti = Banca.ElencoConti();
            cboConto.DataSource = conti;
            cboContoTransazioni.DataSource = conti;
        }
        void AggiornaUI()
        {
            DateTime data;
            double importo;
            btnEseguiTransazione.Enabled = txtCausale.Text.Trim() != ""
                && DateTime.TryParse(txtData.Text, out data)
                && double.TryParse(txtValore.Text, out importo)
                && cboConto.SelectedIndex > -1;

            btnVisualizzaTransazioni.Enabled = cboContoTransazioni.SelectedIndex > -1;
        }


        void TextBoxEnter(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Select();
            txt.SelectAll();
        }

        void TextChanges(object sender, EventArgs e)
        {
            AggiornaUI();
        }

        private void btnEseguiTransazione_Click(object sender, EventArgs e)
        {
            var conto = ContoSelezionato(cboConto);
            if (conto == null)
                return;

            conto.EseguiTransazione(DateTime.Parse(txtData.Text), txtCausale.Text.Trim(), double.Parse(txtValore.Text));
        }

        private void btnVisualizzaTransazioni_Click(object sender, EventArgs e)
        {
            var conto = ContoSelezionato(cboContoTransazioni);
            if (conto == null)
                return;
            VisualizzaTransazioni(conto);
            
        }

        ContoCorrente ContoSelezionato(ComboBox elencoConti)
        {
            if (elencoConti.SelectedIndex < 0)
                return null;
            return elencoConti.SelectedItem as ContoCorrente;
        }

        private void cboContoTransazioni_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggiornaUI();
        }

        void VisualizzaTransazioni(ContoCorrente conto)
        {
            //in questo caso non necessario, poiché ogni chiamata a ElencoTransazioni() produce un
            // nuovo elenco, anche se contiene gli stessi dati di prima!
            //dgTransazioni.DataSource = null; 

            dgTransazioni.DataSource = conto.ElencoTransazioni();
        }
        
    }
}
