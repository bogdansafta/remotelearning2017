using System;

namespace Products
{
    public class Position
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public int Size { get; set; }

        public override string ToString()
        {
            return $" Row: {Row} , Column: {Column} , Size: {Size} ";
        }
    }   
}