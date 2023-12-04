using System;
using System.Linq;

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
                Sides.OfType<BombWall>().ToList().ForEach(wall => wall.Enter());
            }
        }
        public virtual BombRoom Clone()
        {
            BombRoom clonedRoom = (BombRoom)base.Clone();
            BombRoom roomWithBombClone = new BombRoom(Number);

            return roomWithBombClone;
        }
    }
}