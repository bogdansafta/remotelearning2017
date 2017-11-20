using System;

namespace OOP_Animals
{
    public abstract class Animal
    {
        public string name;
        public abstract string MakeSound();
        public Animal(string name)
        {
            this.name = name;
        }
    }
}