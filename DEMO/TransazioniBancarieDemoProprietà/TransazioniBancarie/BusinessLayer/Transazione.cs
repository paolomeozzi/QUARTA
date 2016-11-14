using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaWindow2
{
    /*
     TRANSAZIONE
     Versione "record"
     */
    public class Transazione
    {
        public int Numero { get;  set; }
        public int NumeroConto { get; set;}
        public DateTime Data { get;  set; }
        public string Causale { get;  set; }
        public double Importo { get;  set; }
    }

    /*
     TRANSAZIONE
     Versione "oggetto immutabile" (esegue validazione causale)
     */
    public class Transazione2
    {
        public Transazione2(int numero, DateTime data, ContoCorrente conto, string causale, double importo)
        {
            if (causale == null)
                throw new ArgumentNullException("causale");
            Numero = numero;
            Data = data;
            Conto = conto;
            Causale = causale;
            Importo = importo;
        }

        //!questi potrebbero essere readonly!
        
        public int Numero { get; private set; }
        public ContoCorrente Conto { get; private set; }
        public DateTime Data { get; private set; }
        public string Causale { get; private set; }
        public double Importo { get; private set; }
    }
}
