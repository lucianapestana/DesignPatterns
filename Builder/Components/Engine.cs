namespace Builder.Components
{
    class Engine
    {
        public Engine(int power)
        {
            this.Power = power;
        }

        private int power;

        public int Power
        {
            get => power;
            set => power = value;
        }
    }
}
