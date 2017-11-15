using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AnimalsOOP
{
    public class MainClass
    {
        private static List<Animal> _animalTypes;

        private void InitializeAnimalTypes()
        {
            _animalTypes = Assembly.GetExecutingAssembly()
                                             .GetTypes()
                                             .Where(type => type.IsSubclassOf(typeof(Animal)))
                                             .Select(type => (Animal)Activator.CreateInstance(type))
                                             .ToList();
        }

        public static void Main(string[] args)
        {
            Animal[] animals = new Animal[10];
            new MainClass().InitializeAnimalTypes();

            Random random = new Random();
            for (int i = 0; i < animals.Count(); i++)
            {
                int randomIndex = random.Next(_animalTypes.Count);
                Animal randomAnimal = _animalTypes.ElementAt(randomIndex);

                Console.WriteLine($"{randomAnimal?.Name} makes {randomAnimal?.MakeSound()}.");
            }
        }

    }
}