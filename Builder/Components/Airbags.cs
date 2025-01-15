namespace Builder.Components
{
    class Airbags
    {
        public Airbags(int airbag)
        {
            this.Airbag = airbag;
        }

        private int airbag;
        
        public int Airbag
        {
            get => airbag;
            set => airbag = value;
        }
    }
}
