using System;
using System.Collections.Generic;

namespace Tema1
{
    class Program
    {
        static public void HowMakesAnimals()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat("Margareta"));
            animals.Add(new Dog("Hitler"));
            animals.Add(new Frog("Pufi"));
            foreach (Animal element in animals)
                System.Console.WriteLine("The animals {0} makes {1}", element.getName(), element.MakeSound());
        }
        static void Main(string[] args) => HowMakesAnimals();
    }
}
