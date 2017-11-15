using System;

namespace Animals
{
    class Cat : Animal
    {
        private string name;
        public Cat(string n)
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
            return "Meow";
        }
    }
}
