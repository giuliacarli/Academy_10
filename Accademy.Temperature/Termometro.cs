using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Temperature
{
    public class Termometro
    {
        public event EventTemp TempTooHigh;

        public void SimulatedTemp(double j)
        {
            if (j>25)
                Console.WriteLine("Sono {0} gradi, la temperatura è troppo alta", j);
        }
    }
}
