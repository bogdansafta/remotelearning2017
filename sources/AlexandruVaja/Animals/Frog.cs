using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1
{
    class Frog : Animal
    {
        public Frog(String name) => this.setName(name);
        public override String MakeSound() => "guitguitguit";
    }
}
