using System;

namespace OOP_Animals
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override String MakeSound()
        {
            string CatSound = "MIAU";
            return CatSound;
        }
    }
}