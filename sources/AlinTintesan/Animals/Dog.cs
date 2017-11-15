using System;

namespace Animals
{
    class Dog : Animal
    {
        
        private string name;
        public Dog(string n)
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
            return "Woof";
        }
    }
    
}
