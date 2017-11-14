using System;

namespace OOPAnimals
{
    public class Frog : Animal
    {
        public override string MakeSound()
        {
            return "Croak";
        }
        public override string GetName()
        {
            return "Frog";
        }
    }
}