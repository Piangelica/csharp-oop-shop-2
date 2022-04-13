using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shop_2
{
  
        internal class Elettrodomestico : Prodotto
        {
            private double peso;
            private string materialeElettrodomestico;
            private double altezza;
            private double larghezza;
            private string colore;
        private bool power;
            public Elettrodomestico(string nome, string descrizione, double peso, double prezzo, int iva) : base(nome, descrizione, prezzo, iva)
            {
            this.peso = peso;
            this.materialeElettrodomestico = materialeElettrodomestico;
            this.altezza = altezza;
            this.larghezza = larghezza;
            this.colore = colore;
            this.power = false;
            }
        public void accendi()
        {
            power = true;
            Console.WriteLine("L'elettrodomestico è accesso");

        }

}
}
