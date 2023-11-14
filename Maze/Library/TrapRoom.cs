namespace Library
{
    public class TrapRoom:Room
    {
        public TrapRoom(int Number) : base(Number) { }

        public override void Enter()
        {
            Console.WriteLine("Вы вошли в комнату с ловушкой.");
        }

        public void TriggerTrap()
        {
            Console.WriteLine("Вы попали в ловушку и были возвращены в начало лабиринта.");
        }
    }
}