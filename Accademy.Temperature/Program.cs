using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Termometro t = new Termometro();

            for (int i = 0; i < 50; i++)
            {
                double x = Accademy.Helper.Helper.GetRandomDouble(20, 30);
                t.SimulatedTemp(x);
            }
        }
    }
}
