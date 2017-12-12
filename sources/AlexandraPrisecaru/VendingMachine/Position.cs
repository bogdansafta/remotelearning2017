using System;

namespace VendingMachine
{
    public class Position : IEquatable<Position>
    {
        public int Row { get; set; } = -1;
        public int Column { get; set; } = -1;

        public Position(int row = 0, int column = 0)
        {
            Row = row;
            Column = column;
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
            return true;
        }

        public override string ToString()
        {
            return $"({Row}, {Column})";
        }
    }
}