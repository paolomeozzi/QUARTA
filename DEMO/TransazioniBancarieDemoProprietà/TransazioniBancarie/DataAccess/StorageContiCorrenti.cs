using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BancaWindow2
{
    
    public class StorageContiCorrenti
    {
        const string CONTI = "ASSET/ContiCorrenti.txt";
        const string TRANSAZIONI = "ASSET/Transazioni.txt";

        public ContoCorrente[] CaricaConti()
        {
            string[] datiConti = File.ReadAllLines(CONTI);
            var conti = new List<ContoCorrente>();
            foreach (var contoStr in datiConti)
            {
                if (string.IsNullOrWhiteSpace(contoStr))
                    continue;
                //!NOTA: intercetta l'eccezione e la rilancia.
                //       In questo modo "aggrega" tutti i possibili errori in uno soltanto: "conto non valido"
                try
                {
                    conti.Add(ContoCorrenteDa(contoStr)); //->il metodo ContoCorrenteDa() può sollevare eccezioni!
                }
                catch(Exception e)
                {
                    string msg = string.Format("Formato conto non valido: [{0}]", contoStr);
                    //!NOTA: nel rilanciare l'eccezione, utilizza anche quella originale. 
                    //       In questo modo, il codice applicativo può, se vuole, conoscere nello specifico
                    //       quale errore si è verificato.
                    throw new FormatException(msg, e);
                }
            }
            return conti.ToArray();
        }


        public Transazione[] CaricaTransazioni()
        {
            if (!File.Exists(TRANSAZIONI))
                return new Transazione[0];
            var transazioni = new List<Transazione>();
            string[] datiTransazioni = File.ReadAllLines(TRANSAZIONI);
            foreach (var tStr in datiTransazioni)
            {
                if (string.IsNullOrWhiteSpace(tStr))
                    continue;
                try
                {
                    transazioni.Add(TransazioneDa(tStr));
                }
                catch (Exception e)
                {
                    string msg = string.Format("Formato transazione non valido: [{0}]", tStr);
                    //!NOTA: nel rilanciare l'eccezione, utilizza anche quella originale. 
                    //       In questo modo, il codice applicativo può, se vuole, conoscere nello specifico
                    //       quale errore si è verificato.
                    throw new FormatException(msg, e);
                }
            }
            return transazioni.ToArray();
        }

        private Transazione TransazioneDa(string tStr)
        {
            string[] campi = tStr.Split('|');
            return new Transazione
            {
                Numero = int.Parse(campi[0]),
                NumeroConto = int.Parse(campi[1]),
                Data = DateTime.Parse(campi[2]),
                Causale = campi[3].Trim(),
                Importo = double.Parse(campi[4]),
                
            };
        }

        ContoCorrente ContoCorrenteDa(string contoStr)
        {
            string[] campi = contoStr.Split('|');
            var numero = int.Parse(campi[0]);

            var titolare = campi[1].Trim();
            if (string.IsNullOrWhiteSpace(titolare))
                throw new FormatException("Il titolare non è stato specificato");

            var saldo = double.Parse(campi[2]);
            return new ContoCorrente(numero, titolare, saldo);
            
        }
    }
}
