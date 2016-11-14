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
    public partial class GestioneContiForm : Form
    {
        public GestioneContiForm()
        {
            InitializeComponent();
        }

        private void menuMain_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item == menuEsci)
            {
                Close();
            }

            if (item == menuTransaction)
            {
                TransazioniForm tf = new TransazioniForm();
                tf.ShowDialog();
                tf.Dispose();
            }

            if (item == menuOpen)
            {
                CaricaContiCorrenti(); 
                VisualizzaConti();
            }

            if (item == menuSave)
            {
                //TODO: salvataggio dati
            }
        }

        void CaricaContiCorrenti()
        {
            StorageContiCorrenti scc = new StorageContiCorrenti();
            ContoCorrente[] conti = null;
            Transazione[] transazioni = null;
            try
            {
                conti = scc.CaricaConti();
                transazioni = scc.CaricaTransazioni();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Banca.InizializzaContiCorrenti();
            foreach (var c in scc.CaricaConti())
                Banca.CreaConto(c.Titolare, c.Saldo);

            foreach (var t in transazioni)
                Banca.EseguiTransazione(t.NumeroConto, t.Data, t.Causale, t.Importo);
        }

        private void btnCreaConto_Click(object sender, EventArgs e)
        {
            var conto = Banca.CreaConto(txtTitolare.Text.Trim(), double.Parse(txtSaldoIniziale.Text));
            VisualizzaConto(conto);
            txtTitolare.Select();
            txtTitolare.SelectAll();
        }

        void AggiornaUI()
        {
            double saldo;
            btnCreaConto.Enabled = double.TryParse(txtSaldoIniziale.Text, out saldo)
                && txtTitolare.Text.Trim() != "";
        }

        void VisualizzaConti()
        {
            dgConti.DataSource = null;
            dgConti.DataSource = Banca.ElencoConti();
            //dgConti.Rows.Clear();
            //foreach (var c in Banca.ElencoConti())
            //    VisualizzaConto(c);

        }

        void VisualizzaConto(ContoCorrente c)
        {
            dgConti.Rows.Add(c.Numero, c.Titolare, c.Saldo);
        }

        private void GestioneContiForm_Load(object sender, EventArgs e)
        {
            dgConti.AutoGenerateColumns = false;
            Banca.GeneraContiETransazioniFake();
            VisualizzaConti();
            AggiornaUI();
        }

        void TextChanges(object sender, EventArgs e)
        {
            AggiornaUI();
        }

        void TextBoxEnter(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            txt.Select();
            txt.SelectAll();
        }


    }
}
