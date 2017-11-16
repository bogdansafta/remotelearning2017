using System;
using System.Collections;
using System.Collections.Generic;
namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals =new List<Animal>{new Dog(), new Cat(), new Frog()};
            
            foreach(var iterator in animals)
            {
                Console.WriteLine(iterator.toString());
            }
           
        }
    }
}
