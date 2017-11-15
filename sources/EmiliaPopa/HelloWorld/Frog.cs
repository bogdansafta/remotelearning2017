using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Frog : Animal
    {
        public override string MakeSound()
        {
            return "croak";
        }

        public Frog(string n) : base(n)
        {
            this.GetSet = n;
        }

    }
}
