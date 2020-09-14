using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_And_Goblin_Game_V_3
{
    abstract class Enemy_Class : Charachter_Class
    {

        //sorry for all the errors I thought it was in a console App. I then copied and pasted the console app code into a windows Form application and got all of the errors.
        // I did get rid of a substantial amount, but I cannot fix the rest of the errors.

        protected Random obj;

        public Random RandomObject
        {
            get { return RandomObject; }
            set { RandomObject = value; }
        }



        public Enemy_Class(int X, int Y, int enemyDamage, int maxHp, int startHp, char symbol) : base(X,Y,symbol)
        {
            this.hp = HP;
            this.MaxHp = max_HP;
            this.damage = EnemyDamage;

               
        }
        public override string ToString()
        {
            return base.ToString();
        }

         abstract class Goblin_Class : Enemy_Class
        {
            public Goblin(int X, int Y) : base(X, Y)
            {
                int GoblinHP = 10;
                int GoblinDamage = 1;
            }
            public override MovementEnum ReturnMove(MovementEnum move = Character.MovementEnum.No_Movement)
            {
                throw new NotImplementedException();

            }



        }
           
    }

    
}
