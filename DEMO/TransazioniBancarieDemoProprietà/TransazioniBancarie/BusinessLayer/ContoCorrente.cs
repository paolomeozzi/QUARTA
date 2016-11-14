using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaWindow2
{
    /*
     CONTO CORRENTE
     Incapsula i dati di un conto corrente e l'esecuzione delle sue transazioni
     Numero e Titolare non possono essere modificati dopo la creazione.
     (Il Numero viene generato esternamente da Banca)
    */
    public class ContoCorrente
    {
        List<Transazione> transazioni = new List<Transazione>();

        int progressivoTransazioni = 0;
        public ContoCorrente(int numero, string titolare, double saldoIniziale)
        {
            if (saldoIniziale < 0)
                throw new ArgumentOutOfRangeException("saldoIniziale");

            if (titolare == null)
                throw new ArgumentNullException("titolare");
            this.numero = numero;
            this.titolare = titolare;
            this.saldo = saldoIniziale;
        }
        
        private int numero;
        private string titolare;
        private double saldo;
        public int Numero { get { return numero; } }
        public string Titolare { get { return titolare; } }
        public double Saldo { get {return saldo; }}
        
        public Transazione[] ElencoTransazioni()
        {
            return transazioni.ToArray();
        }
        public Transazione EseguiTransazione(DateTime data, string causale, double importo)
        {
            if (causale == null)
                throw new ArgumentNullException("titolare");
            var t = new Transazione
            {
                Numero = NumeroTransazione(),
                NumeroConto = this.Numero, 
                Data = data,
                Causale = causale,
                Importo = importo
            };
            saldo += t.Importo;
            transazioni.Add(t);
            return t;
        }

        private int NumeroTransazione()
        {
            return ++progressivoTransazioni;
        }
    
    }
}
