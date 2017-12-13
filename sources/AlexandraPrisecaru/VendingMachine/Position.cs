using System;

namespace VendingMachine
{
    public class Position : IEquatable<Position>
    {
        public int Row { get; set; } = -1;
        public int Column { get; set; } = -1;
        public int Size { get; set; } = 1;

        public Position(int row = 0, int column = 0, int size = 1)
        {
            Row = row;
            Column = column;
            Size = size;
        }

        public bool Equals(Position other)
        {
            if (Row != other.Row)
            {
                return false;
            }
            if (Column != other.Column)
            {
                return false;
            }
            if (Size != other.Size)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return $"({Row}, {Column})";
        }
    }
}