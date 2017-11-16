using System;

namespace AnimalsOOP
{
    public class Dog : Animal
    {
        private string sound = "woof woof";
        public override string Name { get; set; }

        public Dog()
        {
            Name = this.GetType().Name;
        }
        public override string MakeSound() => sound;
    }
}
