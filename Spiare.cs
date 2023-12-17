using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Spiare : Weapone

    {
        public Spiare() : base(1, 15, 0)
        { }

        public override double SetDefend()
        {
            return 0;
        }
    }
}
