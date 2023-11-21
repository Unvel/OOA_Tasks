using Library;

namespace Lab_rab_4
{
    internal class MazeFactoryWithTrapPrototype : MazeFactoryPrototype
    {
        protected MazeFactoryWithTrapPrototype()
            : base(new Maze(), new Wall(), new TrapRoom(), new TrapDoor())
        {
        }
    }
}
