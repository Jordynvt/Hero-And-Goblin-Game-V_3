using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_And_Goblin_Game_V_3
{
	abstract class Tile_Class
	{
		abstract class Tile
		{
			protected int X;
			protected int Y;
			enum TileType
			{
				Hero,
				Enemy,
				Gold,
				Weapon
			}
			public Tile(int xVal, int yVal)
			{
				X = xVal;
				Y = yVal;
			}
			public int X { get; set; }
			public int Y { get; set; }
			class Obstacle : Tile
			{
				public Obstacle()
				{
					Tile(X, Y);
				}
			}
			class EmptyTile : Tile
			{
				public EmptyTile()
				{
					Tile(X, Y);
				}
			}
		}
	}
}
