using System;

namespace Animale
{
    public class Frog : Animal
    {
        public Frog() => this.SetName(null);

        public Frog(String x) => this.SetName(x);

        public override string MakeSound() => "oack";
    }
}
