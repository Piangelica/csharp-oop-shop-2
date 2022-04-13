using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shop_2
{
    internal class Sacchetto_di_Frutta
    {
        private /*static*/ double NumeroPezziFrutta;
        private string materialeSacchetto;
        public Sacchetto_di_Frutta(string nome, string descrizione, double NumeroPezziFrutta,string materialeSacchetto, double prezzo, int iva) : base(nome, descrizione, prezzo, iva)
        {
            this.NumeroPezziFrutta = NumeroPezziFrutta;

            this.materialeSacchetto = materialeSacchetto;
        }
        public override void StampaProdotto()
        {
            // CODICE - NOME - LITRI
            Console.WriteLine("Il nome esteso della bevanda è: " + base.PadLeft() + " - " + base.nome + " - " + this.NumeroPezziFrutta + " pezzi");
        }

        public void Aquisti(double NumeroPezziFrutta)
        {
            if (this.NumeroPezziFrutta < 5)
            {
                this.NumeroPezziFrutta = NumeroPezziFrutta;
                Console.WriteLine("Ho consumato" + NumeroPezziFrutta);
            }
            else
            {
                Console.WriteLine(", mi dispiace, hai consumato la quantità massima di pezzi di frutta");
                this.NumeroPezziFrutta = 0;
            }
        }
    }
}
