using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1
{
    abstract class Animal
    {
        String name;
        public Animal() => this.name = null;
        public Animal(String name) => this.name = name;
        public void setName(String name) => this.name = name;
        public String getName() => name;
        abstract public String MakeSound();
    }
}
