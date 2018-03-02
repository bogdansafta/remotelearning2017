using System;
using System.Collections.Generic;

namespace ProductImplementation
{
    public class Sales
    {
        public string Name;
        public int Quantity; 
        public decimal Price;
        public DateTime Date;
        public Sales(string name, int quantity, decimal price)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
            this.Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Name}, {Quantity}, {Price}, {Date}";
        }

    }
}