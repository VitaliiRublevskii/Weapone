using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ShieldWood : Shield
    {

        public ShieldWood() : base(30, 5) { }

        public override double SetDef() // доделать
        {
            if (this.Hp > 0)
            {
                return this.DefendS;
            }
            return 0;
        }

        public override double GetDef()
        {
            return this.Hp;
        }
    }
}
