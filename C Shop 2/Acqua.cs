using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shop_2
{
    internal class Acqua : Prodotto
    {
        private double litri;
        private double ph;
        private string sorgentediprovenienza;

        public Acqua(string nomeAcqua, string descrizione, double litri, string materiale, double ph, string sorgentediprovenienza) : base(nomeAcqua, descrizione, litri, ph, sorgentediprovenienza)
        {

            this.litri = litri;
            this.ph = ph;
            this.sorgentediprovenienza=sorgentediprovenienza;
        }

        // COSTRUTTORE SPECIFICO DI BEVANDA che usa il costruttore completo di Prodotto
        public Acqua(string nomeAcqua, string descrizione, double litri, string materiale, double ph, string sorgentediprovenienza) : base(nomeAcqua, descrizione, litri, sorgentediprovenienza)
        {

            this.litri = litri;
            this.ph = ph;
            this.sorgentediprovenienza = sorgentediprovenienza;
        }

        // ------------------ METODI SPECIFICI DELLA CLASSE BEVANDA ------------

        // OVERRIDE (letteralemente SOVRASCRITTURA di un METODO) di NomeEsteso di Prodotto. Override perchè questo metodo esisteva già in Prodotto!
        public override void StampaProdotto()
        {
            // CODICE - NOME - LITRI
            Console.WriteLine("Il nome esteso della bevanda è: " + base.PadLeft() + " - " + base.nome + " - " + this.litri + " litri" + this.ph + "ph"+ this.sorgentediprovenienza + "sorgente");
        }

        public void Bevi(double litriDaBere)
        {
            if (this.litri - litriDaBere > 0)
            {
                this.litri = this.litri - litriDaBere;
                Console.WriteLine("Ho bevuto" + litriDaBere);
            }
            else
            {
                Console.WriteLine("Mi dispiace hai finito la bottiglia");
                this.litri = 0;
            }
            public void Riempi(double litriDaBere)
            {
                if (this.litri < 1.5)
                {
                   
                    Console.WriteLine("Hai riempito tutta la bottiglia" + litriDaBere);
                }
                else
                {
                    Console.WriteLine("Mi dispiace, non è più possibile riempire la bottiglia");
                    this.litri = 0;
                }
                public void Svuota(double litriDaBere)
                {
                    if (this.litri < 1.5)
                    {

                        Console.WriteLine("Rimuovo tutta l’acqua dalla bottiglia. " + litriDaBere);
                    }
                   
                }
    }

        }
    }
}
    

//metodo stampaProdotto() che fa l’override del metodo di base StampaProdotto già dichiarato nella superclasse Prodotto (se non lo avete già fatto dichiaratelo anche nella classe prodotto è si occupa di stampare il “codice - nome”, l lo abbiamo chiamato NomeEsteso), per stampare oltre al codice e al nome dell’acqua, anche la sua sorgente, il ph e i litri contenuti.
//un metodo statico convertiInGalloni(double litri) che presa una quantità di litri restituisca la conversione dei litri in galloni, sapendo che 1 litro è equivalente a 3,785 galloni (ricordatevi di codificare le costanti come 3.785 nel modo corretto come visto in classe).
