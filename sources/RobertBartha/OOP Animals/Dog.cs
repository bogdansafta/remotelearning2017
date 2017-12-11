using System;

namespace OOP_Animals
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override string MakeSound()
        {
            string DogSound = "HAM";
            return DogSound;
        }
    }
}