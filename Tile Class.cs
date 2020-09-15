using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_And_Goblin_Game_V_3
{
	abstract class Tile_Class
	{
		//sorry for all the errors I thought it was in a console App. I then copied and pasted the console app code into a windows Form application and got all of the errors.
		// I did get rid of a substantial amount, but I cannot fix the rest of the errors.

		abstract class Tile                                     //2.1
		{
			protected int x;
			protected int y;

			enum TileType
			{
				Hero,
				Enemy,
				Gold,
				Weapon
			}

			public int X { get; set; }
			public int Y { get; set; }

			public Tile(int xVal, int yVal)          
			{
				X = xVal;
				Y = yVal;
			}
			
			class Obstacle : Tile
			{
				public Obstacle( int x , int y) : base(x,y)          //2.1
				{
					
				}
			}
			class EmptyTile : Tile                                   //2.1
			{
				public EmptyTile( int x , int y) : base (x,y)
				{
					
				}
			}
		}
	}
}
