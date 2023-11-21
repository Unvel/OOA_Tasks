using Library;
using System;

namespace Lab_rab_2
{
    public class MazeWithBombBuilder : MazeBuilder
    {
        protected Maze maze = new Maze();

        public virtual void BuildRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Число должно быть положительным.");
            }

            if (number == null)
            {
                throw new ArgumentNullException(nameof(number));
            }
            BombRoom room = new BombRoom(number);

            for (Direction direction = Direction.North; direction <= Direction.West; direction++)
            {
                room.SetSide(direction, new Wall());
            }

            maze.AddRoom(room);

        }

        public virtual void BuildDoor(int roomNum1, int roomNum2)
        {
            if (roomNum1 <= 0 || roomNum2 <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNum1), roomNum1, "Число должно быть положительным.");
            }

            if (roomNum1 == null)
            {
                throw new ArgumentNullException(nameof(roomNum1));
            }
            Room room1 = maze.RoomNo(roomNum1);

            if (roomNum2 == null)
            {
                throw new ArgumentNullException(nameof(roomNum2));
            }
            Room room2 = maze.RoomNo(roomNum2);

            Door door = new Door(room1, room2);
            var tuple = CreateADoor(room1, room2);
            room1.SetSide(tuple.Item1, door);
            room2.SetSide(tuple.Item2, door);
        }

        public Maze GetMaze()
        {
            return maze;
        }
    }

}
