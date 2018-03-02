using System;
using System.Collections.Generic;

namespace ProductImplementation
{
    public class Stock
    {
        public string Name;
        public int Quantity;
        public Stock(string name, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Name}, {Quantity}";
        }
    }
}