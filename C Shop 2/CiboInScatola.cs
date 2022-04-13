using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shop_2
{
    internal class CiboInScatola : Prodotto
    {
        private double peso;
        private string materialeScatola;
        public CiboInScatola(string nome, string descrizione, double peso, double prezzo, int iva) : base(nome, descrizione, prezzo, iva)
        {
            this.peso = peso;
             
            this.materialeScatola = materialeScatola;
        }
        public override void NomeEsteso()
        {
            // CODICE - NOME - LITRI
            Console.WriteLine("Il nome esteso del cibo in scatola è: " + base.PadLeft() + " - " + base.nome + " - " + this.peso + " gr");
        }

        public void Consumi(double peso)
        {
            if (this.peso < 300)
            {
                this.peso = this.peso;
                Console.WriteLine("Ho consumato" + peso);
            }
            else
            {
                Console.WriteLine("Mi dispiace, non è possibile consumare maggiormente");
                this.peso = 0;
            }
        }

    }
}
