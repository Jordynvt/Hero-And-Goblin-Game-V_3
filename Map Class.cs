using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_And_Goblin_Game_V_3
{
    class Map_Class
    {
        abstract class Map
        {
            char[,] gameMap;
            object hero;
            int[] enemies;
            int mapWidth, mapHeight;
            Random rnd;

            public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numberOfEnemies)
            {
                int mapW = rnd.Next(0, mapWidth);
                int mapH = rnd.Next(0, mapHeight);

                for (int x = 0; x < gameMap.GetLength(0); x++)
                {
                    for (int y = 0; y < gameMap.GetLength(1); y++)
                    {
                        gameMap[x, y] = '.';
                    }

                }
                enemies[mapW, mapH];
                Create();
                UpdateVision;
            }

            public void UpdateVision()
            {

            }

            private Tile Create(TileEnum type)
            {

            }
        }
    }
}
