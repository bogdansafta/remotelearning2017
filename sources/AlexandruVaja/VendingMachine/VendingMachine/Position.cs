using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Position : IEquatable<Position>
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int Size { get; set; }
        public int ID { get; set; }

        public Position()
        {
            Row = 0;
            Column = 0;
            Size = 0;
            ID = 0;
        }

        bool IEquatable<Position>.Equals(Position other)
        {
            if (Row != other.Row)
                return false;
            if (Column != other.Column)
                return false;
            if (Size != other.Size)
                return false;
            if (ID != other.ID)
                return false;
            return true;
        }

        public override string ToString() => $"Row = {Row}, Column = {Column}, Size = {Size}";
    }
}