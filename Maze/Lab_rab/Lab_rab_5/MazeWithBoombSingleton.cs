using Lab_rab_1;

namespace Lab_rab_5
{
    class MazeWithBoombSingleton : MazeWithBombFactory
    {
        private static MazeWithBoombSingleton _instance;

        private MazeWithBoombSingleton()
        { }

        public static MazeWithBoombSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MazeWithBoombSingleton();
            }
            return _instance;
        }
    }
}
