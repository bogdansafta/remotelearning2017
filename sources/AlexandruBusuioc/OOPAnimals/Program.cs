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
            Animal[] animals = new Animal[4];
            
            animals[0] = new Dog();
            animals[1] = new Cat();
            animals[2] = new Frog();
            animals[3] = new Snail();

            for(int i=0;i<4;i++)
            {
                System.Console.WriteLine("The "+animals[i].GetName()+" makes "+animals[i].MakeSound());
            }
        }

        public static void ListMethod()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Frog());
            animals.Add(new Snail());
            foreach(Animal animal in animals)
            {
                System.Console.WriteLine("The "+animal.GetName()+" makes "+animal.MakeSound());
            }
        }
    }
}