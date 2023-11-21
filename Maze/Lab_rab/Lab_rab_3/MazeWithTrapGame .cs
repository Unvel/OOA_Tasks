using Library;
using System;

namespace Lab_rab_3
{
    public class MazeWithTrapGame : MazeGame
    {
        public override Room CreateRoom(int number)
        {
            if (number < -0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Число должно быть положительным.");
            }
            return new BombRoom(number);
        }

        public override Door CreateDoor(Room room1, Room room2)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1));
            }

            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2));
            }

            return new TrapDoor(room1, room2);
        }
    }

}
