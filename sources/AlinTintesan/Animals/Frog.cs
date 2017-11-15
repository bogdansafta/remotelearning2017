using System;

namespace Animals
{
    class Frog : Animal
    {
        private string name;
        public Frog(string n)
        {
            name = n;
        }
        public override string Name
        {
            get
            {
                return name;
            }
        }
       
        public override string MakeSound()
        {
            return "Oac";
        }
    }
}
