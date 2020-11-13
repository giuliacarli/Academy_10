using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Temperature
{
    public class S3
    {
        private Termometro trm;

        public S3(Termometro _trm)
        {
            this.trm = _trm;
            this.trm.TempTooHigh += trm_TempTooHigh;
        }

        public void trm_TempTooHigh(Object sender, TempEventArgs x)
        {
                Console.WriteLine("I'm S1 and the temperature is {0}",
                               x.temp);
        }
    }
}
