using System;

namespace AnimalsOOP
{
    public class Dog : Animal
    {
        private string _sound = "woof woof";

        public override string Name => this.GetType().Name;
        public override string MakeSound() => _sound;
    }
}
