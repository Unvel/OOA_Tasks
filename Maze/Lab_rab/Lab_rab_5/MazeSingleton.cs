using Lab_rab_1;

namespace Lab_rab_5
{
    public class MazeSingleton : MazeFactory
    {
        private static MazeSingleton _instance;

        private MazeSingleton()
        { }

        public static MazeSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MazeSingleton();
            }
            return _instance;
        }
    }
}