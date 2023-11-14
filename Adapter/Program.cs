namespace Lab_adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck rubberDuck = new RubberDuck();

            Duck wildDuck = new WildDuck();

            Goose goose = new Goose();  
            Duck gooseAdapter= new ToDuckAdapter(goose);

            Console.WriteLine("Резиновая уточка:");
            rubberDuck.Quack();
            rubberDuck.Fly();

            Console.WriteLine("\nГусь-адапетр:");
            gooseAdapter.Quack();
            gooseAdapter.Fly();

            Console.WriteLine("\nДикая утка:");
            wildDuck.Quack();
            wildDuck.Fly();

            Console.ReadLine();
        }
    }
}