using System;
namespace VendingMachine
{
    public class Position : IEquatable<Position>
    {
        public int Row { get; private set; }
        public int Column { get; private set; }
        public int Size { get; private set; }
        public int ID { get; private set; }

        public Position(int Row, int Column, int Size, int ID)
        {
            this.Row = Row;
            this.Column = Column;
            this.Size = Size;
            this.ID = ID;
        }

        public bool Equals(Position otherPosition)
        {
            return (this.Row.Equals(otherPosition.Row) && 
            this.Column.Equals(otherPosition.Column) && 
            this.Size.Equals(otherPosition.Size) &&
            this.ID.Equals(otherPosition.ID)
            );
        }
    }