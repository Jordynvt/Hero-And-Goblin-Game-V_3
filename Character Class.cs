using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_And_Goblin_Game_V_3
{
	abstract class Charachter_Class : Tile_Class
	{
		//sorry for all the errors I thought it was in a console App. I then copied and pasted the console app code into a windows Form application and got all of the errors.
		// I did get rid of a substantial amount, but I cannot fix the rest of the errors.

		protected int hp;
		protected int maxHP;
		protected int damage;
		protected string[] characters_vision;

		enum MovementEnum
		{
			No_Movement,
			Up,
			Down,
			Left,
			Right
		}
		public int HP { get; set; }
		public int MaxHp { get; set; }
		public int Damage { get; set; }
		public string[] Characters_vision { get; set; }
		
		public Charachter_Class(int x , int y, char symbol) : base(x,y)
        {
			this.Symbol;
        }
		public virtual void Attack(Character target)
		{
			target.HP--;
		}
		public bool isDead()
		{
			if (this.HP >= 0 )
			{
				return false;
			}
			else
				return true ;
		}
		public virtual bool CheckRange(target)
		{
			if( DistanceTo(target) <- 1)
            {
				return true;
            }
			else
            {
				return false;
            }
			
		}
		private int DistanceTo(Charachter_Class target)
		{
			int distance = (this.X - target.X) + (this.Y - target.Y);
			int value = Math.Abs(distance);
			return value;
		}
		public void Move(MovementEnum move)
		{
			if (move = MovementEnum.Up)
			{
				Y += 1;
			}
			else if (move = MovementEnum.Down)
			{
				Y -= 1;
			}
			else if (move = MovementEnum.Left)
			{
				X -= 1;
			}
			else
			{
				X += 1;
			}
		}
		public abstract MovementEnum ReturnMove(MovementEnum move = 0)
		{

		}
		public abstract override ToString()
		{

		}
	}
}
