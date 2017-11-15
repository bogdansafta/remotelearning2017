using System;

namespace AnimalsOOP
{
    public class Cat : Animal
    {
        private string _sound = "nyan nyan nyan nyan";
        public override string Name { get => this.GetType().Name; }
        public override string MakeSound() => _sound;
    }
}
