using Library;

namespace Lab_rab_4
{
    internal class MazeFactoryWithBoombPrototype : MazeFactoryPrototype
    {
        protected MazeFactoryWithBoombPrototype()
             : base(new Maze(), new BombWall(), new BombRoom(), new Door())
        {
        }

    }
}
