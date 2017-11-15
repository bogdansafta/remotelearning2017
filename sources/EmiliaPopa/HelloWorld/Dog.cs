using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Dog : Animal
    {
        public override string MakeSound()
        {
            return "woof";
        }

        public Dog(string n) : base(n)
        {
            this.GetSet = n;
        }
    }
}
