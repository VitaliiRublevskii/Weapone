using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Soldier
    {
        public bool IsAlive { get; set; }
        public double HP { get; set; }
        public string Name { get; set; }
        private Weapone weapone;  //  оружие
        private Shield shield;   //  щит

        public Soldier(string name, Weapone weapone, Shield shield)
        {
            this.Name = name;
            this.weapone = weapone;
            this.HP = 100;
            this.IsAlive = true;
            
            this.shield = shield;
        }


        public void Combo(Soldier enemy)
        {
            if (enemy.shield.GetDef() > 0)  // если щит еще есть, к здоровью  возвращается размер защиты от щита
            { 
                this.weapone.Atack(enemy);
                enemy.HP += this.shield.SetDef();

            }
            else
            {
                this.weapone.Atack(enemy); // 'this' атакует 'enemy'
                this.HP += this.weapone.SetDefend(); // 'this' получает защиту от своего оружия
            }

            


            if (enemy.shield.GetDef() > 0) { enemy.HP += this.shield.SetDef(); }
                                                                                

            if (enemy.HP <= 0) enemy.IsAlive = false;
        }


        public override string ToString()
        {
            return $"{Name} hp is {HP} and has {weapone} and has {shield} ";
        }
    }
}
