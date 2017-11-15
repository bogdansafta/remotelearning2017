//using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Cat("Tom");
            Animal b = new Dog("Rex");
            Animal c = new Frog("Oaki");
            Animal[] Array=new Animal[3] {a,b,c};
            foreach(Animal an in Array)
                Console.WriteLine(an.Name+ " makes " + an.MakeSound());
        }
    }
}
