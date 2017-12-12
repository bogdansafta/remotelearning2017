using System;

namespace VendingMachine
{
    public class Position //: IEquatable<Position>
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public int Size { get; set; }
        
        public Position(int row, int column, int size)
        {
            this.Row = row;
            this.Column = column;
            this.Size = size;
        }

        /* public bool Equals(Position other)
        {
            if (this.Row != other.Row)
                return false;
            if (this.Column != other.Column)
                return false;
            if (this.Size != other.Size)
                return false;
            return true;
        } */

        /* public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Position positionObj = obj as Position;
            if (positionObj == null)
                return false;
            else
                return this.Equals(positionObj);
        } */

        public override string ToString() => $"Row: {this.Row} / Column: {this.Column} / Size: {this.Size} ";
    }
}