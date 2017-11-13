using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animale_iQuest
{
    public class Dog : Animal
    {
        public Dog(string n)
        {
           this.SetAnimalName(n);
        }
        public override string MakeSound()
        {
            return "Dog sound";
        }
    }
}
