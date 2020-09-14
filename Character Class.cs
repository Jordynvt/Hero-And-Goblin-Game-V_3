using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_And_Goblin_Game_V_3
{
	abstract class Charachter_Class : Tile_Class
	{
		protected int HP;
		protected int MaxHP;
		protected int Damage;
		protected string[] Characters_vision;

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
		public Character(int X, int Y, char symbol)
		{

		}
		public virtual void Attack(Character target)
		{
			target.HP--;
		}
		public bool isDead()
		{
			if (HP <= 0)
			{
				return true;
			}
			else
				return false;
		}
		public virtual bool CheckRange(Character target)
		{
			if (Math.Abs(target.X - X = 1) || Math.Abs(target.Y - Y = 1){
				return true;
			}
			else
				return false;
		}
		private int DistanceTo(Character target)
		{

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
