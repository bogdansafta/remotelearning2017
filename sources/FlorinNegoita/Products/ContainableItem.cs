using System;

namespace Products
{
    public class ContainableItem
    {
        public Position Position { get; set; }

         public override string ToString()
        {
            return $" Position: {Position} ";
        }
    }
}