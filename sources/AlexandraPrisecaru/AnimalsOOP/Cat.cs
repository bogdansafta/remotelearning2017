using System;

namespace AnimalsOOP
{
    public class Cat : Animal
    {
        private string sound = "nyan nyan nyan nyan";
        public override string Name { get; set; }

        public Cat()
        {
            Name = this.GetType().Name;
        }
        
        public override string MakeSound() => sound;
    }
}
