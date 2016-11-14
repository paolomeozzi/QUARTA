using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaWindow2
{
    /*
     BANCA
     Implementato come modulo. 
     (In scenari realistici sarebbe comunque implementato come oggetto.)
     In questo caso, l'uso di un modulo facilita il suo impiego in parti diverse dell'applicazione.
     (Non c'è bisogno di implementare un meccanismo che consenta di condividere il 
     riferimento allo stesso oggetto globale).
     */
    public static class Banca
    {
        static List<ContoCorrente> conti = new List<ContoCorrente>();
        static int progressivoConti = 0;

        public static void InizializzaContiCorrenti()
        {
            progressivoConti = 0;
            conti.Clear();
        }
        public static ContoCorrente CreaConto(string titolare, double saldoIniziale)
        {
            var conto = new ContoCorrente(NumeroConto(), titolare, saldoIniziale);
            conti.Add(conto);
            return conto;
        }

        public static void EseguiTransazione(int numeroConto, DateTime data, string causale, double importo)
        {
            var conto = CercaConto(numeroConto);
            if (conto == null)
                throw new InvalidOperationException("Il numero conto non esiste");
            conto.EseguiTransazione(data, causale, importo);
        }

        //->In uno scenario realistico, verrebbe restituita un'interfaccia, ad esempio IList, IReadonlyList o IEnumerable
        public static ContoCorrente[] ElencoConti()
        {
            return conti.ToArray();
        }

        public static ContoCorrente CercaConto(int numero)
        {
            foreach (var c in conti)
            {
                if (c.Numero == numero)
                    return c;
            }
            return null;
        }

        // NOTA: questo metodo esiste solo per semplificare una funzionalità della UI
        // (accesso al conto selezionato nel combobox) e soltanto perché non sto
        // bindando i dati alla UI
        // E' un esempio di progettazione sub-ottimale, poiché si implementa qualcosa
        // nel business layer soltanto perché, forse, è utile nella UI
        
        //NOTA: non più utulizzato!
        public static ContoCorrente ContoDaIndice(int indice)
        {
            if (indice < 0 || indice > conti.Count - 1)
                throw new ArgumentOutOfRangeException("indice");

            return conti[indice];
        }

        private static int NumeroConto()
        {
            return ++progressivoConti;
        }

        public static void GeneraContiETransazioniFake()
        {
            conti.Clear();
            CreaConto("Rossi, Andrea", 3000);
            CreaConto("Bianchi, Filippo", 1000);
            CreaConto("Verdi, Stefania", 200);
            CreaConto("Bianchi, Sonia", 0);
            CreaConto("Gialli, Franco", 2000);

            var c = conti[0];
            c.EseguiTransazione(new DateTime(2016, 5, 10), "Bonifico in uscita", -1000);
            c.EseguiTransazione(new DateTime(2016, 5, 21), "Prelievo bancomat", -250);
            c.EseguiTransazione(new DateTime(2016, 7, 2), "Accredito stipendio", 1350);

            c = conti[1];
            c.EseguiTransazione(new DateTime(2016, 3, 1), "Bonifico in entrata", 575);
            c.EseguiTransazione(new DateTime(2016, 7, 22), "Assegno", -620);

            c = conti[2];
            c.EseguiTransazione(new DateTime(2016, 8, 11), "Accredito stipendio", 2150);
            c.EseguiTransazione(new DateTime(2016, 8, 21), "Prelievo bancomat", -500);
            c.EseguiTransazione(new DateTime(2016, 9, 17), "Assegno", -345);
            c.EseguiTransazione(new DateTime(2016, 9, 17), "Carta credito", -210);
        }

     }
}
