using System;

namespace OOP_Animals
{
     public class Cat:Animal
    {
        public Cat(String name) : base(name){}
        public override String MakeSound()
        {
            String CatSound="MIAU";
            return CatSound;
        }
    }
}