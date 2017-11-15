namespace AnimalsOOP
{
    public class Frog : Animal
    {
        private string _sound = "whatever sound a frog makes..";
        public override string Name { get => this.GetType().Name; }
        public override string MakeSound() => _sound;
    }
}