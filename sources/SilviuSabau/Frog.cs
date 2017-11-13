using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animale_iQuest
{
    class Frog:Animal
    {
        public Frog(string n)
        {
            this.SetAnimalName(n);
        }
        public override string MakeSound()
        {
            return "Frog sound";
        }
    }
}
