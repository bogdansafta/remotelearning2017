using System;

namespace VendingMachine
{
    public class Position: IEquatable<Position>
    {
        public int Id {get;set;}
        public int Row { get; set; }
        public int Column { get; set; }
        public int Size { get; set; }
        public Position() { }

        public Position(int row,int column,int size,int id)
        {
            this.Row = row;
            this.Column = column;
            this.Size = size;
            this.Id = id;
        }


        public override string ToString()
        {
          return $"ID:{this.Id}|Row:{this.Row}|Column:{this.Column}|Size:{this.Size}";
        }


        public bool Equals(Position other)
        {
            if(this.Column!=other.Column)
            {
                return false;
            }
            if(this.Row!=other.Row)
            {
                return false;
            }
            if(this.Size!=other.Size)
            {
                return false;
            }
            if(this.Id!=other.Id)
            {
                return false;
            }

            return true;
        }
    }
}
