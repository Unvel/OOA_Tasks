using Library;
using System;

namespace Lab_rab_1
{
    public class MazeWithTrapsFactory : MazeFactory
    {
        public override Room CreateRoom(int Number)
        {
            if (Number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Number), Number, "Число должно быть положительным.");
            }
            return new TrapRoom(Number);
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
