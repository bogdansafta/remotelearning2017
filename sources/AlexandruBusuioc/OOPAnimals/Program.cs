using System;
using System.Collections.Generic;
namespace OOPAnimals
{
    class Program
    {
        public static void Main()
        {
            ArrayMethod();
            ListMethod();
        }
        
        public static void ArrayMethod()
        {
            Animal[] animals = new Animal[] { new Dog(), new Cat(), new Frog(), new Snail() };
            for(int i=0;i<4;i++)
            {
                string name = animals[i].Name;
                string sound = animals[i].MakeSound();
                System.Console.WriteLine($"The {name} makes {sound}");
            }
        }

        public static void ListMethod()
        {
            List<Animal> animals = new List<Animal>() { new Dog(), new Cat(), new Frog(), new Snail() };
            foreach(Animal animal in animals)
            {
                string name = animal.Name;
                string sound = animal.MakeSound();
                System.Console.WriteLine($"The {name} makes {sound}");
            }
        }
    }
}