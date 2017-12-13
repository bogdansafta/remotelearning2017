using System;
namespace ProductImplementation
{
    public class Position : IEquatable<Position>
    {
        public int row;
        public int column;
        public int size;

        public Position(int row, int column, int size)
        {
            this.row = row;
            this.column = column;
            this.size = size;
        }

        public override string ToString()
        {
            return $"Row:{row} Column:{column} Size:{size}";
        }

        public bool Equals(Position other)
        {
            if (this.row == other.row &&
            this.column == other.column &&
            this.size == other.size)
                return true;
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Position pos = obj as Position;
            return Equals(pos);
        }

        public override int GetHashCode()
        {
            return this.row.GetHashCode() * 17;
        }

    }
}