namespace Library
{
    public class BombRoom : Room
    {
        private static Random Rnd = new Random();
        public BombRoom(int number) : base(number) { }

        public override void Enter()
        {
            Console.WriteLine("Вы вошли в комнату с бомбой.");

            if (Rnd.Next(2) == 0)
            {
                Console.WriteLine("БУМ!");
                Sides.OfType<BombWall>().ToList().ForEach(x => x.Explode());
            } 
            else 
            { 
                Console.WriteLine("Вам удалось не взорваться"); 
            }
        }
    }
}
