using System;
using System.Collections.Generic;
using System.Text;

namespace Accademy.TestFinale
{
    public class ProdottoInOfferta : Prodotto
    {
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public ProdottoInOfferta(int cod, string desc, double price, double sconto, DateTime initData, DateTime endData)
            : base(cod, desc, price, sconto)
        {
            this.DataInizio = initData;
            this.DataFine = endData;
        }
    }
}
