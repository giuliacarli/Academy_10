using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Temperature
{
    public class TempEventArgs
    {
        public double temp { get; set; }
    }

    public delegate void EventTemp(Object sender, TempEventArgs x);
}
