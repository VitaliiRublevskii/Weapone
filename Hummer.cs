using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Hummer : Weapone
    {
        public Hummer() : base(1, 20, 0)
        {}

        public override double SetDefend()
        {
            return 0;
        }
    }
}
