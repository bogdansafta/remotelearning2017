using System;

namespace AnimalsOOP
{
    public class MainAnimal
    {
        public static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];
            animals[0] = new Dog();
            animals[1] = new Cat();
            animals[2] = new Frog();

            foreach(Animal animal in animals)
            {
                Console.WriteLine("The " + animal.Name() + " makes " + animal.MakeSounds() + ".");
            }
        }
    }
}
