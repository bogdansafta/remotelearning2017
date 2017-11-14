using System;

namespace OOP_Animals
{
    public abstract class Animal
    {
        public String name;
        public abstract String MakeSound();
        public Animal(String name)
        {
            this.name=name;
        }
    }
}