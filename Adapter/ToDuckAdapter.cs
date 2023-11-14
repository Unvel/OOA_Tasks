namespace Lab_adapter
{
    public class ToDuckAdapter:Duck
    {
        private Goose _goose;

        public ToDuckAdapter(Goose goose)
        {
            _goose = goose;
        }

        public override void Quack()
        {
            _goose.Cackling();
        }

        public override void Fly()
        {
            _goose.Fly();
        }
    }
}
