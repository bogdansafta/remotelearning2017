using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1
{
    class Cat : Animal
    {
        public Cat(String name) => this.setName(name);
        public override String MakeSound() => "meaumeaumeau";
    }
}
