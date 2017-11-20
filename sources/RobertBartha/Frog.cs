using System;

namespace OOP_Animals
{
    public class Frog : Animal
    {
        public Frog(string name) : base(name) { }
        public override string MakeSound()
        {
            string FrogSound = "OAC";
            return FrogSound;
        }
    }
}