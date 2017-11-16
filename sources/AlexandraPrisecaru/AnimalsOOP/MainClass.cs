using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AnimalsOOP
{
    public class MainClass
    {
        private static List<Animal> GetAnimalTypes()
        {
            List<Animal> animalTypes = Assembly.GetExecutingAssembly()
                                               .GetTypes()
                                               .Where(type => type.IsSubclassOf(typeof(Animal)))
                                               .Select(type => (Animal)Activator.CreateInstance(type))
                                               .ToList();
            return animalTypes;
        }

        public static void Main(string[] args)
        {
            List<Animal> animalTypes = GetAnimalTypes();

            Animal[] animals = new Animal[10];
            Random random = new Random();

            for (int index = 0; index < animals.Length; index++)
            {
                int randomIndex = random.Next(animalTypes.Count);
                animals[index] = animalTypes.ElementAt(randomIndex);

                Console.WriteLine($"{animals[index].Name} makes {animals[index].MakeSound()}.");
            }
        }
    }
}