using System;

namespace Animale
{
    public class Dog : Animal
    {
        public Dog() => this.SetName(null);

        public Dog(String x) => this.SetName(x);

        public override string MakeSound() => "HAM HAM";
    }
}
