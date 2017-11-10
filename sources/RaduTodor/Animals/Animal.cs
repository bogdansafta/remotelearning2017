using System;

namespace Animale
{
    public abstract class Animal
    {
        String Name;

        public string GetName() => Name;

        public void SetName(string value) => Name = value;

        abstract public String MakeSound();
    }
}
