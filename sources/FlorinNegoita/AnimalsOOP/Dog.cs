using System;

namespace AnimalsOOP
{
    public class Dog : Animal
    {
        public override string Name()
        {
            return "Dog";
        }

        public override string MakeSounds()
        {
            return "Ham-Ham";
        }
    }
}