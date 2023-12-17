using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Sword : Weapone
    {
        public Sword() : base(1, 10, 3)
        { }

        public override double SetDefend()
        {
            double localHp = 0;
            if (this.hp > 0)
            {
                localHp = (this.hp * 5) / 100;
                this.hp -= localHp;
            }
            return this.hp;
        }
    }
}
