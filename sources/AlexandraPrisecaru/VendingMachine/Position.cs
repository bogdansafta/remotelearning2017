using System;
using System.Reflection;

namespace VendingMachine
{
    public class Position : IEquatable<Position>
    {
        public int Row { get; private set; }
        public int Column { get; private set; }
        public int Size { get; private set; }
        public int Id { get; private set; }

        public Position(int row, int column, int id, int size = 1)
        {
            Row = row;
            Column = column;
            Id = id;
            Size = size;
        }

        public bool Equals(Position other)
        {
            if (other == null)
            {
                return false;
            }

            foreach (PropertyInfo property in this.GetType().GetProperties())
            {
                if (!property.GetValue(this).Equals(property.GetValue(other)))
                {
                    return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            return $"({Row}, {Column})";
        }
    }
}