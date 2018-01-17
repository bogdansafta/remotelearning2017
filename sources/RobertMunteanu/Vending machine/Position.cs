using System;
namespace VendingMachine
{
    public class Position : IEquatable<Position>
    {
        public int Row { get; private set; }
        public int Column { get; private set; }
        public int Size { get; private set; }
        public int Id { get; private set; }

        public Position(int Row, int Column, int Size, int Id)
        {
            this.Row = Row;
            this.Column = Column;
            this.Size = Size;
            this.Id = Id;
        }

        public bool Equals(Position otherPosition)
        {
            return (this.Row.Equals(otherPosition.Row) && 
            this.Column.Equals(otherPosition.Column) && 
            this.Size.Equals(otherPosition.Size) &&
            this.Id.Equals(otherPosition.Id)
            );
        }
    }