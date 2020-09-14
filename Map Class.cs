using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_And_Goblin_Game_V_3
{
    class Map_Class
    {

        //sorry for all the errors I thought it was in a console App. I then copied and pasted the console app code into a windows Form application and got all of the errors.
        // I did get rid of a substantial amount, but I cannot fix the rest of the errors.

        private Random randomNumber = new Random();

        public Goblin Goblin { get; set; }
        public Tile[,] GameMap { get; set; }
        public Hero PObject { get; set; }
        public Enemy[] EnemyArr { get; set; }
        public int MapWidth { get; set; }
        public int MapHeight { get; set}


        public Map(int minwidth , int maxwidth , int maxheight , int minheight , int numberOfEnemies)
        {
            EnemyArr = new Enemy[numberOfEnemies];
            MapWidth = randomNumber.Next(minwidth, maxwidth);
            MapHeight = randomNumber.Next(minheight, maxheight);
            GameMap = new Tile[MapWidth, maxheight];

            for (int i = 0; i < GameMap.GetLength(0); i++)
            {
                for (int k = 0; k < GameMap.GetLength(1); k++) ;
                {
                    GameMap[i,k] = new EmptyTile(i,k)
                }
            }

            for (int i = 0; i < GameMap.GetLength(0); i++)
            {
                for (int k = 0; k < GameMap.GetLength(1); k++)
                {
                    GameMap[i,k] = new EmptyTile(i,k)
                }
            }

        }

        public void UpdateVision()
        {
            PObject.CharacterVision[0] = GameMap[PObject.Xval, PObject.Yval];
            PObject.CharacterVision[1] = GameMap[PObject.Xval + 1, PObject.Yval];
            PObject.CharacterVision[2] = GameMap[PObject.Xval, PObject.Yval + 1];
            PObject.CharacterVision[3] = GameMap[PObject.Xval - 1 , PObject.Yval];
            PObject.CharacterVision[4] = GameMap[PObject.Xval, PObject.Yval - 1];

            for (int k = 0; k < EnemyArr.Length; k++)
            {
                EnemyArr[k].CharVision[0] = GameMap[EnemyArr[k].Xval, EnemyArr[k].Yval];
                EnemyArr[k].CharVision[1] = GameMap[EnemyArr[k].Xval + 1; EnemyArr[k].Yval];
                EnemyArr[k].CharVision[2] = GameMap[EnemyArr[k].Xval, EnemyArr[k].Yval + 1;]
                EnemyArr[k].CharVision[1] = GameMap[EnemyArr[k].Xval - 1; EnemyArr[k].Yval];
                EnemyArr[k].CharVision[2] = GameMap[EnemyArr[k].Xval, EnemyArr[k].Yval - 1;]
            }
        }
        public void PlaceObject(Tile obj)
        {
            GameMap[obj.Xval, obj.Yval] = obj;
        }



    }