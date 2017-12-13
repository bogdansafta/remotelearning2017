using System;
namespace VendingMachine
{
    public class Position : IEquatable<Position>
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int Size { get; set; }

        public Position(int Row = 0, int Column = 0, int Size)
        {
            this.Row = Row;
            this.Column = Column;
            this.Size = Size;
        }

        public bool Equals(Position secondatyPosition)
        {
            if (this.Row.Equals(secondatyPosition.Row) && this.Column.Equals(secondatyPosition.Column) && this.Size.Equals(secondatyPosition.Size))
                return true;
            else
                return false;
        }
    }