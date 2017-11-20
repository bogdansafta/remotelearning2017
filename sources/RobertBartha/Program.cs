using System;

namespace OOP_Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal[] animale = new Animal[3];
            animale[0] = new Dog("Dog");
            animale[1] = new Cat("Cat");
            animale[2] = new Frog("Frog");
            for (int i = 0; i < animale.Length; i++)
            {
                Console.WriteLine($"The {animale[i].name} makes {animale[i].MakeSound()}");
            }
        }
    }
}
