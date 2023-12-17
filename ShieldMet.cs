using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ShieldMet : Shield
    {

        public ShieldMet() : base(40, 10) { }



        public override double SetDef() // доделать
        {
           
            if (this.Hp > 0)
            {
                this.Hp -= 10;
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

