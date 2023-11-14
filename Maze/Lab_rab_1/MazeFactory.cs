using Library;

namespace Lab_rab_4
{
    public abstract class MazeFactory
    {
        public virtual Maze CreateMaze() => new Maze();
        public virtual Room CreateRoom(int number) => new Room(number);
        public virtual Wall CreateWall() => new Wall();
        public virtual Door CreateDoor(Room room1, Room room2) => new Door(room1, room2);
    }
}
