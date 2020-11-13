using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.TestFinale
{
    public class Prodotto
    {
        public int Codice { get; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public double Sconto { get; set; }

        public Prodotto(int cod, string desc, double price, double sconto)
        {
            this.Codice = cod;
            this.Descrizione = desc;
            this.Prezzo = price;
            this.Sconto = sconto;
        }

        public Prodotto(string desc, double price, double sconto)
        {
            this.Codice = -1;
            this.Descrizione = desc;
            this.Prezzo = price;
            this.Sconto = sconto;
        }
        public Prodotto(int cod, string desc)
        {
            this.Codice = cod;
            this.Descrizione = desc;
            this.Prezzo = 0;
            this.Sconto = 0;
        }

        public Prodotto(string desc)
        {
            this.Descrizione = desc;
        }

    }
}
