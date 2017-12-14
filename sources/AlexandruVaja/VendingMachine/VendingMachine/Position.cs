using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Position : IEquatable<Position>
    {
        public int Row { get;  set; }
        public int Column { get; set; }
        public int Size { get; set; }

        public Position()
        {
            Row = 0;
            Column = 0;
            Size = 0;
        }
        public override string ToString() => $"Row = {Row}, Column = {Column}, Size = {Size}";

        bool IEquatable<Position>.Equals(Position other)
        {
            if (Row != other.Row)
                return false;
            if (Column != other.Column)
                return false;
            if (Size != other.Size)
                return false;
            return true;
        }
    }
}
