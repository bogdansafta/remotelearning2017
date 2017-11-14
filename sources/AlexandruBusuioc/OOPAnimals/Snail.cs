using System;

namespace OOPAnimals
{
    public class Snail : Animal
    {
        public override string MakeSound()
        {
            return "It doesn't make any sound... (What did you expect?)";
        }
        public override string GetName()
        {
            return "Snail";
        }
    }
}