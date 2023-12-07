namespace Strategy
{
    public class RubberDuck : Duck
    {
        public RubberDuck(IFly fly, IQuack quack, ISwim swim)
            : base(new NoFly(), new NoQuack(), new Swim())
        { }

        public override void Quack()
        {
            _quackBehavior.Execute();
        }

        public override void Fly()
        {
            _flyBehavior.Execute();
        }

        public override void Swim()
        {
            _swimBehavior.Execute();
        }
    }
}
