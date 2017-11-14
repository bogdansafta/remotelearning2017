using System;

namespace OOPAnimals
{
    public class Dog : Animal
    {
        public override string MakeSound()
        {
            return "Woof";
        }
        public override string GetName()
        {
            return "Dog";
        }
    }
}