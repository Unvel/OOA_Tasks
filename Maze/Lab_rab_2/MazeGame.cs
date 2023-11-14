namespace Lab_rab_4
{
    public class MazeGame
    {
        public virtual void CreateMaze(MazeBuilder builder)
        {
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1,2);
        }
    }
}
