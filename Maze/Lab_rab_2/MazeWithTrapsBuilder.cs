using Library;

namespace Lab_rab_2
{
    internal class MazeWithTrapsBuilder : MazeBuilder
    {
        protected Maze maze = new();

        public virtual void BuildRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Число должно быть положительным.");
            }

            ArgumentNullException.ThrowIfNull(number);
            BombRoom room = new(number);

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

            ArgumentNullException.ThrowIfNull(roomNum1);
            Room room1 = maze.RoomNo(roomNum1);

            ArgumentNullException.ThrowIfNull(roomNum2);
            Room room2 = maze.RoomNo(roomNum2);

            Door door = new(room1, room2);

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
