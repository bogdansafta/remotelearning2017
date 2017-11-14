using System;

namespace OOP_Animals
{
    public class Frog:Animal
    {
        public Frog(String name) : base(name){}
        public override String MakeSound()
        {
            String FrogSound="OAC";
            return FrogSound;
        }
    }
}