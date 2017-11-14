using System;

namespace OOPAnimals
{
    public class Cat : Animal
    {
        public override string MakeSound()
        {
            return "Meow";
        }
        public override string GetName()
        {
            return "Cat";
        }
    }
}