using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_And_Goblin_Game_V_3
{
    abstract class Enemy_Class : Charachter_Class
    {
        protected Random obj;

        public Enemy_Class(int X, int Y, int enemyDamage, int maxHp, int startHp, char symbol)
        {
            return;
        }
        public override string ToString()
        {
            return base.ToString();
        }


    }
}
