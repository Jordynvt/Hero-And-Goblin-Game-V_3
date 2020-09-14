using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_And_Goblin_Game_V_3
{
    abstract class Goblin
    {
        public Goblin(int X, int Y)                   //Where I Started 
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
