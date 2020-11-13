using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.TestFinale
{
    public class Negozio
    {
        public string Nome { get; set; }
        public string Proprietario { get; }
        public List<Prodotto> Prodotti { get; set; }
        public Negozio(string name, string prop)
        {
            this.Nome = name;
            this.Proprietario = prop;
        }

        public Negozio(string name, string prop, List<Prodotto> prod)
        {
            this.Nome = name;
            this.Proprietario = prop;
            this.Prodotti = prod;
        }

        public Negozio()
        {
            List<Prodotto> lista_Prod = new List<Prodotto>();
        }
    }
}
