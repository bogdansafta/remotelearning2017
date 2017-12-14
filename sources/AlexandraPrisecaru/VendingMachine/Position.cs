using System;

namespace VendingMachine
{
    public class Position : IEquatable<Position>
    {
        //TODO CR @BS, Inconsistence in default value assignement. By default int is initialised with 0
        public int Row { get; set; } = -1;
        public int Column { get; set; } = -1;
        public int Size { get; set; } = 1;

        //TODO CR @BS, Redundant value assigment for int
        public Position(int row = 0, int column = 0, int size = 1)
        {
            Row = row;
            Column = column;
            Size = size;
        }

        public bool Equals(Position other)
        {
            //TODO CR @BS, Check for null reference
            //TODO CR @BS, Code is duplicated (beside the field name), think how you could reduce the entire code block to one line
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