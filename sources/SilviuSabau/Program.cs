using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animale_iQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animal_list = new List<Animal>();
            Animal_list.Add(new Dog("Rex"));
            Animal_list.Add(new Cat("Garfield"));
            Animal_list.Add(new Frog("CrazyFrog"));
            foreach(Animal element in Animal_list)
                Console.WriteLine("Animalul {0} face {1}", element.GetAnimalName(),element.MakeSound());
        }
        
    }
}
