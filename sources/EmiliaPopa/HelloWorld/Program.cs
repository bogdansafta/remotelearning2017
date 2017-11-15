using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
              Animal[] animals = {new Cat("Garfield"),
                  new Dog("Scooby Doo"), new Frog("Franklin")};


        
                  foreach (Animal a in animals)
                  {
                      Console.WriteLine("{0} makes {1}!",a.GetSet,a.MakeSound());
                  }
                  
            Console.ReadKey();        }
    }
}
