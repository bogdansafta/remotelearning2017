using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1
{
    class Dog : Animal
    {
        public Dog(String name) => this.setName(name);
        public override String MakeSound() => "hamhamham";
    }
}
