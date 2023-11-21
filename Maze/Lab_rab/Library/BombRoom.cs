using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BombRoom : Room
    {
        private static Random _rnd = new Random();
        public BombRoom(int number) 
        {

        }

        public BombRoom()
        {
        }

        public override void Enter()
        {
            base.Enter();
            if (_rnd.Next(2) == 0)
            {
                Console.WriteLine("Бомба взорвалась");
                sides.OfType<BombWall>().ToList().ForEach(wall => wall.Enter());
            }
        }
        public override Room Clone()
        {
            return (BombRoom)this.MemberwiseClone();
        }
    }
}