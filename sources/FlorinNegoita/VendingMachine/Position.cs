using System;

namespace VendingMachine
{
    public class Position
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public int Size { get; set; }

        public int Id { get; set; }

        public override string ToString() => $" Row: {Row} , Column: {Column} , Size: {Size} , Id: {Id} ";
    }   
}