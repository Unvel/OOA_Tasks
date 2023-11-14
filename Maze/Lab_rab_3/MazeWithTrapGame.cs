﻿using Library;

namespace Lab_rab_4
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
            ArgumentNullException.ThrowIfNull(room1);
            ArgumentNullException.ThrowIfNull(room2);

            return new TrapDoor(room1, room2);
        }
    }
}