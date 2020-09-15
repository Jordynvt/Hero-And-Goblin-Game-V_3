using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_And_Goblin_Game_V_3
{
    class GameEngine_Class                  //3.3
    {
        //sorry for all the errors I thought it was in a console App. I then copied and pasted the console app code into a windows Form application and got all of the errors.
        // I did get rid of a substantial amount, but I cannot fix the rest of the errors.

        private Map_Class map;
        private static readonly string Hero = "H";
        private static readonly string goblin = "G";
        private static readonly string empty = " ";
        private static readonly string obstacle = "X";

        public GameEngine()
        {
            map = new Map(10, 10, 10, 5);

        }

        public string ParseMap { get; set; }



        public bool MovePlayer (MovementEnum direction)
        {
            if (map.PObject.Char_Vision[1].GetType() == typeof(Empty_Tile))
            {
                return true;
            }
            else if (map.PObject.Char_Vision[2].GetType() == typeof(Empty_Tile))
            {
                return true;
            }
            else if (map.PObject.Char_Vision[3].GetType() == typeof(Empty_Tile))
            {
                return true;
            }
            else if (map.PObject.Char_Vision[4].GetType() == typeof(Empty_Tile))
            {
                return true;
            }
            else
                return false;

        }


        public string EnemyStats()                      //4.1
        {
            return map.gblin.ToString();
            return;
        }

        public override string ToString()  //4.1
        {
            string R_String = "";

            for { int i = 0, i = GameMap.GetLength(0), i++}
            {
                for{ int k = 0; k = map.GameMap.GetLength(1); k++}

                if (map.GameMap[i, k] = typeof(
                {
                    R_String = empty;
                }
            }

        }

      
    }
}
