using Library;

namespace Lab_rab_4
{
    public class MazeWithBombPrototype : MazeFactoryPrototype
    {
        protected MazeWithBombPrototype()
             : base(new BombRoom() , new Door() , new BombWall(),  new Maze())
        {
        }

    }
}
