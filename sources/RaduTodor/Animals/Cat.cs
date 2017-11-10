using System;

namespace Animale
{
    public class Cat : Animal
    {
        public Cat() => this.SetName(null);

        public Cat(String x) => this.SetName(x);

        public override string MakeSound() => "Miau";
    }
}
