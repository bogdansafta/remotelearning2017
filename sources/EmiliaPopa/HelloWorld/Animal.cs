using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
  abstract  class Animal
    {
        private string Name;
        public abstract string MakeSound();
        
       public Animal(string n)
        {
            GetSet = n;
        }
        public string GetSet
        {
            get
            {
                return Name;
            }
            set
            {
                   Name = value;
            }
        }
    }
}
