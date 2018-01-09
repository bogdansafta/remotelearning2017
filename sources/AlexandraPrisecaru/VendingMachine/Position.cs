using System;
using System.Reflection;

namespace VendingMachine
{
    public class Position : IEquatable<Position>
    {
<<<<<<< HEAD
        public int Row { get; private set; }
        public int Column { get; private set; }
        public int Size { get; private set; }
        public int Id { get; private set; }

        public Position(int row, int column, int id, int size = 1)
=======
        //TODO CR @BS, Inconsistence in default value assignement. By default int is initialised with 0
        public int Row { get; set; } = -1;
        public int Column { get; set; } = -1;
        public int Size { get; set; } = 1;

        //TODO CR @BS, Redundant value assigment for int
        public Position(int row = 0, int column = 0, int size = 1)
>>>>>>> b1af3edc8098738e111d289541ff659a5c8293a2
        {
            Row = row;
            Column = column;
            Id = id;
            Size = size;
        }

        public bool Equals(Position other)
        {
<<<<<<< HEAD
            if (other == null)
=======
            //TODO CR @BS, Check for null reference
            //TODO CR @BS, Code is duplicated (beside the field name), think how you could reduce the entire code block to one line
            if (Row != other.Row)
>>>>>>> b1af3edc8098738e111d289541ff659a5c8293a2
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