using Lab_rab_1;

namespace Lab_rab_5
{
    class MazeWithBombSingleton : MazeWithBombFactory
    {
        private static MazeWithBombSingleton _instance;

        private MazeWithBombSingleton()
        { }

        public static MazeWithBombSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MazeWithBombSingleton();
            }
            return _instance;
        }
    }
}
