namespace ConsoleApp2
{
    abstract class  Weapone
    {
        protected double hp;
        protected int Damage { get; set; }  // урон
        protected int Defend { get; set; } // защита

        private Weapone(){}
        protected Weapone(double hp, int damage, int defend) {
            this.hp = hp;
            this.Damage = damage;
            this.Defend = defend;   
        }

        public void Atack(Soldier on)
        {
            if (on != null)
            {
                
                on.HP -= this.Damage;
            }
        }
        


        public abstract double SetDefend();  //  защита

        public override string ToString()
        {
            return base.ToString() + $" HP weapone: {hp}";
        }
    }
}
