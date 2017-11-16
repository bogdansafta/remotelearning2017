namespace AnimalsOOP
{
    public class Frog : Animal
    {
        private string sound = "whatever sound a frog makes..";
        public override string Name { get; set; }

        public Frog()
        {
            Name = this.GetType().Name;
        }
        
        public override string MakeSound() => sound;
    }
}