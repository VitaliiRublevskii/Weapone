using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Shield
    {
        protected double Hp;
        protected  int DefendS {get; set; }

        private Shield() { }
         protected Shield(double hp, int defendS)
        {
            this.Hp = hp;
            this.DefendS = defendS;
        }


        public override string ToString()
        {
            return base.ToString() + $" HP: {Hp}";
        }

        public abstract double SetDef();
        

        public abstract double GetDef();

      
    }
}
