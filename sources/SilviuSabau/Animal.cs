using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animale_iQuest
{
    abstract public class Animal
    {
        string animal_breed;
        public string GetAnimalName()
        {
            return this.animal_breed;
        }
        public void SetAnimalName(string set_value)
        {
            animal_breed = set_value;
        }
        abstract public string MakeSound();
    }
}
