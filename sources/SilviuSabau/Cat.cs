using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animale_iQuest
{
    public class Cat : Animal
    {
        public Cat(string n)
        {
            this.SetAnimalName(n);
        }
        public override string MakeSound()
        {
            return "Cat sound";
        }
    }
}
