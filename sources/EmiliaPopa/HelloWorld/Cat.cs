using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Cat : Animal
    {

          public override string MakeSound()
          {
              return "meeeow";
          }

        public Cat(string n) : base(n)
        {
            this.GetSet = n;
        }

        
    }
}
