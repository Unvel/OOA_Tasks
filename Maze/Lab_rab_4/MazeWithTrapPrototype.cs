using Library;

namespace Lab_rab_4
{
    public class MazeWithTrapPrototype : MazeFactoryPrototype
    {
        protected MazeWithTrapPrototype()
            : base(new TrapRoom(), new TrapDoor() ,new Wall() ,new Maze() )
        {
        }
    }
}
