using Lab_rab_1;

namespace Lab_rab_5
{
    class MazeWithTrapSingleton : MazeWithTrapsFactory
    {
        private static MazeWithTrapSingleton _instance;

        private MazeWithTrapSingleton()
        { }

        public static MazeWithTrapSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MazeWithTrapSingleton();
            }
            return _instance;
        }
    }
}
