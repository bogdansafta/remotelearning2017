using System;

namespace OOP_Animals
{
    public class Dog : Animal
    {
        public Dog(String name) : base(name) {} 
       
        public override String MakeSound()
        {
            String DogSound="HAM";
            return DogSound;
        }
    }
}