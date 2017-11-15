using System;

namespace Animals
{
    abstract class Animal
    {
        public abstract string Name { get; }
        public abstract string MakeSound();
    }
}
