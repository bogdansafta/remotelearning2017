using System;
using System.Collections.Generic;

namespace Animale
{

    public class Program
    {
        static void Main(string[] args)
        {
           List<Animal> k=new List<Animal>();
           k.Add(new Cat("Mimi"));
           k.Add(new Dog("Rufi"));
           k.Add(new Frog("Gigi"));
           foreach(var animale in k)
            Console.WriteLine("Animalul {0} scoate sunetul {1}",animale.GetName(), animale.MakeSound());           
        }
    }
}
