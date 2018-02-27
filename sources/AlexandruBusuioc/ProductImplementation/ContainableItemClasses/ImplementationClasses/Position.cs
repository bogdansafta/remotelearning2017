using System;
namespace ProductImplementation
{
    public class Position : IEquatable<Position>
    {
        private int row;
        private int column;
        private int size;
        public int id;
        public Position(int row, int column, int size, int id)
        {
            this.row = row;
            this.column = column;
            this.size = size;
            this.id = id;
        }

        public override string ToString()
        {
            return $"Row:{row} Column:{column} Size:{size} ID:{id}";
        }

        public bool Equals(Position other)
        {
            if (this.row == other.row &&
            this.column == other.column &&
            this.size == other.size && this.id == other.id)
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